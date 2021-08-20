using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(horizontalInput / 10f, verticalInput / 10f, 0);

            transform.position = transform.position + movement;
        }
    }

    private void Update()
    {
        HandleMovement();
    }
}
