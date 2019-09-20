// Problem3

Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.

The binary number returned should be a string.


// Solution

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