public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int n = weights.Length, max = Int32.MinValue, sum = 0;

        for(int i = 0; i < n; i++){
            sum += weights[i];
            max = Math.Max(max, weights[i]);
        }

        int l = max, r = sum, result = 0;

        while(l <= r){
            int mid = l + (r-l)/2;
            if(helper(weights, days, mid)){
                result = mid;
                r = mid - 1;
            }
            else {
                l = mid + 1;
            }
        }

        return result;
    }

    private bool helper(int[] weights, int days, int capacity){
        int cur = weights[0], count = 1;

        for(int i = 1; i < weights.Length; i++){
            if(cur + weights[i] > capacity){
                count++;
                cur = weights[i];
            }
            else {
                cur += weights[i];
            }
        }
        return count <= days;
    }
}