using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlsScript : MonoBehaviour {

    public Canvas CanvasGirls;


    public void OnMouseOver()
    {
        CanvasGirls.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasGirls.gameObject.SetActive(false);
    }
}
