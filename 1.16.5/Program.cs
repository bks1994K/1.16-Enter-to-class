
int SumOfTheNumbersInsideAAndBThatAreDivisibleBySeven(int a, int b)
{
        int result = 0;
    for (int i = a; i <= b; i++)
    {
        if (i % 7 == 0)
        {
            result = result + i;
        }

    }
    return result;
}
    int sum = SumOfTheNumbersInsideAAndBThatAreDivisibleBySeven(5,15);
    Console.WriteLine(sum);