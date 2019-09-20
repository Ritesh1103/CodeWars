
using System;

public static class Kata
{
  public static string AddBinary(int a, int b)
  {
      int c=a+b;
     string st="";
      while(c>0){
      st=c%2+st;
      c=c/2;
  }
  
    return st;
 } 
}
