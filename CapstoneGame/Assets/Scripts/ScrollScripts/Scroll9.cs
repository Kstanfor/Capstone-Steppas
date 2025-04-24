using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll9 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Text9Part1;
    public GameObject Text9Part2;
    public GameObject Text9Part3;
    public GameObject PressSpace;

    public bool isTouchPlayer = false;

    public int KeepTrackOfText = 0;

    void Start()
    {
        TextBox.SetActive(false);
        Text9Part1.SetActive(false);
        Text9Part2.SetActive(false);
        Text9Part3.SetActive(false);
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
            Text9Part1.SetActive(true);
            Text9Part2.SetActive(false);
            Text9Part3.SetActive(false);
            PressSpace.SetActive(true);
        }
        else if (KeepTrackOfText == 1)
        {
            TextBox.SetActive(true);
            Text9Part1.SetActive(false);
            Text9Part2.SetActive(true);
            Text9Part3.SetActive(false);
            PressSpace.SetActive(true);
        }
        else if (KeepTrackOfText == 2)
        {
            TextBox.SetActive(true);
            Text9Part1.SetActive(false);
            Text9Part2.SetActive(false);
            Text9Part3.SetActive(true);
            PressSpace.SetActive(true);
        }
        else if (KeepTrackOfText == 3)
        {
            isTouchPlayer = false;
            KeepTrackOfText = 0;
        }

        if (isTouchPlayer == false)
        {
            TextBox.SetActive(false);
            Text9Part1.SetActive(false);
            Text9Part2.SetActive(false);
            Text9Part3.SetActive(false);
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
