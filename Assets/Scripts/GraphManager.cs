using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GraphManager : MonoBehaviour
{

    [SerializeField]
    private Graph graph;
    [SerializeField]
    private int selectedVertex1, selectedVertex2;
    Vector3 position1, position2;

    public GameObject nodePrefab;
    public Transform nodeParent;
    public GameObject edgePrefab;
    public Transform edgeParent;

    // Start is called before the first frame update
    void Start()
    {
        selectedVertex1 = -1;
        selectedVertex2 = -1;
        graph = new Graph();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddVertex()
    {
        graph.AddVertex(graph.vertices.Count + 1);
        GameObject newNode = Instantiate(nodePrefab, nodeParent);
        newNode.GetComponent<Node>().SetID(graph.vertices.Count - 1);
    }

    public void SelectVertex(int vertexID, Vector3 position)
    {
        if (selectedVertex1 == -1)
        {
            selectedVertex1 = vertexID;
            position1 = position;
        }
        else
        {
            selectedVertex2 = vertexID;
            position2 = position;
            DrawEdge(selectedVertex1, selectedVertex2);
            selectedVertex1 = -1;
            selectedVertex2 = -1;
        }
    }

    public void DrawEdge(int vertex1, int vertex2)
    {
        graph.ConnectVertices(vertex1, vertex2);
        GameObject newEdge = Instantiate(edgePrefab, edgeParent);
        newEdge.GetComponent<LineRenderer>().SetPosition(0, position1);
        newEdge.GetComponent<LineRenderer>().SetPosition(1, position2);
    }
}
