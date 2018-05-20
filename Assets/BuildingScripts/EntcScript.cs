using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntcScript : MonoBehaviour {

    public Canvas CanvasEntc;


    public void OnMouseOver()
    {
        CanvasEntc.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasEntc.gameObject.SetActive(false);
    }
}
