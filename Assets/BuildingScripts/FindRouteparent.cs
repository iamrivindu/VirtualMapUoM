using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindRouteparent : MonoBehaviour {

    public Canvas FindRoutePanel;
    public Canvas Mainmenu;

    private void OnMouseDown()
    {
        FindRoutePanel.gameObject.SetActive(true);
        Mainmenu.gameObject.SetActive(false);
    }
}
