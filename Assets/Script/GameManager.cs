using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    // Start is called before the first frame update
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

        //Set index for reference in other scripts who is the selected player
        teamSelected = 0;
        playerSelected = 0;
        activeCharacter = _teams[teamSelected][playerSelected].GetComponent<CharacterManager>();

    }

    public void ChangeActivePlayer() {

        //Add one to team selected, or if at the last team, teamSeleced = 0
        //When cycling teams, add +1 to player selected. If last player, player selected = 0;
        //Tip for this: <List>.Count

        teamSelected = 1;
        //playerSelected++;

        activeCharacter = _teams[teamSelected][playerSelected].GetComponent<CharacterManager>();
        GameObject obj = activeCharacter.gameObject;
    }

    public void OnWormDeath()
    {
        //Remove worm from list
        //If team.count is 0, remove team
        //If only 1 team remains, Victory
    }

}
