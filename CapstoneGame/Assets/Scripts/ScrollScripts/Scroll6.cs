using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll6 : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Text6Part1;
    public GameObject Text6Part2;
    public GameObject Text6Part3;
    public GameObject Text6Part4;
    public GameObject PressSpace;

    public int KeepTrackOfText = 0;

    public bool isTouchPlayer = false;
    void Start()
    {
        TextBox.SetActive(false);
        Text6Part1.SetActive(false);
        Text6Part2.SetActive(false);
        Text6Part3.SetActive(false);
        Text6Part4.SetActive(false);
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
            Text6Part1.SetActive(true);
            Text6Part2.SetActive(false);
            Text6Part3.SetActive(false);
            Text6Part4.SetActive(false);
            PressSpace.SetActive(true);
        }
        else if (KeepTrackOfText == 1)
        {
            TextBox.SetActive(true);
            Text6Part1.SetActive(false);
            Text6Part2.SetActive(true);
            Text6Part3.SetActive(false);
            Text6Part4.SetActive(false);
            PressSpace.SetActive(true);
        }
        else if (KeepTrackOfText == 2)
        {
            TextBox.SetActive(true);
            Text6Part1.SetActive(false);
            Text6Part2.SetActive(false);
            Text6Part3.SetActive(true);
            Text6Part4.SetActive(false);
            PressSpace.SetActive(true);
        }
        else if (KeepTrackOfText == 3)
        {
            TextBox.SetActive(true);
            Text6Part1.SetActive(false);
            Text6Part2.SetActive(false);
            Text6Part3.SetActive(false);
            Text6Part4.SetActive(true);
            PressSpace.SetActive(true);
        }
        else if (KeepTrackOfText == 4)
        {
            isTouchPlayer = false;
            KeepTrackOfText = 0;
        }

        if (isTouchPlayer == false)
        {
            TextBox.SetActive(false);
            Text6Part1.SetActive(false);
            Text6Part2.SetActive(false);
            Text6Part3.SetActive(false);
            Text6Part4.SetActive(false);
            PressSpace.SetActive(false);
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
