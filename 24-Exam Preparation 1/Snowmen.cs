List<int> sequence = Console.ReadLine()
    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

while (sequence.Count != 1)
{
    List<int> snowmenToRemove = new List<int>();
    for (int i = 0; i < sequence.Count; i++)
    {
        int attackerIndex = i;

        if (snowmenToRemove.Contains(attackerIndex))
        {
            continue;
        }

        int targetIndex = sequence[i];

        if (targetIndex > sequence.Count)
        {
            targetIndex = targetIndex % sequence.Count;
        }
        int looserIndex = -1;


        if (attackerIndex == targetIndex)
        {
            looserIndex = attackerIndex;
            Console.WriteLine($"{attackerIndex} performed harakiri");
        }

        else
        {
            int difference = Math.Abs(attackerIndex - targetIndex);
            int winnerIndex = -1;
            if (difference % 2 == 0)
            {
                winnerIndex = attackerIndex;
                looserIndex = targetIndex;
            }
            else
            {
                winnerIndex = targetIndex;
                looserIndex = attackerIndex;
            }

            Console.WriteLine($"{attackerIndex} x {targetIndex} -> {winnerIndex} wins");
        }

        if (snowmenToRemove.Contains(looserIndex) == false)
        {
            snowmenToRemove.Add(looserIndex);
        }

        if (sequence.Count == snowmenToRemove.Count + 1)
        {
            break;
        }

    }
    sequence = ClearSnowmen(sequence, snowmenToRemove.OrderByDescending
        (s => s).ToList());
}

List<int> ClearSnowmen(List<int> sequence, List<int> snowmenToRemove)
{
    for (int i = 0; i < snowmenToRemove.Count; i++)
    {
        sequence.RemoveAt(snowmenToRemove[i]);
    }
    return sequence;
}