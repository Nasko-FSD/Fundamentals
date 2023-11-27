var matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var matrixRows = matrixSize[0];
var matrixColumns = matrixSize[1];
var matrix = new char[matrixRows, matrixColumns];
var counter = 0;
for (int row = 0; row < matrixRows; row++)
{
    char[] rowInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < matrixColumns; col++)
    {
        matrix[row, col] = rowInput[col];
    }
}
for (int i = 0; i < matrixRows - 1; i++)
{
    for (int j = 0; j < matrixColumns - 1; j++)
    { 
        if (matrix[i, j] == matrix[i, j + 1] &&
            matrix[i, j] == matrix[i + 1, j + 1] &&
            matrix[i, j] == matrix[i + 1, j])
        {
            counter++;
        }
    }
}
Console.WriteLine(counter);
