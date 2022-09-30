using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int _numberOfTeams;
    [SerializeField] private int _numberOfPlayers;
    private List<List<GameObject>> _teams;
    [SerializeField] private GameObject _player;
    private int teamSelected, playerSelected;
    public static CharacterManager activeCharacter;


    void Start()
    {
        _teams = new List<List<GameObject>>();

        //Generate teams and worms
        for (int i = 0; i < _numberOfTeams; i++)
        {
            GameObject teamsObj = new GameObject("Team " + (i + 1));
            for (int l = 0 ; l < _numberOfPlayers; l++)
            {
                GameObject obj = Instantiate(_player, new Vector3(Random.Range(-10, 10), 0.5f, Random.Range(-10, 10)), Quaternion.identity, teamsObj.transform);
                //_teams[i][l].Add
            }
        }

        //Set index for reference in other scripts who is the selected player
        teamSelected = 0;
        playerSelected = 0;
        activeCharacter = _teams[0][0].GetComponent<CharacterManager>();

    }

    void ChangeActivePlayer() {

    }

}
