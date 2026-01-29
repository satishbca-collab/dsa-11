public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length, n = text2.Length;

        int[,] memo = new int[m+1,n+1];

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                memo[i,j] = 0;
            }
        }

        for(int i = 1; i <= m; i++){
            for(int j = 1; j <= n; j++){
                if(text1[i-1] == text2[j-1]){
                    memo[i,j] = 1 + memo[i-1,j-1];
                }
                else {
                    memo[i,j] = Math.Max(memo[i,j-1],memo[i-1,j]);
                }
            }
        }
        return memo[m,n];
    }
}