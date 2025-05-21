using UnityEngine;

public class HealthItem : Item
{
    public override void UseItem()
    {
        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
        if (playerHealth != null && playerHealth.Health < 3)
        {
            playerHealth.Health += 1;
            Debug.Log("Healed 1 HP. Current health: " + playerHealth.Health);

            Slot slot = GetComponentInParent<Slot>();
            if (slot != null)
            {
                slot.currentItem = null;
            }

            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Health is already full.");
        }
    }
}