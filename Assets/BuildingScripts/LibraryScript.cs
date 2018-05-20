using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibraryScript : MonoBehaviour
{

    public Canvas CanvasLibrary;

    public void OnMouseOver()
    {
        CanvasLibrary.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasLibrary.gameObject.SetActive(false);
    }
}
