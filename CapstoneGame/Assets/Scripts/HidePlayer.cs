using System.Collections.Generic;
using UnityEngine;

public class HidePlayer : MonoBehaviour
{
    public List<HidingSpots> hidingSpots = new List<HidingSpots>();
    public GameObject PlayerObject;

    private bool isHidden = false;
    private SpriteRenderer spriteRenderer;
    private Collider2D playerCollider;
    private PlayerMovement playerMovement;
    private PlayerMovementAnimator playerAnimatorMovement;

    void Start()
    {
        for (int i = 1; i <= 16; i++)
        {
            GameObject spot = GameObject.FindGameObjectWithTag("Hide" + i);

            if (spot != null)
            {
                HidingSpots hs = spot.GetComponent<HidingSpots>();

                if (hs != null)
                {
                    hidingSpots.Add(hs);
                }
            }
        }

        spriteRenderer = PlayerObject.GetComponent<SpriteRenderer>();
        playerCollider = PlayerObject.GetComponent<Collider2D>();
        playerMovement = PlayerObject.GetComponent<PlayerMovement>();
        playerAnimatorMovement = PlayerObject.GetComponent<PlayerMovementAnimator>();
    }

    void Update()
    {
        bool touchingAnyHideSpot = false;

        foreach (HidingSpots spot in hidingSpots)
        {
            if (spot.isTouchingPlayer)
            {
                touchingAnyHideSpot = true;
                break;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isHidden)
            {
                spriteRenderer.enabled = true;
                playerCollider.enabled = true;
                if (playerMovement != null) playerMovement.enabled = true;
                if (playerAnimatorMovement != null) playerAnimatorMovement.enabled = true;
                isHidden = false;
                Debug.Log("Player shown");
            }
            else if (touchingAnyHideSpot)
            {
                spriteRenderer.enabled = false;
                playerCollider.enabled = false;
                if (playerMovement != null) playerMovement.enabled = false;
                if (playerAnimatorMovement != null) playerAnimatorMovement.enabled = false;
                isHidden = true;
                Debug.Log("Player hidden");
            }
        }
    }
}