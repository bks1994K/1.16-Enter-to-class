namespace _1._16._2Test
{
    public class PlusMultiplicationMinusTests
    {
        [TestCase(0, -5, -3)]
        [TestCase(100, 2, 102)]
        [TestCase(-10, -20, -10)]

        public void PlusTest(int a, int b, int expected)
        {
            int actual = PlusMultiplicationMinusTests.Plus(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}

//int Plus(int a, int b)
//{
//    int result = a + b;
//    return result;
//}

//int Multiplication(int a, int b)
//{
//    int result = a * b;
//    return result;
//}

//int Minus(int a, int b)
//{
//    int result = a - b;
//    return result;
//}

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//if (a > b)

//{
//    int result = Plus(a, b);
//    Console.WriteLine(result);
//}

//else if (a == b)
//{
//    int result = Multiplication(a, b);
//    Console.WriteLine(result);
//}

//else
//{
//    int result = Minus(a, b);
//    Console.WriteLine(result);
//}