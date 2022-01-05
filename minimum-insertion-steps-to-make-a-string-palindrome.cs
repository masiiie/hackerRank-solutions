// https://leetcode.com/problems/minimum-insertion-steps-to-make-a-string-palindrome/


public class Solution {
    public int MinInsertions(string s) {
             int[,] dp = new int[s.Length + 1, s.Length];

            for (int i = 2; i < s.Length + 1; i++)
            {
                for (int j = 0; j < s.Length - i + 1; j++)
                {
                    if (s[j] == s[j + i - 1]) dp[i, j] = dp[i - 2, j + 1];
                    else dp[i, j] = Math.Min(dp[i - 1, j + 1], dp[i - 1, j]) + 1;
                }
            }

            return dp[s.Length, 0];
    }
}