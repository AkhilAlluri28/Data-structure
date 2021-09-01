<Query Kind="Program" />

#load ".\LinkedListClass"

void Main()
{
	LinkedList<int> linkedList = CreateLinkedList();
	linkedList.PrintNodes();
	
	Console.WriteLine("---kth element----");
	Node<int> kthFromLast = ReturnKthToLast(linkedList.head, 3);
	Console.WriteLine(kthFromLast.data);
}

public Node<int> ReturnKthToLast(Node<int> head, int k){
	//return k node from end(ex: 3rd node from end)
	Node<int> p1 = head;
	Node<int> p2 = head;
	
	for(int i=0; i<k; i++){
		if(p1.next ==null) return null; //K should not be greater than linked list length 
		p1 = p1.next;
	}
	
	while(p1 != null){
		p1 = p1.next;
		p2 = p2.next;
	}
	return p2;
}