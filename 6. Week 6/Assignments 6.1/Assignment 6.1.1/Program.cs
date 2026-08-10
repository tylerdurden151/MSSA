/**/

LinkedListNode home1 = new LinkedListNode(new Home { HomeId = 1, Address = "123 Main St" });
LinkedListNode home2 = new LinkedListNode(new Home { HomeId = 2, Address = "456 Oak Ave" });
LinkedListNode home3 = new LinkedListNode(new Home { HomeId = 3, Address = "789 Pine Rd" });
home1.PrintNode();
home2.PrintNode();
home3.PrintNode();

public class LinkedListNode
{
    public Home Value { get; set; }
    public LinkedListNode? Next { get; set; }
    public LinkedListNode(Home value)
    {
        Value = value;
    }
    
    public void PrintNode()
    {
        Console.WriteLine($"HomeId: {Value.HomeId}, Address: {Value.Address}");
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
