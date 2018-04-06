using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.EventSystems;


public class DirectoryScript : MonoBehaviour
{
   
    public Dropdown directoryDropdown;
    public List<GameObject> directoryList = new List<GameObject>();
    public List<string> directoryBuildings = new List<string>();

    private static int directoryIndex;

    public int DirectoryIndex
    {
        get
        {
            return directoryIndex;
        }


        set
        {
            directoryIndex = value-1;
        }
    }


    private void Start()
    {
        PopulateList();
        directoryDropdown.onValueChanged.AddListener(delegate
        {




            int directorySelect = DropdownGetValue(directoryDropdown);
            Debug.Log(directoryList[directorySelect].name);

            DirectoryIndex = directorySelect;
            

        });
        
    }


    private void PopulateList()
    {

        directoryBuildings.Add("Please select");
        

        foreach (GameObject building in GameObject.FindGameObjectsWithTag("Building"))
        {
            directoryList.Add(building);

            directoryBuildings.Add(building.name);


        }
        directoryDropdown.AddOptions(directoryBuildings);


    }
    public int DropdownGetValue(Dropdown dropdown)
    {
        return dropdown.value;

    }
    private void Update()
    {

    }
}