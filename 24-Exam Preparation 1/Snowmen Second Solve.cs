List<int> sequence = Console.ReadLine()
    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

while (sequence.Count != 1)
{
    for (int i = 0; i < sequence.Count; i++)
    {
        int attackerIndex = i;

        if (sequence[i].Equals(-1))
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

        if (sequence[looserIndex].Equals (-1) == false)
        {
            sequence[looserIndex] = -1;
        }

        if (sequence.Count == sequence.Where(m => m.Equals(-1)).Count() +1)
        {
            break;
        }

    }
    sequence = sequence.Where(m => m.Equals(-1) == false).ToList();
}