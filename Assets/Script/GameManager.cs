using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    
    [SerializeField] private int _numberOfTeams;
    [SerializeField] private int _numberOfPlayers;
    private List<List<GameObject>> _teams;
    [SerializeField] private GameObject _player;
    private int teamSelected, playerSelected;
    public CharacterManager activeCharacter;

    private void Awake()
    {
        gameManager = this;
    }

    void Start()
    {
        _teams = new List<List<GameObject>>();

        //Generate teams and worms
        for (int i = 0; i < _numberOfTeams; i++)
        {
            _teams.Add(new List<GameObject>());
            GameObject teamsObj = new GameObject("Team " + (i + 1));
            for (int l = 0 ; l < _numberOfPlayers; l++)
            {
                GameObject obj = Instantiate(_player, new Vector3(Random.Range(-10, 10), 0.5f, Random.Range(-10, 10)), Quaternion.identity, teamsObj.transform);
                _teams[i].Add(obj);
            }
        }

        
        teamSelected = 0;
        playerSelected = 0;
        activeCharacter = _teams[teamSelected][playerSelected].GetComponent<CharacterManager>();

    }

    public IEnumerator ChangeActivePlayer(){

        

        yield return new WaitForSeconds(1);

        if (teamSelected == 0)
        {
            teamSelected = 1;
        }
        else
        {
            teamSelected = 0;
        }

        activeCharacter = _teams[teamSelected][playerSelected].GetComponent<CharacterManager>();
        GameObject obj = activeCharacter.gameObject;
    }

    public void OnWormDeath()
    {
        //Remove worm from list
        //If team.count is 0, remove team
        //If only 1 team remains, Victory
    }

    public GameObject GetActivePlayer()
    {
        return activeCharacter.gameObject;
    }

}
