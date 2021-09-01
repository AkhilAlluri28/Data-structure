<Query Kind="Program" />

#load ".\LinkedListClass"

void Main()
{
	var linkedList = CreateLinkedList();
	Console.WriteLine("------Actual List-----");
	linkedList.PrintNodes();

	Partition(3, linkedList.head);
	Console.WriteLine("------After partition-----");
	linkedList.PrintNodes();
}

//Not right
public void Partition(int comparedValue, Node<int> head){
	LinkedList<int> linkedList1 = new LinkedList<int>();
	LinkedList<int> linkedList2 = new LinkedList<int>();
	 Node<int> current = head;
	while(current != null){
		if(current.data >= comparedValue){
			linkedList2.AddNodeToLast(current.data);
		}
		else{
			linkedList1.AddNodeToLast(current.data);
		}
		current = current.next;
	}
}
