public class Solution {
    public int UniquePaths(int m, int n) {
        return Helper(m-1, n-1);
    }

    private int Helper(int x, int y){
        if(x == 0 && y == 0){
            return 1;
        }

        if(x < 0 || y < 0){
            return 0;
        }

        return Helper(x-1, y) + Helper(x, y-1);
    }
}

public class Solution {
    private int[][] memo;
    public int UniquePaths(int m, int n) {
        memo = new int[m][];
        for(int i = 0; i < m; i++){
            memo[i] = new int[n];
            for(int j = 0; j < n; j++){
                memo[i][j] = -1;
            }
        }
        return Helper(m-1, n-1);
        // return memo[m-1][n-1];
    }

    private int Helper(int x, int y){
        if(x == 0 && y == 0){
            memo[x][y] = 1;
            return 1;
        }

        if(x < 0 || y < 0){
            return 0;
        }

        if(memo[x][y] != -1){
            return memo[x][y];
        }

        memo[x][y] = Helper(x-1, y) + Helper(x, y-1);
        return memo[x][y];
    }
}