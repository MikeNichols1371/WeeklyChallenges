using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evenSum = numbers.Where(x => x % 2 == 0).Sum();
            var oddSubtract = numbers.Where(x => x % 2 != 0).Sum();
            return evenSum - oddSubtract;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strList = new List<string>();
            strList.Add(str1);
            strList.Add(str2);
            strList.Add(str3);
            strList.Add(str4);
            return strList.Min(x => x.Length);
            
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int>();
            numList.Add(number1);
            numList.Add(number2);
            numList.Add(number3);
            numList.Add(number4);
            return numList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 
                && sideLength1 + sideLength3 > sideLength2 
                && sideLength2 + sideLength3 > sideLength1 ? true : false;
        }

        public bool IsStringANumber(string input)
        {
            decimal numericValue;
            bool isNumber = decimal.TryParse(input, out numericValue);
            return input == null || input.Length == 0 ? false : isNumber; 
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var totalElements = objs.Count();
            var elementsNull = objs.Where(x => x == null).Count();
            var notNull = totalElements - elementsNull;
            return elementsNull > notNull ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            return  numbers == null 
                || numbers.Length == 0 
                || numbers.All(x => x % 2 != 0) 
                ? 0 : numbers.Where(x => x % 2 == 0).ToArray().Average();
        }

        public int Factorial(int number)
        {
            var num = number;
            while (num > 0)
            {
                for (int i = num - 1; i > 0; i--)
                {

                    num *= i;

                }
                return num;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return 1;
            
        }
    }
}
