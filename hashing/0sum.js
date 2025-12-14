// User function Template for javascript

/**
 * @param {number[]} arr
 * @returns {boolean}
 */
class Solution {
    // Function to check whether there is a subarray present with 0-sum or not.
    subArrayExists(arr) {
        // code here
        var map = new Map();
        map.set(0,1);
        let sum = 0;
        for(let i = 0; i < arr.length; i++){
            sum += arr[i];
            if(map.has(sum)) return true;
            map.set(sum, 1);
        }
        return false;
    }
}