using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChemicalScript : MonoBehaviour {

    public Canvas CanvasChemical;


    public void OnMouseOver()
    {
        CanvasChemical.gameObject.SetActive(true);
        Debug.Log("Canvas Opened");

    }
    public void OnMouseExit()
    {
        CanvasChemical.gameObject.SetActive(false);
    }
}
