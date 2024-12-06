using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Rigidbody for the player.
    public Rigidbody2D rb;
    //Float variables for the player's Speed and Jump Force.
    public float speed = 20f;
    public float jumpforce = 20f;
    //Public Float variable for checking the radius of the circle
    public float checkRadius;
    //Transform that checks the ground to see if the player's on it.
    public Transform GroundChecker;
    //Public LayerMask that 
    public LayerMask GroundMask;
    //Private Float variable for the x axis.
    private float inputX;
    //Priate bool for checkin if the player is on the ground.
    private bool isOnGround;

  
    //Update method for movement and flipping the player depending on if they move left or right.
    private void Update()
    {
        //Gets the Horizontal Axis so the player can move left and right on the stage.
        inputX = Input.GetAxis("Horizontal");

        //Creates a circle around the player to see if they are on the ground, if they are they can jump.
        isOnGround = Physics2D.OverlapCircle(GroundChecker.position, checkRadius, GroundMask);

        //Calling the flip Method in Update so it flips the player and allows them to jump.
        Flip();

        //KeyCode for Space so the player can jump.
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }

    //Fixed Update method for getting the velocity of the player movement.
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
    }

    //Method that flips the direction the player is facing.
    void Flip()
    {
        if (inputX > 0)
        {
            if (transform.eulerAngles.y != 0f)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
        }
        else
        {
            if (transform.eulerAngles.y != 180f)
            {
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
        }

        
    }

    private void OnDrawGizmos()
    {
        if(GroundChecker != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(GroundChecker.position, checkRadius);
        }
    }




}
