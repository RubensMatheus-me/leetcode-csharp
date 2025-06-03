namespace LeetCode.algorithmicProblems.palindromeNumber;

public class PalindromeNumber {
    public bool IsPalindrome(int x)
    {
        string valueString = x.ToString();
        char[] array = valueString.ToCharArray();
        Array.Reverse(array);
        return valueString == new string(array);
    }
}