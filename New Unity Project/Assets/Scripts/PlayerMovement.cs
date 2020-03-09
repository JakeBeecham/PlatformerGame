using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5;
    public Vector2 jumpHeight = new Vector2(0,5);
    Rigidbody2D body;
    Vector2 movement;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        //vetical is assigned to W and Up Arrow
        //can be changed in the input manager
        if(Input.GetButtonDown("Vertical"))
        {
            //add an impulse to the rigid body using the jump height
            body.AddForce(jumpHeight, ForceMode2D.Impulse);
        }

        //can be multiplied by delta time
        movement *= movementSpeed;

        //important to copy the Y velocity of the rigid body
        //ensures that any change due to gravity/jumping are maintained
        movement.y = body.velocity.y;

        body.velocity = movement;
    }
}
