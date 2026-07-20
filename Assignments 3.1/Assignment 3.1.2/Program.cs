/*
 2. If year is leap

Given a year as integer, write a method that checks if year is leap.

Expected input and output

IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false
 
 */

LeapYear year1 = new LeapYear();
bool result = year1.IfYearIsLeap(2016);
Console.WriteLine(result);

LeapYear year2 = new LeapYear();
bool result2 = year2.IfYearIsLeap(2018);
Console.WriteLine(result2);


class LeapYear {

    private int _year;
    public int Year { get { return _year; } set { _year = value; } }

    public bool IfYearIsLeap(int year) {
        Year = year;
        if (Year % 400 == 0)
        {
            return true;
        }
        else if (Year % 100 == 0)
        {
            return false;
        }
        else if (Year % 4 == 0)
        {
            return true;
        }
        return false; 
    }

}