using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject endGameButton; 
    public KeyScript keyScript;

    private void Start()
    {
        if (endGameButton != null)
        {
            endGameButton.SetActive(false); 
        }
    }

    void Update()
    {
        if (keyScript.CheckEndGame)
        {
            if (endGameButton != null)
            {
                endGameButton.SetActive(true);
            }
        }
    }
}