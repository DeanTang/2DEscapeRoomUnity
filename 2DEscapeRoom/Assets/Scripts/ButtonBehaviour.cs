using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public enum ButtonId
    {
        roomChangeButton, returnButton
    }

    public ButtonId ThisButtonId;
    private DisplayImage currentDisplay;

    void Start()
    {
       currentDisplay =  GameObject.Find("DisplayImg").GetComponent<DisplayImage>(); 
    }

    void HideDisplay()
    {
        if (currentDisplay.CurrentState == DisplayImage.State.normal && ThisButtonId == ButtonId.returnButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                GetComponent<Image>().color.b, 0);
            GetComponent<Button>().enabled = false;
            this.transform.SetSiblingIndex(0);
        }

        if (currentDisplay.CurrentState == DisplayImage.State.zoomed && ThisButtonId == ButtonId.roomChangeButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                GetComponent<Image>().color.b, 0);
            GetComponent<Button>().enabled = false;
            this.transform.SetSiblingIndex(0);
        }
    }

    void Display()
    {
        if (currentDisplay.CurrentState == DisplayImage.State.zoomed && ThisButtonId == ButtonId.returnButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                GetComponent<Image>().color.b, 1);
            GetComponent<Button>().enabled = true;
        }

        if (currentDisplay.CurrentState == DisplayImage.State.normal && ThisButtonId == ButtonId.roomChangeButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                GetComponent<Image>().color.b, 1);
            GetComponent<Button>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        HideDisplay();
        Display();
    }
}
