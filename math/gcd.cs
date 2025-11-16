// User function Template for C#

class Solution {
    // Complete this function
    // Function to return gcd of array elements.
    public int gcd(int n, int[] arr) {
        // Your code here
        int result = arr[0];
        for(int i = 1; i < n; i++){
            result = GCD(result, arr[i]);
        }
        
        return result;
    }
    
    private int GCD(int a, int b){
        int x = Math.Min(a,b);
        int y = Math.Max(a,b);
        
        if(x == 0) return y;
        
        return GCD(x, y%x);
    }
}