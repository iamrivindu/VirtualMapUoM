using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminScript : MonoBehaviour
{

    public Canvas CanvasAdmin;
   

    public void OnMouseOver()
    {
        CanvasAdmin.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");
        
    }
    public void OnMouseExit()
    {
        CanvasAdmin.gameObject.SetActive(false);
    }

}