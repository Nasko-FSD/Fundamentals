Console.Write("Enter the amount of rows for the matrix: ");
var rowsMatrix = int.Parse(Console.ReadLine());
Console.Write("Enter the amount of columns for the matrix: ");
var columnsMatrix = int.Parse(Console.ReadLine());
var matrix = new int[rowsMatrix, columnsMatrix];
for (int row = 0; row < rowsMatrix; row++)
{
    Console.Write("Enter the cells index for the matrix for each row followed by 'Enter': ");
    var cells = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int column = 0; column < columnsMatrix; column++)
    {
        matrix[row, column] = cells[row];
        matrix[row, column] = cells[column];
    }
}
Console.WriteLine("The Matrix is: ");
for (int row = 0; row < rowsMatrix; row++)
{
    for (int column = 0; column < columnsMatrix; column++)
    {
        Console.Write(matrix[row, column] + " ");
    }
    Console.WriteLine();
}