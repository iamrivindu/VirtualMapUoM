using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Pathfinding : MonoBehaviour
{
    public Canvas panelFindRoute;
    public LineObject lineObject;
    private Transform seeker, target;
    public OriginDropdown originDropdown;


    Grid grid;

    public Button GoButton;




    void Start()
    {
        lineObject.GetComponent<LineObject>();
        //lineObject.enabled = true;
        Button goButton = GoButton.GetComponent<Button>();
        goButton.onClick.AddListener(SetRoute);

    }

    public void SetActiveLineObject()
    {
        lineObject.enabled = true;
    }

    public void setDeactiveLineObject()
    {
        lineObject.enabled = false;

    }




    public void SetRoute()
    {
        int dropdownSeekerIndex = originDropdown.IndexSeeker;
        Debug.Log(dropdownSeekerIndex);
        int dropdownTargetIndex = originDropdown.IndexTarget;
        Debug.Log(dropdownTargetIndex);

        if (originDropdown.IndexSeeker <= 15 && originDropdown.IndexTarget <= 14)
        {

            GameObject seekerObject = originDropdown.GetSeekerTargetGameObject(originDropdown.originList, originDropdown.IndexSeeker);
            GameObject targetObject = originDropdown.GetSeekerTargetGameObject(originDropdown.modList, originDropdown.IndexTarget);




            seeker = seekerObject.GetComponent<Transform>();
            Debug.Log(seeker.position);
            target = targetObject.GetComponent<Transform>();
            Debug.Log(target.position);
        }


        
       
    }


    public void OnMouseDown()
    {
        panelFindRoute.gameObject.SetActive(false);
        Debug.Log("Go button clicked");
    }



    



    


        void Awake()
    {
        grid = GetComponent<Grid>();
        
        
    }



    public void Update()
    {
        if (seeker != null && target != null)
        {
            FindPath(seeker.position, target.position);



        }

    }

    void FindPath(Vector3 startPos, Vector3 targetPos)
    {

        Node startNode = grid.NodeFromWorldPoint(startPos);
        
        Node targetNode = grid.NodeFromWorldPoint(targetPos);

        Heap<Node> openSet = new Heap<Node>(grid.MaxSize);
        HashSet<Node> closedSet = new HashSet<Node>();
        openSet.Add(startNode);

        while (openSet.Count > 0)
        {
            Node currentNode = openSet.RemoveFirst();
            closedSet.Add(currentNode);

            if (currentNode == targetNode)
            {
                RetracePath(startNode, targetNode);
                return;
            }

            foreach (Node neighbour in grid.GetNeighbours(currentNode))
            {
                if (!neighbour.walkable || closedSet.Contains(neighbour))
                {
                    continue;
                }

                int newMovementCostToNeighbour = currentNode.gCost + GetDistance(currentNode, neighbour);
                if (newMovementCostToNeighbour < neighbour.gCost || !openSet.Contains(neighbour))
                {
                    neighbour.gCost = newMovementCostToNeighbour;
                    neighbour.hCost = GetDistance(neighbour, targetNode);
                    neighbour.parent = currentNode;

                    if (!openSet.Contains(neighbour))
                        openSet.Add(neighbour);
                    else
                    {
                        //openSet.UpdateItem(neighbour);
                    }
                }
            }
        }
    }

    void RetracePath(Node startNode, Node endNode)
    {
        List<Node> path = new List<Node>();
        Node currentNode = endNode;

        while (currentNode != startNode)
        {
            path.Add(currentNode);
            currentNode = currentNode.parent;
        }
        path.Reverse();

        grid.path = path;

    }

    int GetDistance(Node nodeA, Node nodeB)
    {
        int dstX = Mathf.Abs(nodeA.gridX - nodeB.gridX);
        int dstY = Mathf.Abs(nodeA.gridY - nodeB.gridY);

        if (dstX > dstY)
            return 14 * dstY + 10 * (dstX - dstY);
        return 14 * dstX + 10 * (dstY - dstX);
    }


}