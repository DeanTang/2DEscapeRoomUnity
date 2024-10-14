using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private DisplayImage currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("DisplayImg").GetComponent<DisplayImage>();
    }

    public void OnNextArrowClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
    }

    public void OnPreviousArrowClick()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;
    }
}