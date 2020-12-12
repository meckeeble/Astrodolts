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
        if (SceneManager.GetActiveScene().name == "LocalLobby" && FindObjectsOfType<PlayerInput>().Length > 0)
        {
            FindObjectOfType<PlayerInputManager>().splitScreen = true;      
            SceneManager.LoadScene("Main");
        }
    }

}
