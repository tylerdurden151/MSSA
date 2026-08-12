/*
 You are developing a program to manage a call queue of customers using the Queue  in C#. 
The program creates a queue of callers and demonstrates the functionality of enqueueing elements 
into the queue and iterating over the elements and dequeuing. Add a peek method to the queue class that allows you to 
view the next caller in line without removing them from the queue.

Use linked lists.
 
 */

Queue callQueue = new Queue();
callQueue.Enqueue("Caller 1");
callQueue.Enqueue("Caller 2");
callQueue.Enqueue("Caller 3");
callQueue.Enqueue("Caller 4");

//Next caller in line
Console.WriteLine("Next caller in line: " + callQueue.Peek());
Console.WriteLine();
//Show the queue
Console.WriteLine("Current queue:");
callQueue.PrintQueue();

Console.WriteLine();
callQueue.Dequeue();
callQueue.Dequeue();

Console.WriteLine("Current queue:");
callQueue.PrintQueue();




public class Queue
{
    private LinkedList<string> callers;

    public Queue()
    {
        callers = new LinkedList<string>();
    }

    public void Enqueue(string caller)
    {
        callers.AddLast(caller);
    }

    public string Dequeue()
    {
        if (callers.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        var caller = callers.First.Value;
        callers.RemoveFirst();
        return caller;
    }

    public string Peek()
    {
        if (callers.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return callers.First.Value;
    }

    public void PrintQueue()
    {
        foreach (var caller in callers)
        {
            Console.WriteLine(caller);
        }
    }
}




