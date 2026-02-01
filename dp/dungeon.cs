public class Solution {
    private Dictionary<(int, int), int> memo = new Dictionary<(int,int),int>();
    public int CalculateMinimumHP(int[][] dungeon) {
        return Helper(dungeon, 0, 0);
    }

    private int Helper(int[][] dungeon, int i, int j){
        int m = dungeon.Length, n = dungeon[0].Length;

        if(i == m-1 && j == n-1){
            return Math.Max(1, 1 - dungeon[i][j]);
        }

        if(i >= m || j >= n){
            return int.MaxValue;
        }

        if(memo.ContainsKey((i,j))) return memo[(i,j)];

        int right = Helper(dungeon, i, j+1);
        int down = Helper(dungeon, i+1, j);

        int minHealth = Math.Min(right, down) - dungeon[i][j];

        memo[(i,j)] = Math.Max(1, minHealth);
        return memo[(i,j)];
    }
}