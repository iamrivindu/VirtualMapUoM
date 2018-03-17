using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CivilScript : MonoBehaviour {

    public Canvas CanvasCivil;


    public void OnMouseDown()
    {
        CanvasCivil.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
}
