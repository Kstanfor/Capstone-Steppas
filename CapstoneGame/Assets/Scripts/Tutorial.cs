using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public TextMeshProUGUI WelcomeText;
    public TextMeshProUGUI NextText;
    public TextMeshProUGUI SafeSpotText;
    public TextMeshProUGUI WASDTutorialText;
    public TextMeshProUGUI SprintTutorialText;
    public TextMeshProUGUI SneakTutorialText;
    public TextMeshProUGUI HideTutorialText;
    public TextMeshProUGUI ChestAndScrollTutorialText;
    public TextMeshProUGUI InventoryTutorialText;
    public TextMeshProUGUI LightTutorialText;
    public TextMeshProUGUI KeyTutorialText;
    public TextMeshProUGUI LockedDoorText;

    public Image DialogBoxTutorial;

    public int Steps = 0;

    public int W = 0;
    public int A = 0;
    public int S = 0;
    public int D = 0;

    public int Sprint = 0;
    public int Sneak = 0;
    public int Hide = 0;
    public int Chest = 0;
    public int Tab = 0;
    public int Next = 0;

    void Start()
    {
        DialogBoxTutorial.gameObject.SetActive(true);

        WelcomeText.gameObject.SetActive(true);
        NextText.gameObject.SetActive(true);
        SafeSpotText.gameObject.SetActive(false);
        WASDTutorialText.gameObject.SetActive(false);
        SprintTutorialText.gameObject.SetActive(false);
        SneakTutorialText.gameObject.SetActive(false);
        HideTutorialText.gameObject.SetActive(false);
        ChestAndScrollTutorialText.gameObject.SetActive(false);
        InventoryTutorialText.gameObject.SetActive(false);
        LightTutorialText.gameObject.SetActive(false);
        KeyTutorialText.gameObject.SetActive(false);
        LockedDoorText.gameObject.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Steps == 0)
        {
            Steps = 1;
            WelcomeText.gameObject.SetActive(false);
            SafeSpotText.gameObject.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Space) && Steps == 1)
        {
            Steps = 2;
            SafeSpotText.gameObject.SetActive(false);
            NextText.gameObject.SetActive(false);
            WASDTutorialText.gameObject.SetActive(true);
        }
        else if(Steps == 2)
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                W++;
            }
            else if(Input.GetKeyDown(KeyCode.A))
            {
                A++;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                S++;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                D++;
            }

            if(W >= 1 && A >= 1 && S >= 1 && D >= 1)
            {
                Steps = 3;
            }
        }
        else if(Steps == 3)
        {
            WASDTutorialText.gameObject.SetActive(false);
            SprintTutorialText.gameObject.SetActive(true);

            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                Sprint++;
            }

            if(Sprint >= 1)
            {
                Steps = 4;
            }
        }
        else if(Steps == 4)
        {
            SprintTutorialText.gameObject.SetActive(false);
            SneakTutorialText.gameObject.SetActive(true);

            if(Input.GetKeyDown(KeyCode.LeftControl))
            {
                Sneak++;
            }

            if(Sneak >= 1)
            {
                Steps = 5;
            }
        }
        else if(Steps == 5)
        {
            SneakTutorialText.gameObject.SetActive(false);
            HideTutorialText.gameObject.SetActive(true);

            if(Input.GetKeyDown(KeyCode.E))
            {
                Hide++;
            }

            if(Hide >= 2)
            {
                Steps = 6;
            }
        }
        else if(Steps == 6)
        {
            HideTutorialText.gameObject.SetActive(false);
            ChestAndScrollTutorialText.gameObject.SetActive(true);

            if(Input.GetKeyDown(KeyCode.E))
            {
                Chest++;
            }

            if(Chest >= 1)
            {
                Steps = 7;
            }
        }
        else if(Steps == 7)
        {
            ChestAndScrollTutorialText.gameObject.SetActive(false);
            InventoryTutorialText.gameObject.SetActive(true);

            if(Input.GetKeyDown(KeyCode.Tab))
            {
                Tab++;
            }

            if(Tab >= 2)
            {
                Steps = 8;
            }
        }
        else if(Steps == 8)
        {
            InventoryTutorialText.gameObject.SetActive(false);
            LightTutorialText.gameObject.SetActive(true);

            NextText.gameObject.SetActive(true);

            if(Input.GetKeyDown(KeyCode.Space))
            {
                Next++;
            }

            if(Next >= 1)
            {
                Steps = 9;
            }
        }
        else if(Steps == 9)
        {
            LightTutorialText.gameObject.SetActive(false);
            KeyTutorialText.gameObject.SetActive(true);

            if(Input.GetKeyDown(KeyCode.Space))
            {
                Steps++;
            }
        }
        else if(Steps == 10)
        {
            KeyTutorialText.gameObject.SetActive(false);
            NextText.gameObject.SetActive(false);
            DialogBoxTutorial.gameObject.SetActive(false);
        }
    }
}
