using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaleScript : MonoBehaviour
{

    public Canvas CanvasMale;

    public void OnMouseDown()
    {
        CanvasMale.gameObject.SetActive(true);
    }
}
