/**
 * @param {number[]} nums
 * @return {number[]}
 */
var sortArray = function(nums) {
    return counting(nums);
};

function mergesort(nums){
    const n = nums.length;
    if(n <= 1) return nums;
    const mid = Math.floor(n/2);

    const leftArr = new Array(mid), rightArr = new Array(n-mid);

    for(let i = 0; i < mid; i++){
        leftArr[i] = nums[i];
    }

    for(let i = 0; i < n-mid; i++){
        rightArr[i] = nums[i+mid];
    }

    const sortedLeft = mergesort(leftArr), sortedRight = mergesort(rightArr);

    return merge(sortedLeft, sortedRight);
}

function merge(left, right){
    const m = left.length, n = right.length;

    let i = 0, j = 0, k = 0;
    const result = new Array(m+n);

    while(i < m && j < n){
        if(left[i] < right[j]) result[k++] = left[i++];
        else result[k++] = right[j++];
    }

    while(i < m) result[k++] = left[i++];
    while(j < n) result[k++] = right[j++];

    return result;
}

function counting(nums){
    let n = nums.length, min = nums[0], max = nums[0];

    for(let i = 1; i < n; i++){
        max = Math.max(max, nums[i]);
        min = Math.min(min, nums[i]);
    }

    const range = max - min + 1;

    const freq = new Array(range).fill(0);

    for(let i = 0; i < n; i++){
        freq[nums[i]-min]++;
    }

    for(let i = 1; i < range; i++){
        freq[i] = freq[i] + freq[i-1];
    }
    const result = new Array(n);
    for(let i = n-1; i >= 0; i--){
        const position = freq[nums[i] - min];
        result[position-1] = nums[i];
        freq[nums[i] - min]--; // duplicates
    }

    return result;
}

function selection(nums){
    const n = nums.length;

    for(let i = 0; i < n; i++){
        let min = i; 
        for(let j = i + 1; j < n; j++){ 
            if(nums[j] < nums[min]) min = j;
        }
        swap(nums, min, i);
    }
    return nums;
}

function bubble(nums){
    const n = nums.length;
    for(let i = 0; i < n; i++){
        let isSwapped = false;
        for(let j = 0; j < n-1-i; j++){ // 0 to n-2
            if(nums[j] > nums[j+1]){
                isSwapped = true;
                swap(nums, j, j+1);
            } 
        }
        if(!isSwapped) break;
    }
    return nums;
}

function insertion(nums){
    const n = nums.length;
    for(let i = 1; i < n; i++){
        const key = nums[i];
        let j = i-1;
        while(j >= 0 && nums[j] > key){
            nums[j+1] = nums[j];
            j--;
        }
        nums[j+1] = key;
    }
    return nums;
}

function swap(nums, left, right){
    const temp = nums[left];
    nums[left] = nums[right];
    nums[right] = temp;
}
