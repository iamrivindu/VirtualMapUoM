using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LbuildScript : MonoBehaviour
{

    public Canvas CanvasLbuild;

    public void OnMouseDown()
    {
        CanvasLbuild.gameObject.SetActive(true);
    }
}
