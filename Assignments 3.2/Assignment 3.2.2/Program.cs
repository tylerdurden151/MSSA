/*
 2. Write a program in C# Sharp for addition of two Matrices of same size.

Test Data :

Input the size of the square matrix (less than 5): 2

Input elements in the first matrix :

element - [0],[0] : 1

element - [0],[1] : 2

element - [1],[0] : 3

element - [1],[1] : 4

Input elements in the second matrix :

element - [0],[0] : 5

element - [0],[1] : 6

element - [1],[0] : 7

element - [1],[1] : 8

Expected Output:

The First matrix is:

1 2

3 4

The Second matrix is :

5 6

7 8

The Addition of two matrix is :

6 8

10 12
 
 */
MatrixAddition m = new MatrixAddition();
m.RunMenu();


public class MatrixAddition
{
    private int _numberSize;
    public int Number { get { return _numberSize; } set { _numberSize = value; } }

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

        Console.WriteLine("Input elements in the second matrix :");
        int[,] second = ReadMatrix(Number);

        Console.WriteLine("The Addition of two matrix is : ");
        int[,] result = CalculateMatrix(first, second);
        DisplayMatrix(result);


    }

    private int[,] ReadMatrix(int size)
    {
        int[,] matrix = new int[size, size];

        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                int val;
                while (true)
                {
                    Console.Write($"element - [{r}],[{c}] : ");
                    if (int.TryParse(Console.ReadLine(), out val))
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a whole number.");
                }
                matrix[r, c] = val;
            }
        }
        return matrix;
    }

    public int[,] CalculateMatrix(int[,] first, int[,] second)
    {
        int size = first.GetLength(0);
        int[,] result = new int[size, size];

        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                result[r, c] = first[r, c] + second[r, c];
            }
        }
        return result;

    }

    private void DisplayMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        // find the widest number across all cells
        int width = 0;
        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                int len = matrix[r, c].ToString().Length;
                if (len > width)
                {
                    width = len;
                }
            }
        }
        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                Console.Write(matrix[r, c].ToString().PadLeft(width) + " ");
            }
            Console.WriteLine();
        }
    }
}
