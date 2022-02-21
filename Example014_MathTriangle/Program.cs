int row = 128;
int[,] triangle = new int[row, row];
const int cellWidth = 1;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = 
                triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
                Console.Write($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            //if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
            if (triangle[i, j] % 2!= 0) Console.WriteLine("*");
            col += cellWidth * 2;
        }

        col = cellWidth * row - cellWidth * (i + 1);

        Console.WriteLine();
    }
}

Console.ReadLine();
FillTriangle();
//PrintTriangle();
Console.ReadLine();
Magic();