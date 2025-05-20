using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector]
    public Vector2 movement;

    public float speed;
    float speedX;
    float speedY;

    public GameObject Player;
    public GameObject WalkTrigger;
    public GameObject SprintTrigger;
    public GameObject CrouchTrigger;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        WalkTrigger.SetActive(true);
        SprintTrigger.SetActive(false);
        CrouchTrigger.SetActive(false);
    }

    public void MovementSpeed()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            speed = 20.0f;

            SprintTrigger.SetActive(true);
            CrouchTrigger.SetActive(false);
            WalkTrigger.SetActive(false);
        }
        else if(Input.GetKey(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
        {
            speed = 3.0f;

            SprintTrigger.SetActive(false);
            CrouchTrigger.SetActive(true);
            WalkTrigger.SetActive(false);
        }
        else
        {
            speed = 10.0f;
            SprintTrigger.SetActive(false);
            CrouchTrigger.SetActive(false);
            WalkTrigger.SetActive(true);
        }
    }

    void Update()
    {
        MovementSpeed();

        speedX = Input.GetAxisRaw("Horizontal") * speed;
        speedY = Input.GetAxisRaw("Vertical") * speed;

        rb.velocity = new Vector2(speedX, speedY);

        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
}
