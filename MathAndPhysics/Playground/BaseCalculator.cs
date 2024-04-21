namespace MathAndPhysics.Playground;

public static class BaseCalculator
{
  public static string NumberToBaseString (int Number, int Base)
  {
    var output = "";

    if (Number < Base)
    {
      output = $"{Number}";
    }
    else
    {
      var remainder = Number % Base;

      output = $"{remainder}";

      var reducedNumber = (Number - remainder) / Base;

      var restOfString = NumberToBaseString (reducedNumber, Base);

      output = $"{restOfString}{output}";
    }

    return output;
  }
}
