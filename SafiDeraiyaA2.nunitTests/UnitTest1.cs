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


    // Three (3) tests for verifying a zero length for one or more sides

    [Test]
    public void AnalyzeTriangle_Input0and5and9_OutputVerifyZero()
    {
        //Arrange
        int firstAngle = 0;
        int secondAngle = 5;
        int thirdAngle = 9;

        string expected = "At least one side of your triangle has a zero length and is thus invalid";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void AnalyzeTriangle_Input10and0and4_OutputVerifyZero()
    {
        //Arrange
        int firstAngle = 10;
        int secondAngle = 0;
        int thirdAngle = 4;

        string expected = "At least one side of your triangle has a zero length and is thus invalid";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void AnalyzeTriangle_Input15and30and0_OutputVerifyZero()
    {
        //Arrange
        int firstAngle = 15;
        int secondAngle = 30;
        int thirdAngle = 0;

        string expected = "At least one side of your triangle has a zero length and is thus invalid";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    // Three (3) tests for verifying an invalid response (other than a zero length)


    [Test]
    public void AnalyzeTriangle_Input20and10and10_OutputVerifyInvalidResponse()
    {
        //Arrange
        int firstAngle = 20;
        int secondAngle = 10;
        int thirdAngle = 10;

        string expected = "A triangle cannot be formed with those numbers";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void AnalyzeTriangle_Input_9and_8and_5_OutputVerifyInvalidResponse()
    {
        //Arrange
        int firstAngle = -9;
        int secondAngle = -8;
        int thirdAngle = -5;

        string expected = "A triangle cannot be formed with those numbers";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void AnalyzeTriangle_Input3and10and5_OutputVerifyInvalidResponse()
    {
        //Arrange
        int firstAngle = 3;
        int secondAngle = 10;
        int thirdAngle = 5;

        string expected = "A triangle cannot be formed with those numbers";

        //Act
        string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

        //Assert
        Assert.AreEqual(expected, actual);
    }

}





