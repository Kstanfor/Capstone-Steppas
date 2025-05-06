using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public bool PlayerDetected = false;

    public GameObject Player;

    private float Distance;
    public float Speed;

    public float StartPositionX;
    public float StartPositionY;

    Vector3 FlipSprite;

    public int X;
    public int X2;
    public int Y;
    public int Z;

    public float soundRadius = 10f;
    public AudioSource audioSource;

    void Update()
    {
        if(Vector3.Distance(transform.position, Player.transform.position) <= soundRadius)
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }

        if (PlayerDetected == true)
        {
            Distance = Vector2.Distance(transform.position, Player.transform.position);
            Vector2 direction = Player.transform.position - transform.position;

            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, Speed * Time.deltaTime);

            FlipSprite = Player.transform.position;
        }
        else if (PlayerDetected == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(StartPositionX, StartPositionY), Speed * Time.deltaTime);

            FlipSprite = new Vector3(StartPositionX, StartPositionY, transform.position.z);
        }

        if (FlipSprite.x < transform.position.x)
        {
            transform.localScale = new Vector3(X, Y, Z); 
        }
        else if (FlipSprite.x > transform.position.x)
        {
            transform.localScale = new Vector3(X2, Y, Z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MovementSpeed")
        {
            PlayerDetected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MovementSpeed")
        {
            PlayerDetected = false;
        }
    }
}
