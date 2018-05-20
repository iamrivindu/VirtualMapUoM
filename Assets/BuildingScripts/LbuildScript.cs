using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LbuildScript : MonoBehaviour
{

    public Canvas CanvasLbuild;

    public void OnMouseOver()
    {
        CanvasLbuild.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasLbuild.gameObject.SetActive(false);
    }
}
