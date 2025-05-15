using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public TextMeshProUGUI WASDTutorialText;
    public TextMeshProUGUI ETutorialText;
    public TextMeshProUGUI InventoryTutorialText;
    public TextMeshProUGUI KeyTutorialText;

    public Image DialogBoxTutorial;

    void Start()
    {
        DialogBoxTutorial.gameObject.SetActive(true);

        WASDTutorialText.gameObject.SetActive(true);
        ETutorialText.gameObject.SetActive(false);
        InventoryTutorialText.gameObject.SetActive(false);
        KeyTutorialText.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
}
