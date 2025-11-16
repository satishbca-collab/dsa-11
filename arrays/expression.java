// User function Template for Java
class Solution {
    // Function to find the maximum value of the given expression.
    public int maxValueOfExpression(int[] arr) {
        // Write Code Here
        int n = arr.length;
        
        // arr[i] + i
        int minSum = Integer.MAX_VALUE;
        int maxSum = Integer.MIN_VALUE;
        
        // arr[i] - i
        int minDiff = Integer.MAX_VALUE;
        int maxDiff = Integer.MIN_VALUE;
        
        for(int i = 0; i < n; i++){
            minSum = Math.min(minSum, arr[i] + i);
            maxSum = Math.max(maxSum, arr[i] + i);
            minDiff = Math.min(minDiff, arr[i] - i);
            maxDiff = Math.max(maxDiff, arr[i] - i);
        }
        
        return Math.max(Math.abs(maxSum - minSum), Math.abs(maxDiff - minDiff));
    }
}