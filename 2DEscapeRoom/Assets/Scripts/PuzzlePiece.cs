using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PuzzlePiece : MonoBehaviour, IPointerClickHandler
{
    private GameObject puzzle;
    private Image changeSprite;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (puzzle.GetComponent<Puzzle>().IsCompleted == true)
        {
            return;
        }

        var puzzlePieces = FindObjectsOfType<PuzzlePiece>();

        foreach (PuzzlePiece puzzlePiece in puzzlePieces)
        {
            if (int.Parse(this.gameObject.name.ToString().Substring(this.gameObject.name.Length - 1)) == 
                int.Parse((puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1))) + 1 ||
                int.Parse(this.gameObject.name.ToString().Substring(this.gameObject.name.Length - 1)) ==
                int.Parse((puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1))) - 1 ||
                int.Parse(this.gameObject.name.ToString().Substring(this.gameObject.name.Length - 1)) ==
                int.Parse((puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1))) + 3 ||
                int.Parse(this.gameObject.name.ToString().Substring(this.gameObject.name.Length - 1)) ==
                int.Parse((puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1))) - 3)
            {
                if (puzzlePiece.gameObject.GetComponent<Image>().sprite.name == "mushroom puzzle_8") 
                {
                    changeSprite = puzzlePiece.GetComponent<Image>();
                    changeSprites(GetComponent<Image>(), changeSprite);
                }
            }
        }
    }

    void changeSprites(Image firstSprite, Image secondSprite)
    {
        Sprite temp = firstSprite.sprite;
        firstSprite.sprite = secondSprite.sprite;
        secondSprite.sprite = temp;
    }

    // Start is called before the first frame update
    void Start()
    {
        puzzle = GameObject.Find("Puzzle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
