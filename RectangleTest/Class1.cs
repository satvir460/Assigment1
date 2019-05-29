using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignmnet1;
using NUnit.Framework;
namespace SENG_8040_Assignment1_Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetLength_Input10_Returns10()
        {

            //Arrange
            int length = 10;
            int width = 20;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetWidth_Input30_Returns30()
        {

            //Arrange
            int length = 20;
            int width = 30;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetWidth();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input25_Returns25()
        {

            //Arrange
            int length = 25;
            int width = 2;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetLength(length);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Setwidth_Input50_Returns50()
        {

            //Arrange
            int length = 5;
            int width = 50;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetWidth(width);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input_Length5And_Width10_Returns30()
        {

            //Arrange
            int length = 5;
            int width = 10;

            int expectedResult = 2 * (length + width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetPerimeter();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input_Length10And_Width10_Returns100()
        {

            //Arrange
            int length = 10;
            int width = 10;

            int expectedResult = (length * width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetArea();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}



