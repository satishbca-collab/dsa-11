/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
        return Helper(root, null, null);
    }

    private bool Helper(TreeNode root, int? min, int? max){
        if(root == null) return true;

        if((min != null && root.val <= min) || (max != null && root.val >= max)) return false;

        return Helper(root.left, min, root.val) && Helper(root.right, root.val, max);
    }
}