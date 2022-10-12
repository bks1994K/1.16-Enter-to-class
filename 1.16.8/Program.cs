int MirroringEnteredNumber(int number)
{
    int tmp = 0;
    string result = "";
    bool isPositiv = number >= 0;

    if (!isPositiv)
    {
        number = -number;
    }
    while (number != 0)
    {
        tmp = number % 10;
        result = result + tmp;
        number /= 10;
    }
    if (!isPositiv)
    {
        return -Convert.ToInt32(result);
    }

    return Convert.ToInt32(result);
}

int number = MirroringEnteredNumber(-1234);
Console.WriteLine(number);