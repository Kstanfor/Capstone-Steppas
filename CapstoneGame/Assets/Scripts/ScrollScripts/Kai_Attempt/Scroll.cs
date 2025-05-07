using UnityEngine;
using TMPro;

public class Scroll : MonoBehaviour, IInteractable
{
    [Tooltip("Unique ID, if you need persistence")]
    public string scrollID;
    public string scrollTitle;
    [TextArea(5, 10)]
    public string scrollContent;

    public bool CanInteract() => true;

    public void Interact()
    {
        // Open the read panel and register the scroll as collected
        ScrollUIManager.Instance.OpenScroll(this);
    }
}
