using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminScript : MonoBehaviour
{

    public Canvas CanvasAdmin;
   

    public void OnMouseDown()
    {
        CanvasAdmin.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");
        
    }

    
}