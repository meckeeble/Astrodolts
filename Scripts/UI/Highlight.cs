using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highlight : MonoBehaviour
{
    //Script for UI elements. Currently disabled due to on going issues.
    public RectTransform throwBar;
    public SpawnBomb barSize;

    void Start()
    {
        barSize = GameObject.Find("Spawner").GetComponent<SpawnBomb>();
    }

    void Update()
    {
        throwBar.localScale = new Vector3(barSize.throwForce*0.04f, 0.1f, 1f);
    }
}
