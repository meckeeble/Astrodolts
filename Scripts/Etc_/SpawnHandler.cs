using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SpawnHandler : MonoBehaviour
{
    PlayerInput [] players;
    GameObject [] spawnPoints;
    // Start is called before the first frame update
    void Awake()
    {
        //Find players and spawn points
        players = GameObject.FindObjectsOfType<PlayerInput>();
        spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");

        //Assign player transforms, enable normal gameplay
        foreach(PlayerInput player in players)
        {
            player.transform.position = GameObject.FindGameObjectsWithTag("Respawn")[player.GetComponent<PlayerInput>().playerIndex].transform.position;
            player.GetComponent<ToggleControls>().ToggleFloating(false);
            player.GetComponent<ToggleControls>().ToggleControl(true);
        }
    }

}
