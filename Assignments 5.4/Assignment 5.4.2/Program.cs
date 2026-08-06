/*Write a C# Sharp program to find the sum of the right diagonals of a matrix.
Test Data :
Input the size of the square matrix : 2
Input elements in the first matrix :
element - [0],[0] : 1
element - [0],[1] : 2
element - [1],[0] : 3
element - [1],[1] : 4
Expected Output :
The matrix is :
1 2
3 4
Addition of the right Diagonal elements is :5
*/
Solution s = new Solution();
s.RunMenu();

public class Solution
{
    public int Number { get; set; }
    public void RunMenu()
    {

        Console.WriteLine("Input the size of the square matrix (less than 5): ");
        // TryParse for int
        if (int.TryParse(Console.ReadLine(), out int size))
        {
            Number = size;
        }
        else
        {
            Console.WriteLine("That wasn't a valid number.");
        }

        Console.WriteLine("Input elements in the first matrix :");
        int[,] first = ReadMatrix(Number);

        Console.WriteLine("The matrix is : ");
        DisplayMatrix(first);
        DisplayRightDiagonalAddition(first);
    }

    //Gets values Matrix Values from user
    private int[,] ReadMatrix(int size)
    {
        int[,] matrix = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int val;
                while (true)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    if (int.TryParse(Console.ReadLine(), out val))
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a whole number.");
                }
                matrix[i, j] = val;
            }
        }
        return matrix;
    }

  

    //Displays the matrix in a formatted way
    private void DisplayMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        // find the widest number across all cells
        int width = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int len = matrix[i, j].ToString().Length;
                if (len > width)
                {
                    width = len;
                }
            }
        }
        //Display matrix
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(width) + " ");
            }
            Console.WriteLine();
        }
    }
    private void DisplayRightDiagonalAddition(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, size - 1 - i];
        }
        Console.WriteLine($"The addition of the right diagonal is: {sum}");
    }
}