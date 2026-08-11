/*Write a C# program to implement a stack by using array with push and pop operations.*/

Stack stack = new Stack(10);
stack.Push(10);
stack.Push(20);
stack.Push(30);
stack.Display();
stack.Pop();    
stack.Pop();
stack.Push(40);
stack.Display();
stack.Peak();
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
            return -1; // Return -1 to indicate stack is empty
        }
        return stackArray[top--];
    }

    public int Peak()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack is empty.");
            return -1; // Return -1 to indicate stack is empty
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