using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reen 8/3/2021 Created the script.




public class CharacterMovement : MonoBehaviour
{
    #region VARIABLES
    //Rig attached to player's char.
    public Rigidbody2D playerAvatar;

    //Controllers of base/limit of player speed
    public float MainImpulse;
    public float Acceleration = 0.015f;
    public float MaxAcceleration;
    public float SlowDownForce = 5f;

    private bool StopMovement = false;
    //Controller of jump velocity
    public float JumpImpulse;

    public bool Grounded = false;

    #endregion

    void Update()
    {
        #region HORIZONTAL MOVEMENT
        if (Input.GetAxis("Horizontal") != 0f)
        {
            playerAvatar.velocity = new Vector2(Input.GetAxis("Horizontal") * MainImpulse * Acceleration, playerAvatar.velocity.y);
            StopMovement = true;
            Acceleration += 0.015f;
            if(Acceleration > MaxAcceleration)
            {
                Acceleration = MaxAcceleration;
            }
        }
        else
        {
            if (playerAvatar.velocity.x < 0 && StopMovement == true)
            {
                playerAvatar.AddForce(new Vector2(SlowDownForce, 0f));
                StopMovement = false;
                Acceleration = 0.015f;
            }
            else if (StopMovement == true)
            {
                playerAvatar.AddForce(new Vector2(-SlowDownForce, 0f));
                StopMovement = false;
                Acceleration = 0.015f;
            }
        }
        #endregion
        #region VERTICAL MOVEMENT
        if((Input.GetAxis("Vertical") > 0 || Input.GetKey(KeyCode.Space) ) && Grounded == true)
        {
            Grounded = false;
            playerAvatar.AddForce(new Vector2(0f, JumpImpulse));
        }
        #endregion
    }
    #region MISCELLANEOUS
    private void OnTriggerStay2D(Collider2D collision)
    {
        Grounded = true;
        playerAvatar.velocity = new Vector2(playerAvatar.velocity.x, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerAvatar.AddForce(new Vector2(0f, SlowDownForce));
    }
    #endregion
}