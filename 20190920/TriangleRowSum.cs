public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
         if (a + b <= c || a + c <= b || b + c <= a) 
         {
        return false; 
        }
    else
    {
        return true; 
    }
   } 
}
