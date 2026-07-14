/*
 * Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
Temp 0< 10 then Freezing weather
Temp 11-20 then Very Cold weather
Temp 21-35 then Cold weather
Temp 36-50 then Normal in Weather
Temp 51-65 then Its Hot
Temp 66-80 then Its Very Hot
Test Data :
67
Expected Output :
Its very hot.
 */

TempApp temp = new TempApp();
temp.Run();

class TempApp
{
    private int _temperature;
    public int Temperature
    {
        get { return _temperature; }
        set
        {
            if (value < -459)
            {
                throw new ArgumentException("Temperature cannot be below absolute zero.");
            }
            _temperature = value;
        }
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Temperature App!");
        Console.Write("Please enter the temperature in Fahrenheit: ");
        Temperature = Convert.ToInt32(Console.ReadLine());
        TempMessage(Temperature);
    }

    public void TempMessage(int temp)
    {
        switch (temp)
        {
            case >= 0 and < 11:
                Console.WriteLine($"{temp}°F is Freezing weather");
                break;
            case >= 11 and <= 20:
                Console.WriteLine($"{temp}°F is Very Cold weather");
                break;
            case >= 21 and <= 35:
                Console.WriteLine($"{temp}°F is Cold weather");
                break;
            case >= 36 and <= 50:
                Console.WriteLine($"{temp}°F is Normal in Weather");
                break;
            case >= 51 and <= 65:
                Console.WriteLine($"{temp}°F is Its Hot");
                break;
            case >= 66 and <= 80:
                Console.WriteLine($"{temp}°F is Its Very Hot");
                break;
            default:
                Console.WriteLine("Temperature range is either extremely hot or extremely cold.");
                break;
        }
    }
}