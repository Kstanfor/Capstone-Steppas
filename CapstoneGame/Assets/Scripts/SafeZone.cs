//Scott Abbinanti

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameObject Point;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().Health = 3;

            collision.gameObject.GetComponent<PlayerHealth>().respawnPoint = Point.GetComponent<Transform>();

            collision.gameObject.GetComponent<PlayerLightBehavior>().transform.localScale =
                new Vector3(collision.gameObject.GetComponent<PlayerLightBehavior>().maxScale, 
                collision.gameObject.GetComponent<PlayerLightBehavior>().maxScale, 
                collision.gameObject.GetComponent<PlayerLightBehavior>().maxScale);

            collision.gameObject.GetComponent<PlayerLightBehavior>().playerLight.range = 
                collision.gameObject.GetComponent<PlayerLightBehavior>().MaxRange;
        }

        if(collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
}
