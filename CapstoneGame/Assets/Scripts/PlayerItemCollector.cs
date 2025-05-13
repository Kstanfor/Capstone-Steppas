using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemCollector : MonoBehaviour
{
    private InventoryController inventoryController;
    public float collectionRange = 10f;



    // Start is called before the first frame update
    void Start()
    {
        inventoryController = FindObjectOfType<InventoryController>();
    }

    void Update()
    {
        // Use Physics2D.OverlapCircleAll to find all items within the range
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, collectionRange);

        foreach (var collider in colliders)
        {
            if (collider.CompareTag("Item"))
            {
                Item item = collider.GetComponent<Item>();

                if (item != null)
                {
                    bool itemAdded = inventoryController.AddItem(collider.gameObject);

                    if (itemAdded)
                    {
                        item.PickUp();
                        Destroy(collider.gameObject);
                    }
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, collectionRange); // Show range as a wire sphere
    }



    // private void OnTriggerEnter2D(Collider2D collision)
    //{
    //   if (collision.CompareTag("Item"))
    //  {
    //    Item item = collision.GetComponent<Item>();

    //   if (item != null)
    // {
    //   bool itemAdded = inventoryController.AddItem(collision.gameObject);

    // if (itemAdded)
    //{
    //  item.PickUp();
    // Destroy(collision.gameObject);
    // }
    //}
    //}
    //}
}
