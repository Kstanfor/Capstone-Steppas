using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAnimator : MonoBehaviour
{

    public float moveSpeed = 5f; // Speed of the player
    public Rigidbody2D rb; // Reference to the Rigidbody2D component
    Vector2 movement;
    public Animator animator; // Reference to the Animator component

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // Get the horizontal input
        movement.y = Input.GetAxisRaw("Vertical"); // Get the vertical input

        animator.SetFloat("Horizontal", movement.x); 
        animator.SetFloat("Vertical", movement.y); 
        animator.SetFloat("Speed", movement.sqrMagnitude); // Set the speed parameter in the animator
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
