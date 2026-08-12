/*Write a C# program to implement a stack by using array with push and pop operations.*/

Stack stack = new Stack(10);
stack.Push(10);
stack.Push(20);
stack.Push(30);
Console.WriteLine();
stack.Display();
Console.WriteLine();

stack.Pop();    
stack.Pop();
Console.WriteLine();
stack.Display();
Console.WriteLine();

stack.Push(40);

Console.WriteLine();
stack.Display();
Console.WriteLine();

Console.WriteLine("Current stack:");
stack.Display();
Console.WriteLine();

Console.WriteLine("Peek at the top of the stack:");
Console.WriteLine(stack.Peak());
stack.Display();


public class Stack
{
    private int[] stackArray;
    private int top;
    private int maxSize;
    public Stack(int size)
    {
        maxSize = size;
        stackArray = new int[maxSize];
        top = -1;
    }
    public void Push(int value)
    {
        if (top >= maxSize - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        stackArray[++top] = value;
        Console.WriteLine($"Pushed {value} to stack.");
    }
    public int Pop()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack Underflow");
            return -1; 
        }
        Console.WriteLine($"Popped {stackArray[top]} from stack."); 
        return stackArray[top--];
    }

    public int Peak()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack is empty.");
            return -1; 
        }
        return stackArray[top];
    }

    public void Display()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }
        Console.WriteLine("Stack elements:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stackArray[i]);
        }
    }
}