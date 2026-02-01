class Solution {
    static Boolean isSubsetSum(int arr[], int sum) {
        // Create a fresh memoization table for each call
        Boolean[][] memo = new Boolean[arr.length + 1][sum + 1];
        return Helper(arr, arr.length, sum, memo);
    }
    
    static boolean Helper(int[] arr, int n, int sum, Boolean[][] memo) {
        // Base cases
        if (sum == 0) return true;
        if (n == 0) return false;
        
        // Check if already computed
        if (memo[n][sum] != null) {
            return memo[n][sum];
        }
        
        // If the last element is greater than sum, exclude it
        boolean result;
        if (arr[n - 1] > sum) {
            result = Helper(arr, n - 1, sum, memo);
        } else {
            // Either include or exclude the current element
            result = Helper(arr, n - 1, sum, memo) || Helper(arr, n - 1, sum - arr[n - 1], memo);
        }
        
        // Store result in memo table
        memo[n][sum] = result;
        return result;
    }
}