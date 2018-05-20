using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaleScript : MonoBehaviour
{

    public Canvas CanvasMale;

    public void OnMouseOver()
    {
        CanvasMale.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasMale.gameObject.SetActive(false);
    }
}
