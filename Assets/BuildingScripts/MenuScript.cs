using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    public Canvas MainMenu;
    public Canvas PmMenu;

    public void OnMouseDown()
    {
        MainMenu.gameObject.SetActive(true);
        PmMenu.gameObject.SetActive(false);
    }


}
