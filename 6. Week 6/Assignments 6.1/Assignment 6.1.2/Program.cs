/*Then Assignment 6.1.2 redo above using built-in class
 */

PrintHomes homes = new PrintHomes();
homes.homeslist.AddLast(new Home { HomeId = 1, Address = "123 Main St" });
homes.homeslist.AddLast(new Home { HomeId = 2, Address = "456 Oak Ave" });
homes.homeslist.AddLast(new Home { HomeId = 3, Address = "789 Pine Rd" });

Console.Write("Enter a house number to search: ");
int searchId = int.Parse(Console.ReadLine());
homes.SearchNode(searchId);
Console.WriteLine();



public class PrintHomes
{
   public LinkedList<Home> homeslist = new LinkedList<Home>();

    public void SearchNode(int homeId)
    {
        LinkedListNode<Home>? current = homeslist.First;
        while (current != null)
        {
            if (current.Value.HomeId == homeId)
            {
                PrintNode(current.Value);
                return;
            }
            current = current.Next;
        }
        Console.WriteLine($"HomeId: {homeId} not found.");
    }

    public void PrintNode(Home home)
    {
        Console.WriteLine($"HomeId: {home.HomeId}, Address: {home.Address}");
    }

}



public class Home
{
    private string _address = string.Empty;
    public int HomeId { get; set; }
    public string Address
    {
        get { return _address; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Address cannot be empty");
            }
            _address = value;
        }
    }
}