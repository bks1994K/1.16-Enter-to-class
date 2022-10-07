int MirroringEnteredNumber(int number)
{
    int tmp = 0;
    while (number != 0)
    {
        tmp = number % 10;
        Console.Write(tmp);
        number /= 10;
    }
    return 0;
    }

int number = MirroringEnteredNumber(1234);
Console.WriteLine(number);