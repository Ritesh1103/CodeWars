
Solution:

using System;
public class Kata
{
  public static char FindMissingLetter(char[] array)
  {
      int len=array.Length;
      char ch='\0';
      for(int i=0;i<len-1;i++)
      {
         if((array[i+1]-array[i])!=1)
           ch= Convert.ToChar(array[i]+1);
      }
       return ch;
  }
}


