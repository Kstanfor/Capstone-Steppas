using UnityEngine;

public class HealthItem : Item
{
    public enum Size { Small, Big }
    public Size potionSize = Size.Small;

    public override void UseItem()
    {
        base.UseItem();

        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
        if (playerHealth != null)
        {
            if (potionSize == Size.Small)
                playerHealth.increaseHealthSmall();
            else
                playerHealth.increaseHealthBig();
        }

        Destroy(gameObject);
    }
}
