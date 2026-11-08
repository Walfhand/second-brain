namespace SecondBrain.Demo;

public static class Calculator
{
    public static int SumPositive(ReadOnlySpan<int> values)
    {
        int total = 0;

        foreach (int value in values)
        {
            if (value > 0)
            {
                total += value;
            }
        }

        return total;
    }
}
