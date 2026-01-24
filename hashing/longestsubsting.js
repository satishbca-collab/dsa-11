/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    var set = new Set();
    let max = 0, left = 0;
    for(let right = 0; right < s.length; right++){
        while(set.has(s[right])){
            set.delete(s[left++]);
        }
        set.add(s[right]);
        max = Math.max(max, right-left+1);
    }
    return max;
};