public class Solution {
    public int FindMin(int[] nums) {
        return Helper(nums, 0, nums.Length - 1);
    }

    private int Helper(int[] nums, int left, int right){
        while(left < right){
            int mid = left + (right - left)/2;
            if(nums[mid] > nums[right]){
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        return nums[left];
    }
}
// 4 5 1 2 3