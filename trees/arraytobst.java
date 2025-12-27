// User function Template for Java

class Solution {
    public Node sortedArrayToBST(int[] nums) {
        // Code here
        return helper(nums, 0, nums.length-1);
    }
    
    private Node helper(int[] nums, int low, int high){
        if(low > high) return null;
        
        int mid = low + (high-low)/2;
        Node head = new Node(nums[mid]);
        head.left = helper(nums, low, mid-1);
        head.right = helper(nums, mid+1, high);
        
        return head;
    }
}