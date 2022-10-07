using System.Diagnostics;

int ReturnsNumberFromFibonacciSeries(int number)
{
    int a = 0;
    int b = 1;
    int c = a + b;
    int step = 3;
    if (number >= 3)
    {
        while (step != number)
        {
            int d = b;
            b = c;
            c = c + d;
            step = step + 1;
        }
    }
    else if (number == 2)
    {
        c = 1;
    }
    else if (number == 1)
    {
        c = 0;
    }

    int result = c;
    return result;
}

int number = ReturnsNumberFromFibonacciSeries(2);
Console.WriteLine(number);