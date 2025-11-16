// User function Template for C#

class Solution {
    // Function to check if a number is prime or not.
    public bool isPrime(int n) {
        // code here
        for(int i = 2; i*i <= n; i++){
            if(n % i == 0){
                return false;
            }
        }
        
        return true;
    }
}

// User function Template for C#

class Solution {
    // Function to check if a number is prime or not.
    public bool isPrime(int n) {
        // code here
        if(n == 2 || n == 3){
            return true;
        }
        
        if(n % 2 == 0 || n % 3 == 0){
            return false;
        }
        
        for(int i = 5; i*i <= n; i= i + 6){
            if(n % i == 0 || n % (i+2) == 0){
                return false;
            }
        }
        
        return true;
    }
}