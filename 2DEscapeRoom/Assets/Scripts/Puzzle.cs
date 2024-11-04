using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Puzzle : MonoBehaviour
{
    public bool IsCompleted { get; private set; }
    private GameObject displayImage;

    void HideDisplay()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            this.gameObject.SetActive(false);
        }

        if (displayImage.GetComponent<DisplayImage>().CurrentState == DisplayImage.State.normal)
        {
            this.gameObject.SetActive(false);
        }
    }

    bool CompletePuzzle()
    {
        if (IsCompleted) return true;

        IsCompleted = true; 

        var puzzlePieces = FindObjectsOfType<PuzzlePiece>();

        foreach (PuzzlePiece puzzlePiece in puzzlePieces)
        {
            if (!(int.Parse(puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1)) == 
                int.Parse(puzzlePiece.gameObject.GetComponent<Image>().sprite.name.ToString().Substring(puzzlePiece.gameObject.GetComponent<Image>().sprite.name.Length - 1))))
            {
                IsCompleted = false;
            }
        }

        return IsCompleted;
    }

    // Start is called before the first frame update
    void Start()
    {
        displayImage = GameObject.Find("DisplayImg");
    }

    // Update is called once per frame
    void Update()
    {
        if (CompletePuzzle())
        {
            Debug.Log("Complete");
        };
        HideDisplay();
    }
}
