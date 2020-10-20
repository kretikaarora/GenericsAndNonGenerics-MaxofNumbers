using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndNonGenerics
{
    public class TestMaximum
    {
        /// <summary>
        /// MaxOfThreeNumbers function is using compareTo Method to find the greatest number of three 
        /// If all the three numbers are same it will throw an exception
        /// UC1
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static int MaxOfThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Maximum Number using non generic for integer value");
            /// using CompareTo Method to compare numbers
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                return firstNumber;
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                return secondNumber;
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                return thirdNumber;
            ///throwing exception when numbers are equal
            else
                throw new Exception("all the numbers are equal");
        }
        /// <summary>
        /// MaxOfThreeNumbers function is using compareTo Method to find the greatest number of three which are float
        /// If all the three numbers are same it will throw an exception
        /// UC 2
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static float MaxOfThreeFloats(float firstNumber, float secondNumber, float thirdNumber)
        {
            Console.WriteLine("Maximum Number using non generic for float value");
            /// using CompareTo Method to compare numbers
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                return firstNumber;
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                return secondNumber;
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                return thirdNumber;
            ///throwing exception when numbers are equal
            else
                throw new Exception("all the numbers are equal");
        }
        /// <summary>
        /// MaxOfThreeNumbers function is using compareTo Method to find the greatest number of three which are String Datatype
        /// If all the three numbers are same it will throw an exception
        /// UC 3
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static String MaxOfThreeStrings(string firstNumber, string secondNumber, string thirdNumber)
        {
            Console.WriteLine("Maximum Number using non generic for string value");
            /// using CompareTo Method to compare numbers
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                return firstNumber;
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                return secondNumber;
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                return thirdNumber;
            ///throwing exception when numbers are equal
            else
                throw new Exception("all the numbers are equal");
        }
        
    }
}
