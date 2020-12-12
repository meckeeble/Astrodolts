using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, GetComponent<ParticleSystem>().main.duration);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
