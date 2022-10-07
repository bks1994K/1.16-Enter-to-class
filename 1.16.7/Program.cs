
int CountOddDigitsAreTheNumbers(int number)
{
    int s = 0;
    int tmp = 1;
    while (number != 0)
    {
        tmp = number % 10;
        if (tmp % 2 != 0)
        {
           s = s + 1;
        }
        number = number / 10;
    }
    int result = s;
    return result;
}


int number = CountOddDigitsAreTheNumbers(-978512);
Console.WriteLine(number);