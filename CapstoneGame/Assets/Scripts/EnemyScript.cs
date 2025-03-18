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

    void Start()
    {
        
    }

    void Update()
    {
        if (PlayerDetected == true)
        {
            Distance = Vector2.Distance(transform.position, Player.transform.position);
            Vector2 direction = Player.transform.position - transform.position;

            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, Speed * Time.deltaTime);
        }   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerDetected = true;
    }
}
