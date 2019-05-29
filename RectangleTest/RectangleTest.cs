using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment_Rectangle;

namespace RactangleTest
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        public void GetLength_Input4and4_Returns4()
        {
            //Arrange
            int len = 4;
            int wid = 4;
            int expectedResult = len;
            Rectangle testRect = new Rectangle(len, wid);

            //Act   
            int actualResult = testRect.GetLength();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input4and4asInitialDimensionsAndSetLengthAs6_Returns6()
        {
            //Arrange
            int len = 4;
            int wid = 4;
            int testlength = 6;
            int expectedResult = testlength;
            Rectangle testRect = new Rectangle(len, wid);

            //Act
            int actualResult = testRect.SetLength(testlength);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetWidth_Input4and6_Returns6()
        {
            //Arrange
            int len = 4;
            int wid = 6;
            int expectedResult = wid;
            Rectangle testRect = new Rectangle(len, wid);

            //Act
            int actualResult = testRect.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Input5and6asInitialDimensionsAndSetWidthAs3_Returns3()
        {
            //Arrange
            int len = 5;
            int wid = 6;
            int testwidth = 3;
            int expectedResult = testwidth;
            Rectangle testRect = new Rectangle(len, wid);

            //Act
            int actualResult = testRect.SetWidth(testwidth);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input4and4_Returns16()
        {
            //Arrange
            int len = 4;
            int wid = 4;
            int expectedResult = (2 * len) + (2 * wid);
            Rectangle testRect = new Rectangle(len, wid);

            //Act
            int actualResult = testRect.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input3and6_Returns18()
        {
            //Arrange
            int len = 3;
            int wid = 6;
            int expectedResult = len * wid;
            Rectangle testRect = new Rectangle(len, wid);

            //Act
            int actualResult = testRect.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}


