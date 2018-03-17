using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GroundScript : MonoBehaviour
{

    public Canvas CanvasGround;

    public void OnMouseDown()
    {
        CanvasGround.gameObject.SetActive(true);
    }
}