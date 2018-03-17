using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EeScript : MonoBehaviour {

    public Canvas CanvasEe;


    public void OnMouseDown()
    {
        CanvasEe.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
}
