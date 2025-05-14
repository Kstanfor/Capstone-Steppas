using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingSpots : MonoBehaviour
{
    public bool isTouchingPlayer = false;

    public bool ShouldAnimate = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.E) && isTouchingPlayer == true)
        {
            ShouldAnimate = true;
        }
        else
        {
            ShouldAnimate = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isTouchingPlayer = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isTouchingPlayer = false;
        }
    }
}