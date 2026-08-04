Solution s = new Solution();
s.Num(10); // Output: 10 9 8 7 6 5 4 3 2 1

public class Solution
{
    public void Num(int num)
    {

        if (num <= 0)
        {
            return;
        }
        Console.Write(num + " ");
        Num(num - 1);

    }
}