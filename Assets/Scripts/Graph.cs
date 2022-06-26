using System.Collections.Generic;

[System.Serializable]
public class Graph
{
    public List<Vertex> vertices;

    public Graph()
    {
        vertices = new List<Vertex>();
    }

    public void AddVertex(int value)
    {
        vertices.Add(new Vertex(value));
    }

    public void ConnectVertices(int vertex1, int vertex2)
    {
        vertices[vertex1].ConnectVertex(vertex2);
        vertices[vertex2].ConnectVertex(vertex1);
    }
}
