using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MechScript : MonoBehaviour
{

    public Canvas CanvasMech;

    public void OnMouseDown()
    {
        CanvasMech.gameObject.SetActive(true);
    }
}