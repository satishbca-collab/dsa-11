public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;

        if(n == 0) return [-1,-1];

        return [firstOccurance(nums, target), lastOccurance(nums, target)];
    }

    private int firstOccurance(int[] nums, int target){
        int n = nums.Length;
        int l = 0, r = n-1, result, mid=0;
        while(l < r){
            mid = l + (r-l)/2;
            if(nums[mid] >= target){
                r = mid;
            }
            else {
                l = mid + 1;
            }
        }
        return nums[l] == target ? l : -1;
    }

    private int lastOccurance(int[] nums, int target){
        int n = nums.Length;
        int l = 0, r = n-1, result, mid=0;
        while(l < r){
            mid = l + (r-l+1)/2;
            if(nums[mid] <= target){
                l = mid;
            }
            else {
                r = mid-1;
            }
        }
        return nums[l] == target ? l : -1;
    }
}