using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemCollector : MonoBehaviour
{
    private InventoryController inventoryController;

    public float pickupRange = 2f;

    private void Start()
    {
        inventoryController = FindObjectOfType<InventoryController>();
    }

    private void Update()
    {
        DetectAndPickUpItems();
    }

    private void DetectAndPickUpItems()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, pickupRange);

        foreach (var collider in colliders)
        {
            if (collider.CompareTag("Item") && !collider.CompareTag("MovementSpeed")) 
            {
                if (Input.GetKeyDown(KeyCode.E))
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
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, pickupRange);
    }
}