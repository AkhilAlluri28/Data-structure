<Query Kind="Program" />

#load ".\LinkedListClass"


void Main()
{
	LinkedList<int> linkedList1 = CreateLinkedList();
	
	Console.WriteLine("---------Actual list----------");
	linkedList1.PrintNodes();
	
	RemoveDuplicatesWithNoBufferStorage(linkedList1.head);

	Console.WriteLine("---------Output with no buffer storage----------");
	linkedList1.PrintNodes();

	LinkedList<int> linkedList2 = CreateLinkedList();

	Console.WriteLine("---------Actual list----------");
	linkedList2.PrintNodes();

	RemoveDuplicatesWithNoBufferStorage(linkedList2.head);

	Console.WriteLine("---------Output with buffer storage----------");
	linkedList2.PrintNodes();
}

//Takes O(n^2)
public void RemoveDuplicatesWithNoBufferStorage(Node<int> head)
{
	Node<int> current = head;
	while (current != null)
	{
		Node<int> runner = current.next;
		Node<int> prev = current;
		while(runner != null){
			if(runner.data == current.data){
				prev.next = runner.next;
			}else{
				prev = runner;
			}
			runner = runner.next;
		}
		current = current.next;
	}
}

//Takes O(n)
public void RemoveDuplicatesWithBufferStorage(Node<int> head)
{
	HashSet<int> dataSet = new HashSet<int>();
	Node<int> runner = head; 
	Node<int> prev = null;
	while(runner != null){
		if(dataSet.Contains(runner.data)){
			prev.next = runner.next;
		}else{
			prev = runner;
		}
		dataSet.Add(runner.data);
		runner = runner.next;
	}
}
