using System.Collections;
using System.Collections.Generic;
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

    void Update()
    {
        if (PlayerDetected == true)
        {
            Distance = Vector2.Distance(transform.position, Player.transform.position);
            Vector2 direction = Player.transform.position - transform.position;

            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, Speed * Time.deltaTime);
        }   
        else if(PlayerDetected == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(StartPositionX, StartPositionY), Speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerDetected = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerDetected = false;
    }
}
