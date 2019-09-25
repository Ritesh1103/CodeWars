
Solution:


using System;
using System.Numerics;

public class Kata
{
  public static string Add(string a, string b)
  {
     BigInteger c = BigInteger.Parse(a);
      BigInteger d= BigInteger.Parse(b);
     BigInteger sum = c+d;
    string myString = sum.ToString();
    return myString; 
  }
}
