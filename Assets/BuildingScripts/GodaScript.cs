using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodaScript : MonoBehaviour
{

    public Canvas CanvasGoda;

    public void OnMouseDown()
    {
        CanvasGoda.gameObject.SetActive(true);
    }
}