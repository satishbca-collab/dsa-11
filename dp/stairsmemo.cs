public class Solution {
    public int ClimbStairs(int n) {
        if(n == 1 || n == 2) return n;
        int[] memo = new int[n+1];
        memo[1] = 1;
        memo[2] = 2;
        return Helper(n, memo);
    }

    private int Helper(int n, int[] memo){
        if(memo[n] != 0) return memo[n];

        memo[n-1] = Helper(n-1, memo);
        memo[n-2] = Helper(n-2, memo);
        memo[n] = memo[n-1] + memo[n-2];
        return memo[n];
    }
}