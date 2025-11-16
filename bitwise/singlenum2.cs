public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        for(int i = 0; i < 32; i++){
            int count = 0;
            foreach(int num in nums){
                // extract ith bit
                count += num >> i & 1;
            }
            // set ith bit
            result |= (count % 3) << i;
        }
        return result;
    }
}