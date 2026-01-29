public class Solution {
    private Dictionary<int, int> memo = new Dictionary<int,int>();
    public int CoinChange(int[] coins, int amount) {
        if(amount < 0){
            return -1;
        }

        if(amount == 0){
            return 0;
        }

        if(memo.ContainsKey(amount)) return memo[amount];

        int minCoins = int.MaxValue;

        foreach(int coin in coins){
            int res = CoinChange(coins, amount-coin);
            if(res != -1){
                minCoins = Math.Min(minCoins, res + 1);
            }
        }

        memo[amount] = minCoins == int.MaxValue ? -1 : minCoins;
        return memo[amount];
    }
}