using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OriginDropdown : MonoBehaviour
{
    private Pathfinding pathfinding;
    public Dropdown origin;
    public Dropdown Destination;
    public  List<GameObject> originList = new List<GameObject>();
    public List<GameObject> modList = new List<GameObject>();
    public  List<GameObject> destinationList = new List<GameObject>();
    public List<string> Buildings = new List<string>();
    public List<string> ModifiedBuildings = new List<string>();

    private static int indexSeeker ;
    private static int indexTarget ;

    public int IndexSeeker {

        get{

            //Debug.Log(indexSeeker);
            return indexSeeker;

            
        }

        set
        {   
            indexSeeker = value;
            //Debug.Log(indexSeeker);
        }


    }

    
    public int IndexTarget
    {
        get
        {
            //Debug.Log(indexTarget);
            return indexTarget;
        }

        set
        {
            indexTarget = value;
        }
    }

    private void Start()
    {
        Destination.gameObject.GetComponent<Dropdown>().interactable = false;
        PopulateList();

        origin.onValueChanged.AddListener(delegate {

            Destination.gameObject.GetComponent<Dropdown>().interactable = true;
            ModifyList();
            


            
        });

        
        
        Destination.onValueChanged.AddListener(delegate
        {
            

            origin.onValueChanged.RemoveAllListeners();
            origin.gameObject.GetComponent<Dropdown>().interactable = false;

            int var2 = DropdownGetValue(Destination);
            //Debug.Log(originList[var2].name);

            IndexTarget = var2;
            //Debug.Log(IndexTarget);
 
        });

        //Destination.onValueChanged.RemoveAllListeners();
    }

    
    public void PopulateList()
    {
        foreach (GameObject building in GameObject.FindGameObjectsWithTag("Building"))
        {
            
            originList.Add(building);
            Buildings.Add(building.name);
            
        }
        origin.AddOptions(Buildings);
    }

    public void ModifyList()
    {
        int var = DropdownGetValue(origin);
        Debug.Log(var);
        Debug.Log(originList[var].name);


        IndexSeeker = var;
        //Debug.Log(IndexSeeker);

        modList = originList;
        Buildings.Remove(originList[var].name);
        modList.Remove(originList[var]);

        foreach(GameObject building in modList )
        {
            //building.gameObject.GetComponent<Collider>().isTrigger = false;
            destinationList.Add(building);
            ModifiedBuildings.Add(building.name);

        }

        Destination.AddOptions(ModifiedBuildings);
        

    }

    public int DropdownGetValue(Dropdown dropdown)
    {
        return dropdown.value;
    }
   

    public GameObject GetSeekerTargetGameObject(List<GameObject> gameObjects, int index)
    {
        Debug.Log(gameObjects[index]);
        return gameObjects[index];
    }

    private void Update()
    {
        
    }

    public void SayHello()
    {
        Debug.Log("Hello ");
    }

}