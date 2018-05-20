using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FCScript : MonoBehaviour
{

    public Canvas CanvasFc;

    public void OnMouseOver()
    {
        CanvasFc.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasFc.gameObject.SetActive(false);
    }

}
