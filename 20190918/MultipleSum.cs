// Problem2

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

    Note: If the number is a multiple of both 3 and 5, only count it once.

// Solution

using System;
public static class Kata
{
  public static int Solution(int value)
  { int number=value-1;
             
//           int sum=0;
//         for(int i=3;i<value;value++)
//         {
//           if((value%3==0) || (value%5==0)){
//           sum+=value;
//           }
//         }


  float n3=number/3,n5=number/5,nb=number/15;
  float sum3,sum5,sub;
  sum3=(n3/2)*(2*3+(n3-1)*3);
  sum5=(n5/2)*(2*5+(n5-1)*5);
  sub=(nb/2)*(2*15+(nb-1)*15);
  if(nb==0)
        return Convert.ToInt32(sum3+sum5);
        else
        return Convert.ToInt32(sum3+sum5-sub);

     }  
}