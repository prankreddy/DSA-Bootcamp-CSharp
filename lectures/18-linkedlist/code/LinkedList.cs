// Simple Linked List
public class Node
{
    public int Data;
    public Node? Next;
    public Node(int data) => Data = data;
}

public class LinkedList
{
    public Node? Head;

    public void Add(int data)
    {
        var newNode = new Node(data);
        if (Head == null) { Head = newNode; return; }
        var temp = Head;
        while (temp.Next != null) temp = temp.Next;
        temp.Next = newNode;
    }

    public void Display()
    {
        var temp = Head;
        while (temp != null)
        {
            Console.Write($"{temp.Data} -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}

var list = new LinkedList();
list.Add(10);
list.Add(20);
list.Add(30);
list.Display();