using MathAndPhysics.Playground;

BinaryCalculator binaryCalculator = new BinaryCalculator();

var tenAsBinary = BaseCalculator.NumberToBaseString(10, 2);
var twelveAsBinary = BaseCalculator.NumberToBaseString(12, 2);

var twentyTwoAsBinary = BaseCalculator.NumberToBaseString(22, 2);

Console.WriteLine(binaryCalculator.Sum(tenAsBinary, twelveAsBinary) == twentyTwoAsBinary);