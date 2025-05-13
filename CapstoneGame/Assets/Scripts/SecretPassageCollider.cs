using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionTrigger : MonoBehaviour
{
    // Tag your player object as "Player" in the Unity Editor
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Immediately transition to the secret scene once player hits collider
            SceneManager.LoadScene("Uh");
        }
    }
}