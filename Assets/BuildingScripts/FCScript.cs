using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FCScript : MonoBehaviour {

    public Canvas CanvasFc;


    public void OnMouseDown()
    {
        CanvasFc.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
}
