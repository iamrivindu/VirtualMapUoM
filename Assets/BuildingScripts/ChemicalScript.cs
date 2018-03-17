using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChemicalScript : MonoBehaviour {

    public Canvas CanvasChemical;


    public void OnMouseDown()
    {
        CanvasChemical.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
}
