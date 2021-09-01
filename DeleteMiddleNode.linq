<Query Kind="Program" />

#load ".\LinkedListClass"

void Main()
{
	var linkedList = CreateLinkedList();
	Console.WriteLine("------Actual List-----");
	linkedList.PrintNodes();

	DeleteMiddleNode(linkedList.head);
	Console.WriteLine("------After delete-----");
	linkedList.PrintNodes();
}

public void DeleteMiddleNode(Node<int> head){
	int count = GetNodesCount(head);
	if(count<=2) return;
	
	int div = count/2;
	int rem = count%2;
	
	int targetNodePosition = div + rem;
	int currentPosition =  0;
	
	Node<int> prev = null;
	Node<int> current = head;
	
	while(current != null){
		currentPosition++;
		if(currentPosition == targetNodePosition){
			prev.next = current.next;
		}
		prev = current;
		current = current.next;
	}
}

public int GetNodesCount(Node<int> head){
	int count = 0;
	Node<int> runner = head;
	while(runner != null){
		count++;
		runner = runner.next;
	}
	return count;
}
