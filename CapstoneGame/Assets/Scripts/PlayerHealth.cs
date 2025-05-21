using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 3;

    public bool Damage = false;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public GameObject Player;

    public Transform respawnPoint;

    public GameObject deathText;
    void Update()
    {
        if(Damage == true)
        {
            Health--;
            Damage = false;
        }

        if (Health == 2)
        {
            Heart1.SetActive(false);
        }
        else if(Health == 1)
        {
            Heart2.SetActive(false);
        }
        else if(Health == 0)
        {
            Heart3.SetActive(false);
            Player.SetActive(false);

            deathText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.R))
            {
                Player.SetActive(true);
                Player.transform.position = respawnPoint.transform.position;
                
            }
        }
        else if(Health == 3)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Damage = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && Damage == true)
        {
            Damage = false;
        }
    }

    public void increaseHealthSmall()
    {
        if (Health == 1 || Health == 2) { Health++; }
    }
    public void increaseHealthBig()
    {
        if (Health == 2) { Health++; }
        else if(Health == 1) { Health += 2; }
    }
}

