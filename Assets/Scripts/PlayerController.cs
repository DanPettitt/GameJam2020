using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 keyboardDirection;
    Vector2 facingDirection;
    Rigidbody2D playerRigidbody;
    GridController gridController;

    public int MOVEMENTSPEED = 5;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        gridController = GameObject.Find("Grid").GetComponent<GridController>();
        
    }

    private void FixedUpdate()
    {

        // Move the player based on keyboard input
        playerRigidbody.velocity = keyboardDirection * MOVEMENTSPEED;

        // Get the direction the player is facing in case the player stops the last direction will be saved
        if (playerRigidbody.velocity != Vector2.zero)
        {
            facingDirection = playerRigidbody.velocity.normalized;
        }


    }

    private void Update()
    {
        // Get input from the keyboard to see the direction to move the player
        keyboardDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

}
