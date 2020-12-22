using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Death : MonoBehaviour
{

    private PlayerInput[] players;

    public Collider mainCollider;
    public Collider[] allColliders;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindObjectsOfType<PlayerInput>();
        //spectator = GameObject.FindGameObjectWithTag("Spectator").GetComponent<Camera>();
        rb = GetComponent<Rigidbody>();
        mainCollider = GetComponent<Collider>();
        allColliders = GetComponentsInChildren<Collider>(true);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "DeathBoundary")
        {
            StartCoroutine("DeathTrigger");
        }
    }


    IEnumerator DeathTrigger()
    {
        //swtich to third perso
        Camera [] cameras = GetComponentsInChildren<Camera>();
        cameras[0].enabled = false;
        cameras[1].enabled = true;
        cameras[1].cullingMask = -1;

        //enable ragdoll
        GetComponent<ToggleControls>().ToggleControl(false);
        GetComponent<ToggleControls>().ToggleFloating(false);

        Destroy(GetComponentInChildren<ParticleSystem>());

        //let the the ragdoll camera linger
        yield return new WaitForSeconds(3f);

        //switch to spectate
        this.gameObject.GetComponent<AudioListener>().enabled = false;
        //spectator.enabled = true;
        cameras[1].enabled = false;
        //Audio listeners need sorting
        //spectator.gameObject.GetComponent<AudioListener>().enabled = true;

        Destroy(this.gameObject);

    }
}
