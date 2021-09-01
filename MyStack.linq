<Query Kind="Program" />

public class StackNode<T>
{
	public T data;
	public StackNode<T> next;

	public StackNode(T data)
	{
		this.data = data;
	}
}

public class MyStack<TIn>
{
	public StackNode<TIn> top;
	
	public void AddNode(TIn data){
		StackNode<TIn> node = new StackNode<TIn>(data);
		if(top == null){
			top = node;
			return;
		}
		node.next = top;
	}
	public TIn Pop(){
		if(top == null) throw new Exception();
		
		TIn topNodeData = top.data;
		top = top.next;
		return topNodeData;
	}
	
	public TIn Peek(){
		if(top == null) throw new Exception();
		
		return top.data;
	}
	
	public void Push(TIn data){
		var stackNode = new StackNode<TIn>(data);
		
		if(top == null){
			top = stackNode;
			return;
		}
		stackNode.next = top;
	}
	
	public bool isEmpty(){
		return top == null;
	}
}