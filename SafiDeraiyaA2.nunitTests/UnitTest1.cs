using System.Runtime.Intrinsics.X86;
using TriangleSolver;

namespace SafiDeraiyaA2.nunitTests;

public class Tests
{
    private Triangle triangleSolver { get; set; } = null!;

    [SetUp]
    public void Setup()
    {
        triangleSolver = new Triangle();
    }

    //   Only one(1) test for a valid equilateral triangle

    [Test]
    public void AnalyzeTriangle_Input12and12and12_OutputvalidEquilateralTriangle()
    {
        //Arrange
        int firstAngle = 12;
        int secondAngle = 12;
        int thirdAngle = 12;

        string expected = "The triangle is valid and is an EQUILATERAL";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    //   Three (3) tests for a valid isosceles triangle

    [Test]
    public void AnalyzeTriangle_Input126and126and124_OutputValidIsoscelesTriangle()
    {
        //Arrange
        int firstAngle = 126;
        int secondAngle = 126;
        int thirdAngle = 124;

        string expected = "The triangle is valid and is an ISOSCELES";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void AnalyzeTriangle_Input124and126and126_OutputValidIsoscelesTriangle()
    {
        //Arrange
        int firstAngle = 124;
        int secondAngle = 126;
        int thirdAngle = 126;

        string expected = "The triangle is valid and is an ISOSCELES";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void AnalyzeTriangle_Input126and124and126_OutputValidIsoscelesTriangle()
    {
        //Arrange
        int firstAngle = 126;
        int secondAngle = 124;
        int thirdAngle = 126;

        string expected = "The triangle is valid and is an ISOSCELES";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }



    // Five(5) tests for a valid scalene triangle


    [Test]
    public void AnalyzeTriangle_Input12and10and16_OutputValidScaleneTriangle()
    {
        //Arrange
        int firstAngle = 12;
        int secondAngle = 10;
        int thirdAngle = 16;

        string expected = "The triangle is valid and is a SCALENE";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void AnalyzeTriangle_Input14and26and33_OutputValidScaleneTriangle()
    {
        //Arrange
        int firstAngle = 14;
        int secondAngle = 26;
        int thirdAngle = 33;

        string expected = "The triangle is valid and is a SCALENE";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void AnalyzeTriangle_Input40and50and60_OutputValidScaleneTriangle()
    {
        //Arrange
        int firstAngle = 40;
        int secondAngle = 50;
        int thirdAngle = 60;

        string expected = "The triangle is valid and is a SCALENE";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void AnalyzeTriangle_Input600and500and900_OutputValidScaleneTriangle()
    {
        //Arrange
        int firstAngle = 600;
        int secondAngle = 500;
        int thirdAngle = 900;

        string expected = "The triangle is valid and is a SCALENE";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void AnalyzeTriangle_Inpu7860and650and560_OutputValidScaleneTriangle()
    {
        //Arrange
        int firstAngle = 786;
        int secondAngle = 650;
        int thirdAngle = 560;

        string expected = "The triangle is valid and is a SCALENE";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }

}





