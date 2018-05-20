using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GroundScript : MonoBehaviour
{

    public Canvas CanvasGround;

    public void OnMouseOver()
    {
        CanvasGround.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasGround.gameObject.SetActive(false);
    }
}