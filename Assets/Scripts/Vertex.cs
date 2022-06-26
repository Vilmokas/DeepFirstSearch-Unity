using System.Collections.Generic;

[System.Serializable]
public class Vertex
{
    public int value;
    public List<int> edges;

    public Vertex(int v)
    {
        value = v;
        edges = new List<int>();
    }

    public void ConnectVertex(int neighborId)
    {
        edges.Add(neighborId);
    }
}
