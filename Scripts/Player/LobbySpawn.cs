using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbySpawn : MonoBehaviour
{
    ToggleControls tc;
    public AudioSource jet;

    private void Start()
    {
       
    }


    public void OnPlayerJoined(PlayerInput player)
    {
        UnityEngine.Random.InitState(player.playerIndex);

        tc = player.GetComponent<ToggleControls>();
        tc.move = player.GetComponent<AddForceMovement>();
        tc.bomb = player.GetComponentInChildren<SpawnBomb>();
        tc.look = player.GetComponent<PlayerLookOriginal>();

        tc.cam = player.GetComponentInChildren<Camera>();
        tc.al = player.GetComponent<AudioListener>();
        tc.rb = player.transform.Find("Armature").Find("Root").GetComponent<Rigidbody>();
        tc.anim = player.GetComponent<Animator>();
        tc.cc = player.GetComponent<CapsuleCollider>();
        

        //Instantiate player
        player.transform.position = GameObject.FindGameObjectsWithTag("Respawn")[player.playerIndex].transform.position;

        //Disable control
        tc.ToggleControl(false);
        tc.ToggleFloating(true);
        tc.rb.AddTorque(UnityEngine.Random.Range(-1000, 1000), UnityEngine.Random.Range(-1000, 1000), UnityEngine.Random.Range(-1000, 1000));

        //Sound effect on join
        jet.enabled = true;
        jet.Play(0);
    }

}
