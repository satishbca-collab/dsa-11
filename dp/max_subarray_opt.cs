/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function(nums) {
    let sum = nums[0],
    max = nums[0];
  for (let i = 1; i < nums.length; i++) {
    sum += nums[i];
    if (sum < nums[i]) {
      sum = nums[i];
    }
    max = Math.max(max, sum);
  }
  return max;
};