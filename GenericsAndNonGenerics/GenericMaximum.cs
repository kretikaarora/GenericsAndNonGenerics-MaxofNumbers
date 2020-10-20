﻿using System;
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
     public class GenericMaximum <T> where T:IComparable
    {   
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
            Console.WriteLine("Maximum of three Numbers using Generic Method ");
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