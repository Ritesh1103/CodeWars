
Solution:
  
   using System.Globalization;
namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str)  
    {  
      TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
      str = cultInfo.ToTitleCase(str);
      str = str.Replace(" ", "");
      return str;
    }
  }
}
