
Solution:
    
using System.Collections.Generic;
public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
   int count=0,value=0;
     foreach (int num in numbers)
            {
                foreach (int num1 in numbers)
            {
            if(num==num1)
            count++;
            }
    if(count==1)
    value=num;
    count=0;
  }
  return value;
  }
}
