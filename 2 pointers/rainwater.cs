/**
 * @param {number[]} height
 * @return {number}
 */
var trap = function(height) {
    const n = height.length, leftMax = [], rightMax = [];
    let count = 0;

    leftMax[0] = height[0];
    for(let i = 1; i < n; i++){
        leftMax[i] = Math.max(leftMax[i-1], height[i]);
    }

    rightMax[n-1] = height[n-1];
    for(let i = n-2; i >= 0; i--){
        rightMax[i] = Math.max(rightMax[i+1], height[i]);
    }

    for(let i = 1; i < n-1; i++){
        const bHeight = Math.min(leftMax[i], rightMax[i]);
        if(bHeight > height[i]){
            count += bHeight - height[i];
        }
    }

    return count;
};

var trap = function(height) {
    let count = 0;
    for(let i = 1; i < height.length - 1; i++){
        let left = i, right = i;
        
        let leftMax = 0;
        while(left >= 0){
            leftMax = Math.max(leftMax, height[left]);
            left--;
        }

        let rightMax = 0;
        while(right < height.length){
            rightMax = Math.max(rightMax, height[right]);
            right++;
        }

        count += Math.min(leftMax, rightMax) - height[i];
    }
    return count;
};