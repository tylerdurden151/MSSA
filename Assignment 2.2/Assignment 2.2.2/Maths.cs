public static class Maths
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static decimal Add(decimal num1, decimal num2, decimal num3)
    {
        return num1 + num2 + num3;
    }

    public static float Multiply(float num1, float num2)
    {
        return num1 * num2;
    }

    public static float Multiply(float num1, float num2, float num3)
    {
        // 3-arg overload reuses the 2-arg overload instead of duplicating the logic
        return Multiply(num1, num2) * num3;
    }
}
