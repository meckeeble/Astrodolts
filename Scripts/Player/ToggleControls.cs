using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleControls : MonoBehaviour
{

    //Control components
    public AddForceMovement move;
    public SpawnBomb bomb;
    public PlayerLookOriginal look;


    //Ragdoll Components
    public Camera cam;
    public AudioListener al;
    public CapsuleCollider cc;
    public Rigidbody rb;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
        move = this.GetComponent<AddForceMovement>();
        bomb = this.GetComponentInChildren<SpawnBomb>();
        look = this.GetComponent<PlayerLookOriginal>();

        cam = this.GetComponentInChildren<Camera>();
        al = this.GetComponent<AudioListener>();
        rb = this.GetComponent<Rigidbody>();
        anim = this.GetComponent<Animator>();
        cc = this.GetComponent<CapsuleCollider>();
        
    }

    public void ToggleControl(bool b)
    {
        move.enabled = b;
        bomb.enabled = b;
        look.enabled = b;
    }

    public void ToggleFloating(bool b)
    {

        // Dis/enable audio and camera
        cam.enabled = !b;
        al.enabled = !b;

        // En/disable ragdoll
        cc.enabled = !b;
        rb.useGravity = !b;
        anim.enabled = !b;
        foreach (var col in this.GetComponentsInChildren<BoxCollider>())
        {
            col.enabled = b;
        }

        foreach (var rb in this.GetComponentsInChildren<Rigidbody>())
        {
            rb.useGravity = !b;
        }
    }

}
