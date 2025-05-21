using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    //private ItemDictionary itemDictionary;

    public GameObject inventoryPanel;
    public GameObject slotPrefab;
    public int slotCount;
    public GameObject[] itemPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        //itemDictionary = FindObjectOfType<ItemDictionary>();
        for (int i = 0; i < slotCount; i++)
        {
            Slot slot = Instantiate(slotPrefab, inventoryPanel.transform).GetComponent<Slot>();

            if (i < itemPrefabs.Length)
            {
                GameObject item = Instantiate(itemPrefabs[i], slot.transform);
                item.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                slot.currentItem = item;
            }
        }
    }

    public bool AddItem(GameObject itemObject)
    {
        foreach (Transform slotTransform in inventoryPanel.transform)
        {
            Slot slot = slotTransform.GetComponent<Slot>();
            if (slot != null && slot.currentItem == null)
            {
                itemObject.transform.SetParent(slot.transform);
                itemObject.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                slot.currentItem = itemObject;

                Collider2D col = itemObject.GetComponent<Collider2D>();
                if (col) col.enabled = false;

                Rigidbody2D rb = itemObject.GetComponent<Rigidbody2D>();
                if (rb) rb.simulated = false;

                return true;
            }
        }
        Debug.Log("Inventory Full");
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
