using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodaScript : MonoBehaviour
{

    public Canvas CanvasGoda;

    public void OnMouseOver()
    {
        CanvasGoda.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasGoda.gameObject.SetActive(false);
    }
}