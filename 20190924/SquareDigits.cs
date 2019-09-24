
Solution


using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
  String value="";
  while(n>0)
  {
   int num=n%10;
   int res=num* num;
   value= res +value;
    n=n/10;
  }
  return Convert.ToInt32(value);
  
}
 }
