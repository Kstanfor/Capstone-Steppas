using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerClickHandler
{
    public int ID;

    public string Name;

    public virtual void UseItem()
    {
        Debug.Log("Using item " +  Name);
    }

    public virtual void PickUp()
    {
        Sprite itemIcon = GetComponent<Image>().sprite;
        if (ItemPickUpUIController.Instance != null)
        {
            ItemPickUpUIController.Instance.ShowItemPickUp(Name, itemIcon);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        UseItem();
    }
}
