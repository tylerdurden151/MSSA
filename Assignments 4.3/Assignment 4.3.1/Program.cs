/*

 Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. 
The charge are as follows: (you may change the charge sheet values)

example:
If bill exceeds $ 400 then a surcharge of 15% will be charged.

Test Data :
1001
James
800
Expected Output :
Customer IDNO :1001
Customer Name :James
unit Consumed :800
Amount Charges @$ 2.00 per unit : 1600.00
Surcharge Amount : 240.00
Net Amount Paid By the Customer : 1840.00
 */

Console.WriteLine("Assignment 4.3.1 - Electricity Bill Calculation");
ElectricityBill e = new ElectricityBill();
e.Run();

class ElectricityBill
{
    const decimal rate1 = 1.20m;
    const decimal rate2 = 1.50m;
    const decimal rate3 = 1.80m;
    const decimal rate4 = 2.00m;
    const decimal surchargeRate = 0.15m;
    const decimal maxTier1 = 199 * rate1;
    const decimal maxTier2 = 200 * rate2;
    const decimal maxTier3 = 200 * rate3;       

    private decimal _unitsConsumed;
    private int _customerId;
    private string _customerName = string.Empty;
    public string CustomerName
    {
        get { return _customerName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Customer name cannot be empty.");
            }
            if (value.Length > 100)
            {
                throw new ArgumentException("Customer name cannot exceed 100 characters.");
            }
            _customerName = value.Trim();   // optional: normalize stray whitespace
        }
    }
    public int CustomerId
    {
        get { return _customerId; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Customer ID cannot be negative.");
            }
            _customerId = value;
        }
    }

    public decimal UnitsConsumed
    {
        get { return _unitsConsumed; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Units consumed cannot be negative.");
            }
            _unitsConsumed = value;
        }
    }
    public decimal AmountCharges { get; set; }
    public decimal SurchargeAmount { get; set; }
    public decimal NetAmountPaid {  get; set; }


    public void Run()
    {
        Console.Write("Enter Customer ID: ");
        CustomerId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Customer Name: ");
        CustomerName = Console.ReadLine();
        Console.Write("Enter Units Consumed: ");
        UnitsConsumed = Convert.ToDecimal(Console.ReadLine());
        CalculateBill();

    }

    public void CalculateBill()
    {
        if (UnitsConsumed <= 199)
        {
            AmountCharges = UnitsConsumed * rate1;
        }
        else if (UnitsConsumed <= 399)
        {
            AmountCharges = (UnitsConsumed - 199) * rate2 + maxTier1;
        }
        else if (UnitsConsumed <= 599)
        {
            AmountCharges = (UnitsConsumed - 399) * rate3 + maxTier1 + maxTier2;
        }
        else
        {
            AmountCharges = (UnitsConsumed - 599) * rate4 + maxTier1 + maxTier2 + maxTier3;
        }


        if (AmountCharges > 400)
        {
            SurchargeAmount = AmountCharges * surchargeRate;
        }
        else
        {
            SurchargeAmount = 0;
        }

        NetAmountPaid = AmountCharges + SurchargeAmount;
        DisplayBill();
    }

    public void DisplayBill()
    {
        Console.WriteLine($"Customer IDNO :{CustomerId}");
        Console.WriteLine($"Customer Name :{CustomerName}");
        Console.WriteLine($"Unit Consumed :{UnitsConsumed}");
        Console.WriteLine($"Amount Charges @$ per unit : {AmountCharges:F2}");
        Console.WriteLine($"Surcharge Amount : {SurchargeAmount:F2}");
        Console.WriteLine($"Net Amount Paid By the Customer : {NetAmountPaid:F2}");
    }
}