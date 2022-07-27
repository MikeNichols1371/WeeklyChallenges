using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == c)
                {
                    return true;
                }
            }
            return false;
        }
        
        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0 ;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
           
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
           
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null || numbers.Length == 0 ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null || numbers.Length == 0 ? 0 : numbers.Where(x => (x % 2 == 0)).ToList().Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers == null || numbers.Count == 0 ? false : numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;
        }
    }
}
