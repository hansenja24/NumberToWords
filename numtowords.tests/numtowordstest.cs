using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using numToWords.Models;

namespace numToWords.TestTools
{
    [TestClass]
    public class numToWordsTests
    {

        [TestMethod]
        public void GetValue()
        {
            //Arrange
            numWords newNum = new numWords("123");

            string output= "one hundred twenty three";

            //Act
            string result = newNum.getWord();

            Console.WriteLine("Result: " +  result);



            //Assert
            Assert.AreEqual(result, output);
        }




    }

}
