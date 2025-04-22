using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorCollider;
    public GameObject requiredKey;

    private SpriteRenderer sr;
    public Sprite openDoor;


    // Start is called before the first frame update
    void Start()
    {
        doorCollider = GetComponent<Collider2D>().gameObject;
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            for(int i = 0; i < GameObject.FindGameObjectWithTag("GameController").GetComponent<InventoryController>().itemPrefabs.Length; i++)
            {
                if(GameObject.FindGameObjectWithTag("GameController").GetComponent<InventoryController>().itemPrefabs.ElementAt(i) == requiredKey)
                {
                    sr.sprite = openDoor;
                }
            }
        }
    }
}
