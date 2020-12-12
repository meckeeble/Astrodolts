using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{ 

    public Button local;
    public Button multi;
    public Button settings;
    public Button exit;
    // Start is called before the first frame update
    void Start()
    {

        local.onClick.AddListener(LoadLocal);
        multi.onClick.AddListener(LoadMulti);
        settings.onClick.AddListener(LoadSettings);
        exit.onClick.AddListener(Exit);

    }

    void LoadLocal()
    {
        SceneManager.LoadScene("LocalLobby");
    }

    void LoadMulti()
    {

    }

    void LoadSettings()
    {

    }

    void Exit()
    {
        Application.Quit();
    }
}
