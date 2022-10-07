bool NumberInRangeFrom0To10OrFrom20To30OFrom40To50 (int a)
{
    if ((a >= 0 && a <= 10) || (a >= 20 && a <= 30) || (a >= 40 && a <= 50))
    {
        bool result;
        return result = true;
    }
    else 
    { 
        return false;
    }
}

bool number= NumberInRangeFrom0To10OrFrom20To30OFrom40To50(11);
Console.WriteLine(number);