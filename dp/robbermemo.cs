public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        int[] memo = new int[n];
        for(int i = 0; i < n; i++){
            memo[i] = -1;
        }
        return Helper(nums, 0, memo);
    }

    private int Helper(int[] nums, int index, int[] memo){
        if(index >= nums.Length) return 0;
        if(memo[index] != -1) return memo[index];

        memo[index] =  Math.Max(Helper(nums, index+1, memo), nums[index] + Helper(nums, index+2, memo));

        return memo[index];
    }
}