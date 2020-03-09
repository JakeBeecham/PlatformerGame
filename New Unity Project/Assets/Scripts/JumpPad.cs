using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public Vector2 jumpHeight = new Vector2(0, 5);

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D body = collision.gameObject.GetComponent<Rigidbody2D>();

        if(body != null)
        {
            body.AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }
}
