using TriangleSolver;
// Get percentage
var triangleCheck = new Triangle();
Console.Write("Enter the firstSide: ");
var firstSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the secondSide: ");
var secondSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the thirdSide: ");
var thirdSide = Convert.ToInt32(Console.ReadLine());
var output = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
// Print grade
Console.WriteLine($"output : {output} ");