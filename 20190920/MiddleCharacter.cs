
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
