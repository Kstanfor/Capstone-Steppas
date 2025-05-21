using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject TutorialKey;
    public GameObject Level1Key;
    public GameObject Level2Key;
    public GameObject Level3Key;
    public GameObject Level4Key;

    public bool CollectTutorialKey = false;
    public bool CollectLevel1Key = false;
    public bool CollectLevel2Key = false;
    public bool CollectLevel3Key = false;
    public bool CollectLevel4Key = false;

    public bool TouchDoor1 = false;
    public bool TouchDoor2 = false;
    public bool TouchDoor3 = false;
    public bool TouchDoor4 = false;
    public bool TouchDoor5 = false;

    public GameObject SafeZone1; 
    public GameObject SafeZone2; 
    public GameObject SafeZone3; 
    public GameObject SafeZone4; 
    public GameObject SafeZone5;

    public bool CheckEndGame = false;

    private Rigidbody2D rb;
    private Collider2D playerCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (TouchDoor1 == true && CollectTutorialKey == true)
        {
            TeleportToSafeZone(SafeZone1);
            TouchDoor1 = false;
        }

        if (TouchDoor2 == true && CollectLevel1Key == true)
        {
            TeleportToSafeZone(SafeZone2);
            TouchDoor2 = false;
        }

        if (TouchDoor3 == true && CollectLevel2Key == true)
        {
            TeleportToSafeZone(SafeZone3);
            TouchDoor3 = false;
        }

        if (TouchDoor4 == true && CollectLevel3Key == true)
        {
            TeleportToSafeZone(SafeZone4);
            TouchDoor4 = false;
        }

        if (TouchDoor5 == true && CollectLevel4Key == true)
        {
            TeleportToSafeZone(SafeZone5);

            CheckEndGame = true;
        }
    }

    private void TeleportToSafeZone(GameObject safeZone)
    {
        if (safeZone != null)
        {
            rb.position = safeZone.transform.position; 
            playerCollider.enabled = false; 

            StartCoroutine(SafeTeleport());
        }
    }

    private IEnumerator SafeTeleport()
    {
        yield return null; 
        playerCollider.enabled = true; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "TutorialGoldKey")
        {
            CollectTutorialKey = true;
        }

        if (collision.gameObject.name == "Level1BronzeKey")
        {
            CollectLevel1Key = true;
        }

        if (collision.gameObject.name == "Level2SilverKey")
        {
            CollectLevel2Key = true;
        }

        if (collision.gameObject.name == "Level3BronzeKey")
        {
            CollectLevel3Key = true;
        }

        if (collision.gameObject.name == "Level4GoldKey")
        {
            CollectLevel4Key = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Door1")
        {
            TouchDoor1 = true;
        }

        if (collision.gameObject.name == "Door2")
        {
            TouchDoor2 = true;
        }

        if (collision.gameObject.name == "Door3")
        {
            TouchDoor3 = true;
        }

        if (collision.gameObject.name == "Door4")
        {
            TouchDoor4 = true;
        }

        if (collision.gameObject.name == "Door5")
        {
            TouchDoor5 = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Door1")
        {
            TouchDoor1 = false;
        }

        if (collision.gameObject.name == "Door2")
        {
            TouchDoor2 = false;
        }

        if (collision.gameObject.name == "Door3")
        {
            TouchDoor3 = false;
        }

        if (collision.gameObject.name == "Door4")
        {
            TouchDoor4 = false;
        }

        if (collision.gameObject.name == "Door5")
        {
            TouchDoor5 = false;
        }
    }
}