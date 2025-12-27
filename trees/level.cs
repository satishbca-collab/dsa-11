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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if(root == null) return result;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            int n = q.Count;
            var curResult = new List<int>();
            for(int i = 0; i < n; i++){
                TreeNode cur = q.Dequeue();
                curResult.Add(cur.val);
                if(cur.left != null) q.Enqueue(cur.left);
                if(cur.right != null) q.Enqueue(cur.right);
            }
            result.Add(curResult);
        }

        return result;
    }
}
/*
n   curResult   cur     result                  q       i
1   [3]          3       [[3]]                  [9,20]  1
2   [9]          9       [[3]]                  [20]    0
2   [9,20]       20      [[3]]                  [15,7]  2
2   [15]         15      [[3],[9,20]]           [7]     0
2   [15,7]       7       [[3],[9,20],[15,7]]    []      2
*/