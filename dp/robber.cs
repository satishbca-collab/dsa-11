public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        int[] memo = new int[n];

        if(n == 1) return nums[0];

        memo[0] = nums[0];
        memo[1] = Math.Max(nums[0], nums[1]);
        
        for(int i = 2; i < n; i++){
            memo[i] = Math.Max(memo[i-1], memo[i-2] + nums[i]);
        }

        return memo[n-1];
    }
}

