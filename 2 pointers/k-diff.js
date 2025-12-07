/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var findPairs = function(nums, k) {
    nums.sort((a,b) => a-b);

    let left = 0, right = 1, count = 0;
    const n = nums.length;

    while(right < n){
        const diff = nums[right] - nums[left];
        if(diff < k || left >= right) right++;
        else if(diff > k) left++;
        else {
            count++;
            left++;
            right++;
            // skip duplicates
            while(nums[left] == nums[left-1] && left < n) left++;
        }
    }

    return count;
};

/**
[1,1,3,4,5]
 */