class Solution {
    // Function to print all the divisors of the given number.
    public void print_divisors(int n) {
        // code here
        List<int> result = new List<int>();
        for(int i = 1; i*i <= n; i++){
            if(n%i == 0){
                result.Add(i);
                if(n/i != i){
                    result.Add(n/i);
                }
            }
        }
        result.Sort();
        foreach(int item in result){
            Console.Write(item + " ");
        }
    }
}