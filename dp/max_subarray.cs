public class Solution {
    public int MaxSubArray(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        dp[0] = nums[0];
        int maximumSumSubarray = nums[0];
        for(int i=1; i<n; i++){
            dp[i] = nums[i] + (dp[i-1] > 0 ? dp[i-1] : 0);
            maximumSumSubarray = Math.Max(maximumSumSubarray, dp[i]);
        }
        return maximumSumSubarray;
    }
}