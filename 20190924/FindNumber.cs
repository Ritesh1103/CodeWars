
Solution:


namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
       int count=0;
     foreach (int num in seq)
            {
                foreach (int num1 in seq)
            {
            if(num==num1)
            count++;
            }
    if(count%2!=0)
    return num;
    count=0;
  }   return 0;
      }
    }
}
