// Stack and Queue using built-in collections

var stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine($"Pop: {stack.Pop()}"); // 3

var queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
Console.WriteLine($"Dequeue: {queue.Dequeue()}"); // 1

// Min Stack concept (simple version)
Console.WriteLine($"Stack count: {stack.Count}");