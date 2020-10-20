using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsAndNonGenerics;

namespace GenericsAndNonGenericsUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
            /// <summary>
            /// Testing Of Max Of Three Numbers using Non Generic Method
            /// TC 1.1 , TC 1.2 , TC 1.3
            /// </summary>
            /// <param name="firstNumber"></param>
            /// <param name="secondNumber"></param>
            /// <param name="thirdNumber"></param>
            [DataRow(50, 20, 30)]
            [DataRow(20, 50, 30)]
            [DataRow(20, 30, 50)]
            [DataRow(50, 50, 50)]
            [TestMethod]
            public void TestOfMaxOfThreeNumbersWithIntegers(int firstNumber, int secondNumber, int thirdNumber)
            {
                //Arrange
                int expected = 50;
                //Act          
                int actual = TestMaximum.MaxOfThreeNumbers(firstNumber, secondNumber, thirdNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }

        }
    }

