<Query Kind="Program" />

void Main()
{
	LinkedList<int> linkedList = CreateLinkedList();
	
	linkedList.PrintNodes();
}

public class Node<T>
{
	public T data;
	public Node<T> next;
	
	public Node(T data){
		this.data = data;
		this.next = null;
	}
}

public class LinkedList<T>
{
	public Node<T> head;
	public LinkedList(){
		head = null;
	}
	
	public void PrintNodes(){
		Node<T> runner = head;
		while(runner != null){
			Console.WriteLine(runner.data);
			runner = runner.next;
		}
	}

	public void AddNodeToFront(T data) {
		Node<T> newHeadNode = new Node<T>(data);
		newHeadNode.next = head;
		head = newHeadNode;
	}
	
	public void AddNodeToLast(T data){
		Node<T> lastNode = new Node<T>(data);
		if(head == null){
			head = lastNode;
		}
		else
		{
			Node<T> runner = head;
			while (runner.next != null)
			{
				runner = runner.next;
			}
			runner.next = lastNode;
		}
	}

	//This may not work as expected
	//public void AddNodeAfterParticularNode(Node prevNode, int newNodeData){
	//	if(prevNode == null){
	//		Console.WriteLine("Exception Handling here");
	//	}
	//	Node newNode = new Node(newNodeData);
	//	newNode.next = prevNode.next;
	//	prevNode.next = newNode;
	//}
}

public LinkedList<int> CreateLinkedList()
{
	LinkedList<int> linkedList = new LinkedList<int>();
	linkedList.AddNodeToFront(1);
	linkedList.AddNodeToFront(2);
	linkedList.AddNodeToFront(3);
	linkedList.AddNodeToLast(9);
	linkedList.AddNodeToFront(2);
	linkedList.AddNodeToFront(3);
	return linkedList;
}
