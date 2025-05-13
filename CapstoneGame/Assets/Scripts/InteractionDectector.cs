using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class InteractionDectector : MonoBehaviour
{
    private IInteractable interactableInRange = null;
    public GameObject interactionIcon;

    // [Header("Interaction range")]
    public float Range = 15f;

    // Start is called before the first frame update
    void Start()
    {
        interactionIcon.SetActive(false);
    }

    // public void OnInteract(.CallbackContext context)
    //{

    // }
    void Update()
    {
        // Check if the player presses the 'E' key
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Make sure there is an interactable object available
            if (interactableInRange != null)
            {
                // Call the Interact method on the interactable object.
                // This method should be implemented by any class that implements IInteractable.
                interactableInRange.Interact();
            }
        }

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, Range);
        foreach (var collider in colliders)
        {
            if (collider.TryGetComponent(out IInteractable interactable) && interactable.CanInteract())
            {
                // Set the interactableInRange if an interactable object is found
                interactableInRange = interactable;
                interactionIcon.SetActive(true);
                return;  // Exit once an interactable object is found
            }

            interactableInRange = null;
            interactionIcon.SetActive(false);

        }


    }

   // private void OnTriggerEnter2D(Collider2D collision)
   // {
      //  if (collision.TryGetComponent(out IInteractable interactable) && interactable.CanInteract())
       // {
         //   interactableInRange = interactable;
          //  interactionIcon.SetActive(true);
        //}
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
      //  if (collision.TryGetComponent(out IInteractable interactable) && interactable == interactableInRange)
        //{
          //  interactableInRange = null;
            //interactionIcon.SetActive(false);
        //}
    //}

}
