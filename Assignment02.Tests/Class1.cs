using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment02;
using NUnit.Framework;

namespace Assignment02.Tests
{
    [TestFixture]
    public class assignment02
    {
        [Test]

        public void Analyze_inputSumAandBLessThanC_expectedTriangleNotFormed()
        // to check if triangle is formed or not sum of values of side A and side B is provided smaller than the value of side C
        {
            // Arrange
            int a = 1;
            int b = 2;
            int c = 4;


            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.That(message, Is.EqualTo("Triangle is not formed"));
            //Assert.True(message.Success);

        }
        [Test]

        public void Analyze_inputSumBandCLessThanA_expectedTriangleNotFormed()
        // to check if triangle is formed or not sum of values of side B and side C is provided smaller than the value of side A
        {
            // Arrange
            int a = 4;
            int b = 1;
            int c = 2;


            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.That(message, Is.EqualTo("Triangle is not formed"));
            //Assert.True(message.Success);

        }
        [Test]

        public void Analyze_inputSumAandCLessThanB_expectedTriangleNotFormed()
        // to check if triangle is formed or not sum of values of side A and side C is provided smaller than the value of side B
        {
            // Arrange
            int a = 1;
            int b = 4;
            int c = 2;


            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.That(message, Is.EqualTo("Triangle is not formed"));
            //Assert.True(message.Success);

        }
        [Test]

        public void Analyze_inputAllSidesEqual_expectedEquilateralTriangle()
        // to check if triangle is Equilateral triangle or not the value of all sides are provided equal
        {
            // Arrange
            int a = 4;
            int b = 4;
            int c = 4;


            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.That(message, Is.EqualTo("It is an Equilateral Triangle"));
            //Assert.True(message.Success);

        }
        [Test]

        public void Analyze_inputAAndBEqual_expectedIsocelesTriangle()
        // to check if triangle is Isosceles triangle or not the values of side A and side B is provided equal and side C is different
        {
            // Arrange
            int a = 4;
            int b = 4;
            int c = 3;


            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.That(message, Is.EqualTo("It is Isosceles Triangle"));
            //Assert.True(message.Success);

        }
        [Test]

        public void Analyze_inputBAndCEqual_expectedIsocelesTriangle()
        // to check if triangle is Isosceles triangle or not the values of side B and side C is provided equal and side A is different
        {
            // Arrange
            int a = 5;
            int b = 4;
            int c = 4;


            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.That(message, Is.EqualTo("It is Isosceles Triangle"));
            //Assert.True(message.Success);

        }
        [Test]

        public void Analyze_inputAAndCEqual_expectedIsocelesTriangle()
        // to check if triangle is Isosceles triangle or not the values of side A and side C is provided equal and side B is different
        {
            // Arrange
            int a = 5;
            int b = 4;
            int c = 5;


            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.That(message, Is.EqualTo("It is Isosceles Triangle"));
            //Assert.True(message.Success);

        }
        [Test]

        public void Analyze_inputNoSideEqual_expectedScaleneTriangle()
        // to check if triangle is Scalene triangle All the sides are provided different values i.e. side A, side B, side C are all different
        {
            // Arrange
            int a = 5;
            int b = 4;
            int c = 3;


            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.That(message, Is.EqualTo("It is Scalene Triangle"));
            //Assert.True(message.Success);

        }
    }
}
