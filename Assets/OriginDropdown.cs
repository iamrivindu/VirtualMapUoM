using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OriginDropdown : MonoBehaviour {

    public Dropdown origin;
    public Dropdown Destination;

    public List<GameObject> BuildingList = new List<GameObject>();
    public List<string> Buildings = new List<string>();


    private void Start()
    {
        PopulateList();
    }

    public void PopulateList()
    {

        



        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Player"))
        {

            BuildingList.Add(fooObj);
            Buildings.Add(fooObj.name);

                
             Debug.Log(this + " is an active object");



        }

        origin.AddOptions(Buildings);
        


    }

    public int OriginGetValue()
    {
        return origin.value;
    }

   

    public void ModifyList()
    {
        int var = OriginGetValue();
        Debug.Log(BuildingList[var].name);
        

        Buildings.Remove(BuildingList[var].name);




   
        Destination.AddOptions(Buildings);
    }

    
    
    private void Update()
    {
        ModifyList();
       
    }

}




       


    

    
    
   









   