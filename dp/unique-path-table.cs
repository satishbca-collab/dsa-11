public class Solution {
    public int UniquePaths(int m, int n) {
        int[][] dp = new int[m][];
        for(int i = 0; i < m; i++){
            dp[i] = new int[n];
        }
        dp[0][0] = 1;

        for(int i=0; i<m; i++) {
            for(int j=0; j<n; j++) {
                if(i == 0 && j == 0) continue;
                int u = 0, l = 0;
                if(i > 0) u = dp[i - 1][j];
                if(j > 0) l = dp[i][j - 1];
                dp[i][j] = u + l;
            }
        }
        return dp[m - 1][n - 1];
    }
}