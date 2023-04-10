using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 202. Happy Number

            int x = 1111111;  

            Solution solution = new Solution();
            Console.WriteLine(solution.IsHappy(x));


        }
    }

    public class Solution
    {
        public bool IsHappy(int n)
        {
            int result = DigitsDoubleSum(GetDigits(n));
            int counter = 0;

            while (result != 1 && counter != 25)
            {
                result = DigitsDoubleSum(GetDigits(result));
                counter++;
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int> GetDigits(int input)
        {
            int currentNumber = input;
            List<int> dig = new List<int>();
            while (currentNumber != 0)
            {
                dig.Add(currentNumber % 10);
                currentNumber = currentNumber / 10;
            }
            dig.Reverse();
            return dig;
        }

        public int DigitsDoubleSum(List<int> puts)
        {
            int result = 0;
                
            for (int i = 0; i < puts.Count; i++)
            {
                result = result + puts[i] * puts[i];             
            }
            
            return result;
        }
    }
}
