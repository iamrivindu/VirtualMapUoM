using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonDirectoryScript : MonoBehaviour {

    public Button directoryGoButton;
    public Button directoryCancelButton;
    public DirectoryScript directoryScript;
    public Material outlinedMaterial;
    public Material mainMaterial;
   

   
    void Start () {
        Button goButton = directoryGoButton.GetComponent<Button>();
        goButton.onClick.AddListener(delegate {

            directoryScript.directoryDropdown.gameObject.GetComponent<Dropdown>().interactable = false;
            SetDirectoryLocation();
            
        });

        Button cancelButton = directoryCancelButton.GetComponent<Button>();
        cancelButton.onClick.AddListener(delegate {


            directoryScript.directoryDropdown.gameObject.GetComponent<Dropdown>().interactable = true;
            ReturnDirectoryLocation();

        });
    }
	
	
	void Update () {
		
	}

    void SetDirectoryLocation()
    {
        int directoryValue = directoryScript.DirectoryIndex;

        directoryScript.directoryList[directoryValue].GetComponentInChildren<MeshRenderer>().material = outlinedMaterial;
    }
    void ReturnDirectoryLocation()
    {
        int directoryValue = directoryScript.DirectoryIndex;

        directoryScript.directoryList[directoryValue].GetComponentInChildren<MeshRenderer>().material = mainMaterial;
    }
}
