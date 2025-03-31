using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public bool IsOpened { get; private set;}

    public string ChestID { get; private set; }
    public GameObject itemPrefab; // Item that drops
    public Sprite openedSprite;


    // Start is called before the first frame update
    void Start()
    {
        ChestID ??= GlobalHelper.GenerateUniqueID(gameObject); //UniqueID and checks
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        if (!CanInteract()) return; // open chest
        OpenChest();
    }
    
    private void OpenChest()
    {
        //set opened
        SetOpened(true);

        //drop item
        if (itemPrefab)
        {
            GameObject droppedItem = Instantiate(itemPrefab, transform.position + Vector3.down, Quaternion.identity); 
        }
    }

    public void SetOpened(bool opened)
    {
        
        if (IsOpened = opened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;
        }
    }
}
