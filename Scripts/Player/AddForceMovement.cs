using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;


[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]

//Based on initial code from:
//https://wiki.unity3d.com/index.php/RigidbodyFPSWalker

public class AddForceMovement : MonoBehaviour
{
    private Vector2 moveInput;
    public float speed = 10.0f;
    public float maxVelocityChange = 10.0f;
    public float jumpHeight = 80f;
    public float minJumpAngle = 0.8f;
    private bool jump;
    public bool grounded = false;

    public Rigidbody rb;
    private Animator anim;


    //player action methods
    public void Move(InputAction.CallbackContext ctx)
    {
        moveInput = ctx.ReadValue<Vector2>();
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        jump = ctx.ReadValueAsButton();
    }


    //unity methods
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        anim = gameObject.GetComponentInChildren<Animator>();    
    }

    void FixedUpdate()
    {


        if (moveInput.x != 0 || moveInput.y != 0)
        {
            // Calculate how fast we should be moving
            Vector3 targetVelocity = new Vector3(moveInput.x, 0, moveInput.y);
            targetVelocity = transform.TransformDirection(targetVelocity);
            targetVelocity *= speed;

            // Apply a force that attempts to reach target velocity
            Vector3 velocityChange = (targetVelocity - rb.velocity);
            velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
            velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
            velocityChange.y = 0;
            rb.AddForce(velocityChange, ForceMode.Force);
        }

        //this is a little jank, but I'm new with InputSystem
        if (jump && grounded)
        {
            rb.AddForce(0, jumpHeight, 0);
            grounded = false;
            anim.SetBool("Jump", true);
        }

        //set anim variables
        anim.SetBool("isWalking", moveInput.x != 0 || moveInput.y != 0);
        anim.SetBool("isGrounded", grounded);

    }

    void OnCollisionStay(Collision c)
    {
        // Calculate whether collider in contact is a floor or not
        Vector3 normal = c.contacts[0].normal;
        if ((normal.y >= minJumpAngle))
        {
            grounded = true;
            anim.SetBool("Jump", false);
        }

    }
}

    
