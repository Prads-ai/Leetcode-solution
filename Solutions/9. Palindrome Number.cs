public class Solution
{
  public bool isPalendrome(int x)
  {
    //no negative number and if If we end with 0 we have to begin with 0
    if(x < 0 || (x != 0 && x % 10 == 0))
    {
     return false  
    }  
    int reverse_number = 0
    while (x > reverse_number)
    {
       //Append the last digit of x
      reverse_number = reverse_number * 10 + x % 10;
       //Change the last digit of x
      x /= 10
    }
    return x = reverse_number == 0 || x == reverse_number / 10
  }
}
