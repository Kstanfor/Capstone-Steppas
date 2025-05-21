using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public PlayerHealth playerHealth;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (playerHealth != null)
            {
                playerHealth.Respawn();
            }
            else
            {
                Debug.LogWarning("PlayerHealth reference not set!");
            }
        }
    }
}
