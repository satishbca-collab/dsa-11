public class Solution {
    public int CoinChange(int[] coins, int amount) {
        return CoinChangeExclusion(coins, 0, amount);
    }

    static int CoinChangeExclusion(int[] coins, int index, int amount)
    {
        if (amount == 0) return 0;  // Base case: no coins needed
        if (amount < 0 || index >= coins.Length) return -1;  // No solution case

        // Option 1: Take the coin at index
        int includeCoin = CoinChangeExclusion(coins, index, amount - coins[index]);
        if (includeCoin != -1) includeCoin += 1;  // Add 1 if valid

        // Option 2: Skip the coin at index and check others
        int excludeCoin = CoinChangeExclusion(coins, index + 1, amount);

        // Return the minimum valid solution
        if (includeCoin == -1) return excludeCoin;
        if (excludeCoin == -1) return includeCoin;
        return Math.Min(includeCoin, excludeCoin);
    }
}