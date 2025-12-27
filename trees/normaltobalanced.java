/*
class Node
{
    int data;
    Node right, left;
    Node(int item)
    {
        data = item;
        left = right = null;
    }
}*/

class Solution {
    Node balanceBST(Node root) {
        // Add your code here.
        ArrayList<Integer> list = new ArrayList<>();
        inorder(root, list);
        int[] arr = list.stream().mapToInt(i -> i).toArray();
        
        return helper(arr, 0, arr.length-1);
    }
    
    private void inorder(Node root, List<Integer> list){
        if(root == null) return;
        
        inorder(root.left, list);
        list.add(root.data);
        inorder(root.right, list);
    }
    
    private Node helper(int[] nums, int low, int high){
        if(low > high) return null;
        
        int mid = low + (high-low)/2;
        Node root = new Node(nums[mid]);
        
        root.left = helper(nums, low, mid-1);
        root.right = helper(nums, mid+1, high);
        
        return root;
    }
}