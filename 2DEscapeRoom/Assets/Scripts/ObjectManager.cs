using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    private DisplayImage currentDisplay;

    public GameObject[] ObjectsToManage;
    public GameObject[] UIRenderObjects;

    void Start()
    {
        currentDisplay = GameObject.Find("DisplayImg").GetComponent<DisplayImage>();
        RenderUI();
    }

    void Update()
    {
        ManageObjects();
    }

    void ManageObjects()
    {
        for (int i = 0; i < ObjectsToManage.Length; i++)
        {
            if (ObjectsToManage[i].name == currentDisplay.GetComponent<SpriteRenderer>().sprite.name)
            {
                ObjectsToManage[i].SetActive(true);
            }
            else
            {
                ObjectsToManage[i].SetActive(false);
            }
        }
    }

    void RenderUI()
    {
        for (int i = 0; i < UIRenderObjects.Length; i++)
        {
            UIRenderObjects[i].SetActive(false);
        }
    }
}
