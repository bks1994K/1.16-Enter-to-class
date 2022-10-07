string wordNumber = ConvertingTwodigitNumberToString(20);
Console.WriteLine(wordNumber);

string ConvertingTwodigitNumberToString(int number)
{
    if (number >= 10 && number <= 99)
    {
        int a = number / 10;
        int b = number % 10;
        string x = "";
        string y = "";
        if (number >= 10 && number <= 19)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine("Десять");
                    break;
                case 11:
                    Console.WriteLine("Одиннадцать");
                    break;
                case 12:
                    Console.WriteLine("Двенадцать");
                    break;
                case 13:
                    Console.WriteLine("Тринадцать");
                    break;
                case 14:
                    Console.WriteLine("Четырнадцать");
                    break;
                case 15:
                    Console.WriteLine("Пятнадцать");
                    break;
                case 16:
                    Console.WriteLine("Шестнадцать");
                    break;
                case 17:
                    Console.WriteLine("Семнадцать");
                    break;
                case 18:
                    Console.WriteLine("Восемнадцать");
                    break;
                case 19:
                    Console.WriteLine("Девятнадцать");
                    break;
            }
        }
        else
        {
            switch (a)
            {
                case 2:
                    x = "Двадцать";
                    break;
                case 3:
                    x = "Тридцать";
                    break;
                case 4:
                    x = "Сорок";
                    break;
                case 5:
                    x = "Пятьдесят";
                    break;
                case 6:
                    x = "Шестьдесят";
                    break;
                case 7:
                    x = "Семдесят";
                    break;
                case 8:
                    x = "Восемдесят";
                    break;
                case 9:
                    x = "Девяносто";
                    break;
            }
            switch (b)
            {
                case 1:
                    y = "один";
                    break;
                case 2:
                    y = "два";
                    break;
                case 3:
                    y = "три";
                    break;
                case 4:
                    y = "четыре";
                    break;
                case 5:
                    y = "пять";
                    break;
                case 6:
                    y = "шесть";
                    break;
                case 7:
                    y = "семь";
                    break;
                case 8:
                    y = "восемь";
                    break;
                case 9:
                    y = "девять";
                    break;
            }

        }
        string result = x + " " + y;
        return result;
    }
    return "";
}

