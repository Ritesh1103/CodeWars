
Solution:

using System.Text.RegularExpressions;
public class Kata
{
  public static bool Alphanumeric(string str)
  {
    Regex rg = new Regex("[^a-zA-Z0-9]");
        if(str=="")
        return false;
   return rg.IsMatch(str) == true ? false : true;
  }
}

