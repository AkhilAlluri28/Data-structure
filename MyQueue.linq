<Query Kind="Program" />

void Main()
{
	
}

public class QueueNode<T>
{
	public T data;
	public QueueNode<T> next;

	public QueueNode(T data)
	{
		this.data = data;
	}
}

public class MyQueue<T>{
	public QueueNode<T> front; 
	
	public void AddNode(T data){
		 
		QueueNode<T> dataNode = new QueueNode<T>(data);
		if(front == null){
			front = dataNode;
		}
		var runner = front;
		while(runner != null){
			if(runner.next == null){
				runner.next = dataNode;
			}
			else
			{
				runner = runner.next;
			}
		}
	}
	
	public T GetFirst(){
		T firstNodeData = front.data;
		front = front.next;
		return firstNodeData;
	}
}