public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var answer = new List<(int a, int b, int c)>();

        for (int num1 = 1; num1 < (sum / 3); num1++)
        {
            int numerator = (int)Math.Pow(sum, 2) - 2 * sum * num1;
            int denominator = 2 * sum - 2 * num1;
            if (numerator % denominator is 0)
            {
                int num2 = numerator / denominator;
                int num3 = sum - num1 - num2;
    
                if (num1 < num2)
                {
                    answer.Add((num1, num2, num3));
                }
            }
        }

        return answer;
    }
}