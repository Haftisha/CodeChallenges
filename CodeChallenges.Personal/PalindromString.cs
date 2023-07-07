namespace CodingChallenges.Personal
{
    /// <summary>
    /// Check is string is palindrom
    /// Note: Empty string is palindrom. In addition, a string which constitutes only single character isalso a palindrom.
    /// </summary>
    public static class PalindromString
    {
        public static bool IsPalindrom(string inputStr)
        {
            if (string.IsNullOrWhiteSpace(inputStr) || inputStr.Length <= 1) return true;

            inputStr = inputStr.ToLower();
            for (int i = 0; i < inputStr.Length / 2; ++i)
            {
                if (inputStr[i] == inputStr[inputStr.Length - 1 - i])
                {
                    continue;
                }
                return false;
            }

            return true;
        }

    }
}
