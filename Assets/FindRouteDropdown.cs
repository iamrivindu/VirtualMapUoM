using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.EventSystems;

public class FindRouteDropdown : MonoBehaviour
{
     
    public Dropdown origin;
    public Dropdown Destination;
    public List<GameObject> originList = new List<GameObject>();
    public List<string> Buildings = new List<string>();

    private void Start()
    {
        PopulateList();

        
        /*origin.onValueChanged.AddListener(delegate
        {
            Destination.ClearOptions();
            ModifyListFirst();
        });

        Destination.onValueChanged.AddListener(delegate
        {

            //origin.ClearOptions();
            //ModifyListSecond();
            //origin.RefreshShownValue();
            
               

        });*/
    }
    public void PopulateList()
    {

        Buildings.Add("Please select");
        foreach (GameObject building in GameObject.FindGameObjectsWithTag("Player"))
        {   
            originList.Add(building);
            
            Buildings.Add(building.name);
            

        }
        origin.AddOptions(Buildings);
        
    
    }
    public int DropdownGetValue(Dropdown dropdown)
    {
        return dropdown.value;

    }



    public void ModifyListFirst()
    {
        List<string> firstList = new List<string>();

        firstList = Buildings;

        int var = DropdownGetValue(origin);
        Debug.Log(firstList[var]);
        firstList.Remove(Buildings[var]);
        Destination.AddOptions(firstList);
        firstList = Buildings;
    }


    public void ModifyListSecond()
    {

        origin.ClearOptions();
        
        List<string> secondList = new List<string>();

        foreach (string buildingName in Buildings)
        {
            secondList.Add(buildingName);
        }
        int var2 = DropdownGetValue(Destination);

        Debug.Log(secondList[var2]);

        secondList.Remove(Buildings[var2]);

        origin.AddOptions(secondList);
        secondList = Buildings;
    }

   

    private void Update()
    {
       


        
        

    }
}
