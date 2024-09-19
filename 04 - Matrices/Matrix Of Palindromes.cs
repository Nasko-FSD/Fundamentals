var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int matrixRows = numbers[0];
int matrixColumns = numbers[1];
var matrix = new string[matrixRows, matrixColumns];
for (int row = 0; row < matrixRows; row++)
{
    for (int column = 0; column < matrixColumns; column++)
    {
        matrix[row, column] = "" + (char)('a' + row) + (char)('a' + row + column) + (char)('a' + row);
    }
}
for (int row = 0; row < matrixRows; row++)
{
    for (int column = 0; column < matrixColumns; column++)
    {
        Console.Write(matrix[row, column] + " ");
    }
    Console.WriteLine();
}