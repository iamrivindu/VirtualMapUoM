using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GymScript : MonoBehaviour
{

    public Canvas CanvasGym;

    public void OnMouseDown()
    {
        CanvasGym.gameObject.SetActive(true);
    }
}
