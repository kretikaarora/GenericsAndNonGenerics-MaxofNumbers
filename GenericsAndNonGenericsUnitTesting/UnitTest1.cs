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
            [TestMethod]
            [DataRow(50, 20, 30)]
            [DataRow(20, 50, 30)]
            [DataRow(20, 30, 50)]          
            public void TestOfMaxOfThreeNumbersWithIntegers(int firstNumber, int secondNumber, int thirdNumber)
            {
                //Arrange
                int expected = 50;
                //Act          
                int actual = TestMaximum.MaxOfThreeNumbers(firstNumber, secondNumber, thirdNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            /// <summary>
            /// Testing Of Max Of Three Float Numbers using Non Generic Method
            /// TC 2.1 , TC 2.2 , TC 2.3
            /// </summary>
            /// <param name="firstNumber"></param>
            /// <param name="secondNumber"></param>
            /// <param name="thirdNumber"></param>
            [DataRow(50.1f, 20.8f, 30.5f)]
            [DataRow(20.8f, 50.1f, 30.5f)]
            [DataRow(20.8f, 30.5f, 50.1f)]           
            [TestMethod]
             public void TestOfMaxOfThreeNumbersWithFloatValues(float firstNumber, float secondNumber, float thirdNumber)
            {
                //Arrange
                float expected = 50.1f;
                //Act          
                float actual = TestMaximum.MaxOfThreeFloats(firstNumber, secondNumber, thirdNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        /// <summary>
        /// Testing Of Max Of Three Numbers using Non Generic Method
        /// TC 3.1 , TC 3.2 , TC 3.3
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        [TestMethod]
        [DataRow("50", "20", "30")]
        [DataRow("20", "50", "30")]
        [DataRow("20", "30", "50")]
        public void TestOfMaxOfThreeNumbersWithString(string firstNumber, string secondNumber, string thirdNumber)
        {
            //Arrange
            string  expected = "50";
            //Act          
            string actual = TestMaximum.MaxOfThreeStrings(firstNumber, secondNumber, thirdNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
    }

