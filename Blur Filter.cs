int blurAmount = int.Parse(Console.ReadLine());
int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int rows = dimentions[0];
int cols = dimentions[1];
var matrix = new long[rows, cols];
for (int row = 0; row < rows; row++)
{
    int[] columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = columns[col];
    }
}
int[] coordinatesToBlur = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int rowsToBlur = coordinatesToBlur[0];
int colsToBlur = coordinatesToBlur[1];

int startRow = Math.Max(0, rowsToBlur - 1);
int endRow = Math.Min(rows - 1, rowsToBlur + 1);
int startCol = Math.Max(0, colsToBlur - 1);
int endCol = Math.Min(cols - 1, colsToBlur + 1);
for (int row = startRow; row <= endRow; row++)
{
    for (int col = startCol; col <= endCol; col++)
    {
        matrix[row, col] += blurAmount;
    }
}
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write("{0} ", matrix[row, col]);
    }
    Console.WriteLine();
}