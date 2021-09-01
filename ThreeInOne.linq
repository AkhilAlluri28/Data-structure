<Query Kind="Program" />

#load ".\MyStack"

void Main()
{
	int[] inputArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
	ThreeInOne(inputArray);
}

public void ThreeInOne(int[] inputArray){
	int oneThird = inputArray.Length/3;
	int remaining = inputArray.Length%3;
	
	int[] array1 = inputArray.Take(oneThird).ToArray();
	int[] array2 = inputArray.Skip(oneThird).Take(oneThird).ToArray();
	int[] array3 = inputArray.Skip(oneThird+oneThird).Take(oneThird+remaining).ToArray();

	MyStack<int> stack1 = new MyStack<int>();
	MyStack<int> stack2 = new MyStack<int>();
	MyStack<int> stack3 = new MyStack<int>();

	AddNodesFromArray(array1, stack1);
	AddNodesFromArray(array2, stack2);
	AddNodesFromArray(array3, stack3);
}

public void AddNodesFromArray(int[] array, MyStack<int> stack)
{
	foreach (int val in array)
	{
		var stackNode = new StackNode<int>(val);
		if (stack.top == null)
		{
			stack.top = stackNode;
		}
		else
		{
			stackNode.next = stack.top;
			stack.top = stackNode;
		}
	}
	PrintStack(stack);
}

public void PrintStack(MyStack<int> inputStack)
{
	Console.WriteLine("------Stack starts here------");
	var runner = inputStack.top;
	while(runner != null){
		Console.WriteLine(runner.data);
		runner = runner.next;
	}
}


