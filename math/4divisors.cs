public class Solution {
    public int SumFourDivisors(int[] nums) {
        int totalSum = 0;

        for(int i = 0; i < nums.Length; i++){
            int sum = 0, count = 0;
            int target = nums[i];
            int limit = (int)Math.Sqrt(target);
            
            for(int j = 2; j <= limit; j++){
                if(target % j == 0){
                    count++;
                    sum = sum + j;
                    int otherFactor = target/j;
                    if(j != otherFactor){
                        sum = sum + otherFactor;
                        count++;
                    }
                }
            }
            if(count == 2){
                totalSum = totalSum + sum + 1 + target;
            }
        }

        return totalSum;
    }
}