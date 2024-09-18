var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var solutions = new int[numbers.Count];
var prevSolutions = new int[numbers.Count];
var maxSolution = 0;
var maxSolutionIndex = 0;
for (int current = 0; current < numbers.Count; current++)
{
    var solution = 1;
    var prevIndex = -1;
    var currenNumber = numbers[current];
    for (int solIndex = 0; solIndex < current; solIndex++)
    {
        var prevNumber = numbers[solIndex];
        var prevSolution = solutions[solIndex];
        if (currenNumber > prevNumber
            && solution <= prevSolution)
        {
            solution = prevSolution + 1;
            prevIndex = solIndex;
        }
    }
    solutions[current] = solution;
    prevSolutions[current] = prevIndex;
    if(solution > maxSolution)
    {
        maxSolution = solution;
        maxSolutionIndex = current;
    }
}
Console.WriteLine(maxSolution);
var index = maxSolutionIndex;
var result = new List<int>();
while(index != -1)
{
    var currentNumber = numbers[index];
    result.Add(currentNumber);
    index = prevSolutions[index];
}
result.Reverse();
Console.WriteLine(string.Join(" ", result));