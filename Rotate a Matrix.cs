var rows = int.Parse(Console.ReadLine());
var cols = int.Parse(Console.ReadLine());
var matrix = new string[rows, cols];
for (int row = 0; row < rows; row++)
{
    string line = Console.ReadLine();
    var items = line.Split(' ');
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = items[col];
    }
}
var resultCols = rows;
var resultRows = cols;
var result = new string[resultRows, resultCols];
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        result[col, resultCols - 1 - row] = matrix[row, col]; // SPinning changing row and col
    }
}
for (int row = 0; row < cols; row++)
{
    for (int col = 0; col < rows; col++)
    {
        Console.Write(result[row, col] + " ");
    }
    Console.WriteLine();
}