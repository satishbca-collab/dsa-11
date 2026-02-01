public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        int m = dungeon.Length;
        int n = dungeon[0].Length;

        // dp[i][j] = minimum HP needed to ENTER cell (i, j)
        int[,] dp = new int[m + 1, n + 1];

        // Fill with infinity
        for (int i = 0; i <= m; i++)
            for (int j = 0; j <= n; j++)
                dp[i, j] = int.MaxValue;

        // Base just outside destination
        dp[m, n - 1] = 1;
        dp[m - 1, n] = 1;

        // Fill from bottom-right to top-left
        for (int i = m - 1; i >= 0; i--) {
            for (int j = n - 1; j >= 0; j--) {
                int need = Math.Min(dp[i + 1, j], dp[i, j + 1]) - dungeon[i][j];
                dp[i, j] = Math.Max(1, need);
            }
        }

        return dp[0, 0];
    }
}
