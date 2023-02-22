// https://www.codewars.com/kata/59ca8246d751df55cc00014c
// Solution 1
class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
       if (bullets / 2 >= dragons)
         {
          return true;
         }
      
       else
         {
        return false;
         }
    }
}

// Solution 2 - Refactored

class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
    bullets / 2 >= dragons;
    }
}
