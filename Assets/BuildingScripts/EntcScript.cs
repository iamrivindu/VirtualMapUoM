using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntcScript : MonoBehaviour {

    public Canvas CanvasEntc;


    public void OnMouseDown()
    {
        CanvasEntc.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
}
