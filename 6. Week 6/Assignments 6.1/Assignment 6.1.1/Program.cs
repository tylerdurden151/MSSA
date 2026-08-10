/*1. Implement a single linked list with each node representing a house. You may add data in it like house number, brief address, type of house ( like Ranch, Colonial). 
 *
 * Each house (node) will be linked to next.
 * Give facility to the user to search a house by its number and then display the details. ( Windows / Console)*/

LinkedListNode homes = new LinkedListNode(new Home { HomeId = 1, Address = "123 Main St"});
homes.AddNode(new LinkedListNode(new Home { HomeId = 2, Address = "456 Oak Ave"}));
homes.AddNode(new LinkedListNode(new Home { HomeId = 3, Address = "789 Pine Rd"}));

Console.Write("Enter a house number to search: ");
int searchId = int.Parse(Console.ReadLine());
homes.SearchNode(searchId); 
Console.WriteLine();


public class LinkedListNode
{
    public Home Value { get; set; }
    public LinkedListNode? Next { get; set; }

    public LinkedListNode(Home value)
    {
        Value = value;
    }

    public void AddNode(LinkedListNode newNode) //Wrap the new node to the end of the linked list
    {
        LinkedListNode? current = this;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public void SearchNode(int homeId)
    {
        LinkedListNode? current = this;
        while (current != null)
        {
            if (current.Value.HomeId == homeId)
            {
                PrintNode(current);
                return;
            }
            current = current.Next;
        }
        Console.WriteLine($"HomeId: {homeId} not found.");
    }

    public void PrintNode(LinkedListNode node)
    {
        Console.WriteLine($"HomeId: {node.Value.HomeId}, Address: {node.Value.Address}");
    }
}


public class Home
{   
    private string _address = string.Empty;
    public int HomeId { get; set; }
    public string Address { 
        get { return _address; } set { 
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Address cannot be empty");
            }
            _address = value; } 
    } 
}
