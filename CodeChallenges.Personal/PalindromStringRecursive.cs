namespace CodingChallenges.Personal
{
    /// <summary>
    /// Check is string is palindrom
    /// Note: Empty string is palindrom. In addition, a string which constitutes only single character isalso a palindrom.
    /// </summary>
    public static class PalindromStringRecursive
    {
        public static bool IsPalindromRecursive(string inputStr)
        {
            if (string.IsNullOrWhiteSpace(inputStr) || inputStr.Length <= 1) return true;

            inputStr = inputStr.ToLower();

            return inputStr[0] == inputStr[inputStr.Length - 1] &&
                IsPalindromRecursive(inputStr.Substring(1, inputStr.Length - 2));
        }
    }
}
