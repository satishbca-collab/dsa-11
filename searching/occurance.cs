public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;

        if(n == 0) return [-1,-1];

        int l = 0, r = n-1, mid = 0;
        while(l <=r ){
            mid = l + (r-l)/2;
            if(nums[mid] == target) break;
            else if(nums[mid] > target) r = mid-1;
            else l = mid + 1;
        }

        if(nums[mid] != target) return [-1,-1];

        int leftIndex = mid, rightIndex = mid;
        while(leftIndex >= 0 && nums[leftIndex] == target) leftIndex--;
        while(rightIndex < n && nums[rightIndex] == target) rightIndex++;

        return [leftIndex+1, rightIndex-1];
    }
}