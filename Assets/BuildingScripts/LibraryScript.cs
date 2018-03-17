using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibraryScript : MonoBehaviour
{

    public Canvas CanvasLibrary;

    public void OnMouseDown()
    {
        CanvasLibrary.gameObject.SetActive(true);
    }
}
