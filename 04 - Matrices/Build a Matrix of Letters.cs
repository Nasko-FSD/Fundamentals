var rows = int.Parse(Console.ReadLine());
var cols = int.Parse(Console.ReadLine());
var matrix = new char[rows, cols];
char letter = 'A';
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = letter;
        letter++;
        if (letter > 'Z')
            letter = 'A';
    }
}
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}