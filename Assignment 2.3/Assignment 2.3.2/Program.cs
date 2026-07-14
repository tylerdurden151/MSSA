/*
 2. Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.
Use the format specifiers to display currency, % symbol.
 */
Console.WriteLine("Assignment 2.3.2");
TipApp tip = new TipApp();
tip.Run();


class TipApp
{
    private decimal _billTotal;
    private decimal _tipPercentage;
    public decimal BillTotal
    {
        get { return _billTotal; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Bill total cannot be negative.");
            }
            _billTotal = value;
        }
    }
    public decimal TipPercentage
    {
        get { return _tipPercentage; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Tip percentage cannot be negative.");
            }
            _tipPercentage = value;
        }
    }


    public decimal tipAmount => BillTotal * TipPercentage;
    public decimal total => BillTotal + tipAmount;

    public void Run()
    {
        Console.WriteLine("Welcome to the Tip Calculator!");
        Console.Write("Please enter the bill total: ");
        BillTotal = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Please enter the tip percentage (e.g., 15 for 15%): ");
        TipPercentage = Convert.ToDecimal(Console.ReadLine());
        TipPercentage /= 100;
        TipCalculator();
    }

    public void TipCalculator()
    {
        Console.WriteLine($"Tip Percentage: {TipPercentage:P2}");
        Console.WriteLine($"Tip Amount: {tipAmount:C}");
        Console.WriteLine($"Grand Total: {total:C}");

    }

}

