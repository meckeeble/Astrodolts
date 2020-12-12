using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject menu;
    public InputField usernameField;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Debug.Log("Already running Client instance");
            Destroy(this);
        }
    }

    public void ConnectToServer()
    {
        menu.SetActive(false);
        usernameField.interactable = false;
        GameClient.instance.ConnectToServer();
    }

}
