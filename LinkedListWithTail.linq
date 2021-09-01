<Query Kind="Program" />

void Main()
{
	LinkedList<int> linkedList = new LinkedList<int>();
	linkedList.AddNodeToFront(1);
	linkedList.AddNodeToFront(11);
	linkedList.AddNodeToFront(3);
	linkedList.AddNodeToLast(9);
	
	Node<int> lastNode = new Node<int>(9);
	//linkedList.AddNodeAfterParticularNode(lastNode, 77);
	
	linkedList.PrintNodes();
}

public class Node<T>
{
	public T data;
	public Node<T> next;

	public Node(T data)
	{
		this.data = data;
		this.next = null;
	}
}

public class LinkedList<T>
{
	Node<T> head;
	Node<T> tail;
	public LinkedList()
	{
		head = null;
		tail = null;
	}

	public void PrintNodes()
	{
		Node<T> runner = head;
		while (runner != null)
		{
			Console.WriteLine(runner.data);
			runner = runner.next;
		}
	}

	public void AddNodeToFront(T data)
	{
		Node<T> newHeadNode = new Node<T>(data);
		if(head == null){
			tail = newHeadNode;
		}
		else {
			newHeadNode.next = head;
		}
		head = newHeadNode;
	}

	public void AddNodeToLast(T data)
	{
		Node<T> lastNode = new Node<T>(data);
		if (head == null)
		{
			head = lastNode;
		}
		else
		{
			tail.next = lastNode;  //Adding to end of linked list reduced from O(n) to O(1) using tail
		}
		tail = lastNode;
	}

	//public void AddNodeAfterParticularNode(Node<T> prevNode, T data)
	//{
	//	//if (prevNode == null)
	//	//{
	//	//	Console.WriteLine("Exception Handling here");
	//	//}
	//	if(head == null){
	//		Console.WriteLine("Head cannot be null");
	//	}
	//	Node<T> newNode = new Node<T>(data);
	//	Node<T> runner = head;
	//	while(runner.next != null){
	//		if(runner == prevNode){
	//			newNode.next = runner.next;
	//			runner.next = newNode;
	//		}
	//		runner = runner.next;
	//	}
	//	newNode.next = runner.next;
	//	runner.next = newNode;
	//	if (newNode.next == null)
	//	{
	//		tail = newNode;
	//	}
	//	Console.WriteLine("tail data is---" + tail.data);
	//}
}
