using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CseScript : MonoBehaviour {

    public Canvas CanvasCse;


    public void OnMouseDown()
    {
        CanvasCse.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
}
