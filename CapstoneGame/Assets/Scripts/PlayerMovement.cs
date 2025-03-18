using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    float speedX;
    float speedY;

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

    public void Sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            speed = 20.0f;

            SprintTrigger.SetActive(true);
            CrouchTrigger.SetActive(false);
            WalkTrigger.SetActive(false);
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            speed = 10.0f;

            SprintTrigger.SetActive(false);
            CrouchTrigger.SetActive(false);
            WalkTrigger.SetActive(true);
        }
    }

    public void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
        {
            speed = 3.0f;

            SprintTrigger.SetActive(false);
            CrouchTrigger.SetActive(true);
            WalkTrigger.SetActive(false);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(KeyCode.RightControl))
        {
            speed = 10.0f;

            SprintTrigger.SetActive(false);
            CrouchTrigger.SetActive(false);
            WalkTrigger.SetActive(true);
        }
    }

    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * speed;
        speedY = Input.GetAxisRaw("Vertical") * speed;

        rb.velocity = new Vector2(speedX, speedY);

        Sprint();

        Crouch();
    }
}
