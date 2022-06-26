using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Node : MonoBehaviour
{
    private int vertexId;
    private GraphManager graphManager;

    private void Start()
    {
        graphManager = GameObject.Find("GraphManager").GetComponent<GraphManager>();
    }

    public void SetID(int ID)
    {
        vertexId = ID;
        GetComponentInChildren<TextMeshProUGUI>().SetText((vertexId + 1).ToString());
    }

    public void SelectNode()
    {
        graphManager.SelectVertex(vertexId, transform.position);
    }
}
