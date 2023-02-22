  using System;
// solution for https://www.codewars.com/kata/58f8a3a27a5c28d92e000144

public class Kata
{
  public static object FirstNonConsecutive(int[] arr)
  {
    int prevVariable = 0;
    
    // Loop through items in array     
    foreach (int item in arr)
      {
      
        // If the item is 0 (sequence hasn't started) make 
        // prevVariable the first number in the sequence      
        if (prevVariable == 0)
          {
            prevVariable = item;
          }
      
        // if the next number is not in sequence
        // initalize the unSequentialItem and return to break the loop      
        else if ((prevVariable + 1) != item)
          {
            return item;
          }
      
        // otherwise everything is fine in the sequence      
        else 
          {
            prevVariable = item;
          }
      }
    return null;
  }
}

