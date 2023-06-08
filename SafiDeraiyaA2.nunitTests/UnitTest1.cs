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


}





