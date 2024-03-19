using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Edge 
{
    public Node startNade;
    public Node endNode;

    public Edge(Node from, Node to)
    {
        startNade = from;  
        endNode = to;
    }
}
