using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayer : MonoBehaviour
{
    public HidingSpots IsTouchingHideSpot;
    public bool ShowPlayer;

    public GameObject PlayerObject;

    void Start()
    {
        IsTouchingHideSpot = GameObject.FindGameObjectWithTag("Hide").GetComponent<HidingSpots>();
    }

    void Update()
    {
        ShowPlayer = IsTouchingHideSpot.isTouchingPlayer;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (ShowPlayer == true)
            {
                ShowPlayer = false;
                PlayerObject.SetActive(false);
            }
            else if (ShowPlayer == false)
            {
                ShowPlayer = true;
                PlayerObject.SetActive(true);
            }
        }
    }
}
