int dnaLength = int.Parse(Console.ReadLine());
int bestLength = 0;
int bestSum = 0;
int bestStartingIndex = int.MaxValue;
int bestSampleIndex = 0;
int[] bestSequence = new int[dnaLength];
int sampleIndex = 0;

string sequence;
while ((sequence = Console.ReadLine()) != "Clone them!")
{
    sampleIndex++;

    int[] currentSequence = sequence
        .Split(new[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    int currentLength = 0;
    int maxCurrentLength = 0;
    int currentStartingIndex = 0;
    int currentSum = currentSequence.Sum();

    for (int i = 0; i < currentSequence.Length; i++)
    {
        if (currentSequence[i] == 1)
        {
            currentLength++;

            if (currentLength > maxCurrentLength)
            {
                maxCurrentLength = currentLength;
                currentStartingIndex = i - currentLength + 1;
            }
        }

        else
        {
            currentLength = 0;
        }
    }

    if (maxCurrentLength > bestLength ||
        (maxCurrentLength == bestLength && currentStartingIndex < bestStartingIndex) ||
        (maxCurrentLength == bestLength && currentStartingIndex == bestStartingIndex && currentSum > bestSum))
    {
        bestLength = maxCurrentLength;
        bestStartingIndex = currentStartingIndex;
        bestSum = currentSum;
        bestSequence = currentSequence;
        bestSampleIndex = sampleIndex;
    }
}

Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", bestSequence));
