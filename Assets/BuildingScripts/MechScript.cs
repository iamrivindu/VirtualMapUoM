﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MechScript : MonoBehaviour
{

    public Canvas CanvasMech;

    public void OnMouseOver()
    {
        CanvasMech.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasMech.gameObject.SetActive(false);
    }
}