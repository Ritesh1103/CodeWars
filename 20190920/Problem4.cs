
Problem

You are going to be given a word. Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.


Solution

using System;

public class Kata
{
  public static string GetMiddle(string s)
  { 
  
       
        string Reslt=" ";
         char[] b = s.ToCharArray();
         int length = s.Length;
             int  midvalue = length /2;
            if (length % 2 != 0)
           {
             
                Reslt = s[midvalue].ToString();
            }
            else
            {
                Reslt=s[midvalue-1].ToString()+s[midvalue].ToString() ;
            }
            return Reslt;
  }
}