namespace MathAndPhysics.Playground;

public class BinaryCalculator
{
  private int Not(int value)
  {
    if (value == 0) return 1;

    return 0;
  }
  private string PadWithZeros (string binary, int range)
  {
    for (int i = range; i > 0; i--) 
    {
      binary = "0" + binary;
    }

    return binary;
  }
  public string Sum(string num1, string num2)
  {
    var smallerOne = Math.Min(num1.Length, num2.Length);

    if (smallerOne == num1.Length)
    {
      num1 = PadWithZeros(num1, num2.Length - smallerOne);
    } else
    {
      num2 = PadWithZeros(num2, num1.Length - smallerOne);
    }

    var output = "";
    var carry = 0;

    for (int i = num1.Length - 1; i >= 0; i--) 
    {
      var k1 = num1[i];
      var k2 = num2[i];

      var writeDigit = 0;

      if (k1 == k2)
      {
        writeDigit = carry;
        carry = k1 - '0';
      } else
      {
        writeDigit = Not(carry);
      }

      output = writeDigit + output;
    }

    if (carry != 0) 
    {
      output = carry + output;
    }

    return output;
  }
}
