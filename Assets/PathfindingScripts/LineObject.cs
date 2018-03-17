using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineObject : MonoBehaviour {

    private LineRenderer lineRenderer;
    Grid grid;
    private bool flag = true ;
    private Vector3[] positionsOfPoints;

    // Use this for initialization
    private void Awake()
    {
        grid = GetComponent<Grid>();
        lineRenderer = GetComponent<LineRenderer>();
    }
    private void Update()
    {

        if (flag)
        {
            LineGenerator();
            flag = false;

        }
        
    }


    // Update is called once per frame
    void LineGenerator() {

        List <Vector3> tempLine = grid.GetLinePoints();

        foreach( Vector3 pec in tempLine)
        {
            Debug.Log(pec);
        }

        positionsOfPoints = tempLine.ToArray();

        Debug.Log(positionsOfPoints);

        lineRenderer.SetVertexCount(positionsOfPoints.Length);
        lineRenderer.SetPositions(positionsOfPoints);
       
    }
}
