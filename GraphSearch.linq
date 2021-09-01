<Query Kind="Program" />

void Main()
{

}

public class GraphNode{
	public int id;
	public GraphNode[] children;
}

public class Graph{
	public GraphNode[] nodes;
}

public bool BreadthFirstSearch(GraphNode root, int inputId){
	Queue<GraphNode> toBeVisited = new Queue<GraphNode>();
	HashSet<GraphNode> visited = new HashSet<GraphNode>();
	toBeVisited.Enqueue(root);
	
	while(toBeVisited.Count > 0){
		GraphNode currentNode = toBeVisited.Dequeue();
		if(currentNode.id == inputId)
	}
	
}
