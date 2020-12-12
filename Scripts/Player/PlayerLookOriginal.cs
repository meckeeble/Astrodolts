using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLookOriginal : MonoBehaviour
{
    [SerializeField] Transform playerCamera = null;
    [SerializeField] float mouseSensitivity = 3.5f;
    [SerializeField][Range(0.0f, 0.5f)] float mouseSmoothTime = 0.03f;

    int mask;
    Camera cam;

    [SerializeField] bool lockCursor = true;
    public bool useMouse = true;

    float cameraPitch = 0.0f;

    private Vector2 rotateInput;

    Vector2 currentMouseDelta = Vector2.zero;
    Vector2 currentMouseDeltaVelocity = Vector2.zero;

    public void CamTurn(InputAction.CallbackContext ctx)
    {
        rotateInput = ctx.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Start()
    {    
        //Unity bug - Cursor.visible is busted to fuck with InputSystem
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }

        if (useMouse)
        {
            mouseSensitivity = mouseSensitivity / 15;
        }
        /*
        cam = GetComponentInChildren<Camera>();
        Debug.Log(this.name[this.name.Length-2]);
        mask = 1 << 7+Convert.ToInt32(this.name[this.name.Length - 2]);
        Debug.Log(this.gameObject.layer);
        cam.cullingMask = ~mask;
        */
        
    }

    void Update()
    {
        UpdateMouseLook();
    }

    void UpdateMouseLook()
    {
        Vector2 targetMouseDelta = new Vector2(rotateInput.x, rotateInput.y);

        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetMouseDelta, ref currentMouseDeltaVelocity, mouseSmoothTime);

        cameraPitch -= rotateInput.y * mouseSensitivity;
        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);

        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * rotateInput.x * mouseSensitivity);
    }



}

