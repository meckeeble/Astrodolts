using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void StartPressed(InputAction.CallbackContext ctx)
    {
        Debug.Log("start");
        //Checks if the scene is the game lobby then moves onto main scene on press
        if (SceneManager.GetActiveScene().name == "LocalLobby" && FindObjectsOfType<PlayerInput>().Length > 0)
        {
            FindObjectOfType<PlayerInputManager>().splitScreen = true;      
            SceneManager.LoadScene("Main");
        }
    }

}
