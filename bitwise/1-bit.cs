public class Solution {
    public int HammingWeight(int n) {
        int count = 0;
        while(n > 0){
            int bit = n & 1;
            if(bit == 1){
                count++;
            }
            n = n >> 1;
        }
        return count;
    }
}