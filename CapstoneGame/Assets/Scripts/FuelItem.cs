using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelItem : Item
{
    public override void UseItem()
    {
        base.UseItem();

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponentInChildren<PlayerLightBehavior>().resetLight();

        Destroy(gameObject);
    }
}
