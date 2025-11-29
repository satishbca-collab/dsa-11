class Solution {
    public int findUnique(int[] arr) {
        // code here
        Arrays.sort(arr);
        
        int left = 0, right = arr.length-1;
        while(left < right){
            int mid = left + (right - left) / 2;
            if(arr[mid] == arr[mid^1]){
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        return arr[left];
    }
}