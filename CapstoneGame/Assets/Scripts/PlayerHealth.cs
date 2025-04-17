using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 3;

    public bool Damage = false;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public GameObject Player;

    void Update()
    {
        if(Damage == true)
        {
            Health--;
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
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Damage = true;
        }

        if(Damage == true)
        {
            Damage = false;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && Damage == true)
        {
            Damage = false;
        }
    }
}
