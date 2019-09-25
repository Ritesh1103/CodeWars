
Solution


using System.Linq;
public class Kata
{
  public static string High(string s)
  {
    return s.Split(' ').OrderBy(a=>a.Select(b=>b-96).Sum()).Last();
  }
}
