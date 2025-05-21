using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    public Vector3 Level1 = new Vector3(-51f, 25f, -2f);
    public Vector3 Level2 = new Vector3(-65f, -39f, -2f);
    public Vector3 Level3 = new Vector3(-204f, 33f, -2f);
    public Vector3 Level4 = new Vector3(71f, -30f, -2f);
    public Vector3 Level5 = new Vector3(60f, 200f, -2f);

    void Update()
    {
        if(TouchDoor1 == true && CollectTutorialKey == false)
        {
            //Play locked sound
        }
        else if(TouchDoor1 == true && CollectTutorialKey == true)
        {
            transform.position = Level1;
        }

        if (TouchDoor2 == true && CollectLevel1Key == false)
        {
            //Play locked sound
        }
        else if (TouchDoor2 == true && CollectLevel1Key == true)
        {
            transform.position = Level2;
        }

        if (TouchDoor3 == true && CollectLevel2Key == false)
        {
            //Play locked sound
        }
        else if (TouchDoor3 == true && CollectLevel2Key == true)
        {
            transform.position = Level3;
        }

        if (TouchDoor4 == true && CollectLevel3Key == false)
        {
            //Play locked sound
        }
        else if (TouchDoor4 == true && CollectLevel3Key == true)
        {
            transform.position = Level4;
        }

        if (TouchDoor4 == true && CollectLevel4Key == false)
        {
            //Play locked sound
        }
        else if (TouchDoor4 == true && CollectLevel4Key == true)
        {
            transform.position = Level5;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "GoldKeyTouch1")
        {
            CollectTutorialKey = true;
        }

        if(collision.gameObject.name == "BronzeKeyTouch2")
        {
            CollectLevel1Key = true;
        }


        if (collision.gameObject.name == "SilverKeyTouch3")
        {
            CollectLevel2Key = true;
        }


        if (collision.gameObject.name == "BronzeKeyTouch4")
        {
            CollectLevel3Key = true;
        }


        if (collision.gameObject.name == "GoldKeyTouch5")
        {
            CollectLevel4Key = true;
        }

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
