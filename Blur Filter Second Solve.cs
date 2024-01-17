int blurAmount = int.Parse(Console.ReadLine());
int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int matrixRows = matrixSize[0];
int matrixColumns = matrixSize[1];
var matrix = new long[matrixRows, matrixColumns];
for(int row = 0; row < matrixRows; row++)
{
    var matrixInput = Console.ReadLine().Split(' ').ToArray();
    for(int col = 0; col < matrixColumns; col++)
    {
        matrix[row, col] = long.Parse(matrixInput[col]);
    }
}
var blurCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
ChangeMatrix(matrix, blurCoordinates, blurAmount);

for (int i = 0; i < matrixRows; i++)
{
    for (int j = 0; j < matrixColumns; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

void ChangeMatrix(long[,] matrix, int[] blurCoordinates, int blurAmount)
{
    int blurRow = blurCoordinates[0];
    int blurColumn = blurCoordinates[1];
    matrix[blurRow, blurColumn] += blurAmount;
    if (blurRow - 1 >= 0)
    {
        matrix[blurRow - 1, blurColumn] += blurAmount;
    }
    if (blurRow + 1 < matrixRows)
    {
        matrix[blurRow + 1, blurColumn] += blurAmount;
    }
    if (blurColumn + 1 < matrixColumns)
    {
        matrix[blurRow, blurColumn + 1] += blurAmount;
    }
    if (blurColumn - 1 >= 0)
    {
        matrix[blurRow, blurColumn - 1] += blurAmount;
    }
    if (blurRow - 1 >= 0 && blurColumn - 1 >= 0)
    {
        matrix[blurRow - 1, blurColumn - 1] += blurAmount;
    }
    if (blurRow + 1 < matrixRows && blurColumn + 1 < matrixColumns)
    {
        matrix[blurRow + 1, blurColumn + 1] += blurAmount;
    }
    if (blurRow - 1 >= 0 && blurColumn + 1 < matrixColumns)
    {
        matrix[blurRow - 1, blurColumn + 1] += blurAmount;
    }
    if (blurRow + 1 < matrixRows && blurColumn - 1 >= 0)
    {
        matrix[blurRow + 1, blurColumn - 1] += blurAmount;
    }
}