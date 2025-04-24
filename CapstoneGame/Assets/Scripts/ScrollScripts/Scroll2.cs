using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll2 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Text2Part1;
    public GameObject Text2Part2;
    public GameObject PressSpace;

    public bool isTouchPlayer = false;

    public int KeepTrackOfText = 0;

    void Start()
    {
        TextBox.SetActive(false);
        Text2Part1.SetActive(false);
        Text2Part2.SetActive(false);
        PressSpace.SetActive(false);
    }

    void Update()
    {
        if (isTouchPlayer == true && Input.GetKeyDown(KeyCode.Space))
        {
            KeepTrackOfText++;
        }

        if (isTouchPlayer == true && Input.GetKeyDown(KeyCode.E) && KeepTrackOfText == 0)
        {
            TextBox.SetActive(true);
            Text2Part1.SetActive(true);
            Text2Part2.SetActive(false);
            PressSpace.SetActive(true);
        }
        else if (KeepTrackOfText == 1)
        {
            TextBox.SetActive(true);
            Text2Part1.SetActive(false);
            Text2Part2.SetActive(true);
            PressSpace.SetActive(true);
        }
        else if (KeepTrackOfText == 2)
        {
            isTouchPlayer = false;
            KeepTrackOfText = 0;
        }

        if (isTouchPlayer == false)
        {
            TextBox.SetActive(false);
            Text2Part1.SetActive(false);
            Text2Part2.SetActive(false);
            PressSpace.SetActive(false);
            KeepTrackOfText = 0;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isTouchPlayer = true;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isTouchPlayer = false;
            KeepTrackOfText = 0;
        }
    }
}
