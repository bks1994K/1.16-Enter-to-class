int MirroringEnteredNumber(int number)
{
    int tmp = 0;
    string result ="";
    while (number != 0)
    {
        tmp = number % 10;
        result = result + tmp;
        number /= 10;
    }
    return Convert.ToInt32(result);
    }

int number = MirroringEnteredNumber(1234);
Console.WriteLine(number);