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
        public void TestOfMaxOfThreeNumbersWithIntegersUsingNonGeneric(int firstNumber, int secondNumber, int thirdNumber)
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
        public void TestOfMaxOfThreeNumbersWithFloatValuesUsingNonGeneric(float firstNumber, float secondNumber, float thirdNumber)
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
        public void TestOfMaxOfThreeNumbersWithStringUsingNonGeneric(string firstNumber, string secondNumber, string thirdNumber)
        {
            //Arrange
            string expected = "50";
            //Act          
            string actual = TestMaximum.MaxOfThreeStrings(firstNumber, secondNumber, thirdNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Testing Of Max Of Three Numbers using  Generic Method
        /// Refractoring the code
        /// TC 4.1 , TC 4.2 , TC 4.3
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        [TestMethod]
        [DataRow(50, 20, 30)]
        [DataRow(20, 50, 30)]
        [DataRow(20, 30, 50)]
        public void TestOfMaxOfThreeNumbersWithIntegersUsingGeneric(int firstNumber, int secondNumber, int thirdNumber)
        {
            //Arrange
            int expected = 50;
            //Act          
            GenericMaximum<int> obj = new GenericMaximum<int>();
            int actual = obj.SortingNumbers(firstNumber, secondNumber, thirdNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Testing Of Max Of Three Float Numbers using Generic Method
        /// Refractoring Code
        /// TC 4.1 , TC 4.2 , TC 4.3
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        [DataRow(50.1f, 20.8f, 30.5f)]
        [DataRow(20.8f, 50.1f, 30.5f)]
        [DataRow(20.8f, 30.5f, 50.1f)]
        [TestMethod]
        public void TestOfMaxOfThreeNumbersWithFloatValuesUsingGeneric(float firstNumber, float secondNumber, float thirdNumber)
        {
            //Arrange
            float expected = 50.1f;
            //Act    
            GenericMaximum<float> obj = new GenericMaximum<float>();
            float actual = obj.MaxFunction1(firstNumber, secondNumber, thirdNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing Of Max Of Three Numbers using Generic Method
        /// Refractoring Code
        /// TC 4.1 , TC 4.2 , TC 4.3
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        [TestMethod]
        [DataRow("50", "20", "30")]
        [DataRow("20", "50", "30")]
        [DataRow("20", "30", "50")]
        public void TestOfMaxOfThreeNumbersWithStringUsingGeneric(string firstNumber, string secondNumber, string thirdNumber)
        {
            //Arrange
            string expected = "50";
            //Act          
            GenericMaximum<string> obj = new GenericMaximum<string>();
            string actual = obj.MaxFunction1(firstNumber, secondNumber, thirdNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing Of Max Of Three Numbers using  Generic Method Using Params
        /// Refractoring the code
        /// TC 4.4
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        [TestMethod]
        [DataRow(50, 20, 30)]
        [DataRow(20, 50, 30)]
        [DataRow(20, 30, 50)]
        public void TestOfMaxOfThreeNumbersWithIntegersUsingGenericWithParams(int[] inputParameters)
        {
            //Arrange
            int expected = 50;
            //Act          
            GenericMaximum<int> obj = new GenericMaximum<int>();
            int actual = obj.SortingNumbers(inputParameters);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Testing Of Max Of Three Float Numbers using Generic Method Using Params
        /// Refractoring Code
        /// TC 4.5
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        [DataRow(50.1f, 20.8f, 30.5f)]
        [DataRow(20.8f, 50.1f, 30.5f)]
        [DataRow(20.8f, 30.5f, 50.1f)]
        [TestMethod]
        public void TestOfMaxOfThreeNumbersWithFloatValuesUsingGenericUsingParams(float[] inputParameters)
        {
            //Arrange
            float expected = 50.1f;
            //Act    
            GenericMaximum<float> obj = new GenericMaximum<float>();
            float actual = obj.SortingNumbers(inputParameters);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Testing Of Max Of Three Numbers using Generic Method Using Params
        /// Refractoring Code
        /// TC 4.6
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        [TestMethod]
        [DataRow("50", "20", "30")]
        [DataRow("20", "50", "30")]
        [DataRow("20", "30", "50")]
        public void TestOfMaxOfThreeNumbersWithStringUsingGenericUsingParams(string[] inputParameters)
        {
            //Arrange
            string expected = "50";
            //Act          
            GenericMaximum<string> obj = new GenericMaximum<string>();
            string actual = obj.SortingNumbers(inputParameters);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    } 
}

