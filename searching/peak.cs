public class Solution {
    public int FindPeakElement(int[] nums) {
        return Helper(nums, 0, nums.Length-1);
    }

    private int Helper(int[] nums, int l, int r){
        while( l < r){
            int mid = l + (r-l)/2;

            if(nums[mid] < nums[mid+1]){
                l = mid + 1;
            }
            else {
                r = mid;
            }
        }

        return l;
    }
}