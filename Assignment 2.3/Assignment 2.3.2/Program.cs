/*
 2. Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.
Use the format specifiers to display currency, % symbol.
 */
Console.WriteLine("Assignment 2.3.2");
TipApp tip = new TipApp();
tip.Run();


class TipApp
{
    public decimal billTotal { get; set; }
    public decimal tipPercentage { get; set; }
    public decimal tipAmount => billTotal * (tipPercentage / 100);
    public decimal total => billTotal + tipAmount;

    public void Run()
    {
        Console.WriteLine("Welcome to the Tip Calculator!");
        Console.Write("Please enter the bill total: ");
        billTotal = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Please enter the tip percentage (e.g., 15 for 15%): ");
        tipPercentage = Convert.ToDecimal(Console.ReadLine());
        tipPercentage /= 100;
        TipCalculator();
    }

    public void TipCalculator()
    {
        Console.WriteLine($"Tip Percentage: {tipPercentage:P2}");
        Console.WriteLine($"Tip Amount: {tipAmount:C}");
        Console.WriteLine($"Grand Total: {total:C}");
       
    }

}
