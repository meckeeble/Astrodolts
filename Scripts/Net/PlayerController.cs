using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        SendInputToServer();
    }

    private void SendInputToServer(InputAction.CallbackContext ctx)
    {
        Vector2 _input = ctx.ReadValue<Vector2>();
    }

    ClientSend.PlayerMovement(_input);
}
