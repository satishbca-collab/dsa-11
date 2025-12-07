/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    var map = new Map();

    for(let i = 0; i < nums.length; i++){
        const key = target - nums[i];
        if(map.has(key)) return [i,map.get(key)];
        map.set(nums[i], i);
    }
};