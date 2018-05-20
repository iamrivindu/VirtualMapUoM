using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GymScript : MonoBehaviour
{

    public Canvas CanvasGym;

    public void OnMouseOver()
    {
        CanvasGym.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasGym.gameObject.SetActive(false);
    }
}
