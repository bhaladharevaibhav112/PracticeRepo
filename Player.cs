using System.Runtime.Intrinsics.Arm;

public class Palindrome
{
    public bool IsPalindrome(string str)
    {
        int len = str.Length;
        int first = 0;
        int last = len - 1;

        while(first<last)
        {
            if(str[first] != str[last])
            {
                return false;
            }
            first++;
            last--;

        }
        return true;

    }
}

class Solution
{
    static void Main()
    {
        Palindrome p1 = new Palindrome();
        Console.WriteLine("is "+p1.IsPalindrome("aba"));
    }
}