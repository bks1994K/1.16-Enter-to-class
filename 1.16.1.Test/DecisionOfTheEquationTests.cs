using _1._16._1;

namespace _1._16._1.Test
{
    //1

    public class DecisionOfTheEquationTests
    {
        [TestCase(2,20,40,10)]
        [TestCase(5,10,0,-2)]
        [TestCase(100,-150,-50,1)]
        [TestCase(7,40,40,0)]
        public void MinusAndDivision(int a, int b, int c, int expected)
        {
            int actual = DecisionOfTheEquation.MinusAndDivision(a,b,c);

            Assert.AreEqual(expected, actual);
        }
    }

  }



