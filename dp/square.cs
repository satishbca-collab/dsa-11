public class Solution {
    private Dictionary<int, int> memo = new Dictionary<int,int>();
    public int NumSquares(int n) {
        if(n == 0) return n;

        if(memo.ContainsKey(n)) return memo[n];
        int minCount = int.MaxValue;
        for(int i = 1; i*i <= n; i++){
            minCount = Math.Min(minCount, NumSquares(n - i*i) + 1);
        }
        memo[n] = minCount;
        return minCount;
    }
}