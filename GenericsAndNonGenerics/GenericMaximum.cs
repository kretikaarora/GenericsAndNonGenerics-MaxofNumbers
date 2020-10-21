using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAndNonGenerics
{
    /// <summary>
    /// GenericMaximum Class with Generic Data Type T 
    /// where T:Icomparable is used to give access to primitive data types
    /// We are able to use Compare to inbuilt function because of Icompare
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericMaximum<T> where T : IComparable
    {
        T firstNumber, secondNumber, thirdNumber;
        /// <summary>
        /// Parameterised Constructor with three parameters
        /// During Test case now we need to add these parameters there while making an object of the class
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        public GenericMaximum(T firstNumber, T secondNumber, T thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }

        /// <summary>
        /// MaxFunction  is generic in nature 
        /// returns maximum number 
        /// data type is given at the time of calling 
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public T MaxFunction1(T firstNumber, T secondNumber, T thirdNumber)
        {
            Console.WriteLine("Maximum of Numbers using Generic Method ");
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                PrintMax(firstNumber);
                return firstNumber;
            }
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                PrintMax(secondNumber);
                return secondNumber;
            }
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                PrintMax(thirdNumber);
                return thirdNumber;
            }
            ///throwing exception when numbers are equal
            else
                throw new Exception("all the numbers are equal");

        }
        public void PrintMax(T maxNumber)
        {
            Console.WriteLine("The maximum number is : {0} ", maxNumber);
        }
    }
}
