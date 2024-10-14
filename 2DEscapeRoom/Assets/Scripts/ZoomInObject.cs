using UnityEngine;
using System.Collections;
using System;

public class ZoomInObject : MonoBehaviour, IInteractable
{
    public float ZoomRatio = .5f;
    public void Interact(DisplayImage currentDisplay)
    {
        Camera.main.orthographicSize *= ZoomRatio;
        Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, Camera.main.transform.position.z);
    }
}