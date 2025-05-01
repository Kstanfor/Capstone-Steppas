using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingSpots : MonoBehaviour
{
    public bool isTouchingPlayer = false;

    public bool ShouldAnimate = false;

    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        var HidePlayer = animator.GetBool("IsPlayerHiding");

        if (Input.GetKey(KeyCode.E) && isTouchingPlayer == true)
        {
            ShouldAnimate = true;
        }
        else
        {
            ShouldAnimate = false;
        }

        if(ShouldAnimate == true)
        {
            animator.SetBool("IsPlayerHiding", true);
        }
        else if(ShouldAnimate == false)
        {
            animator.SetBool("IsPlayerHiding", false);
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