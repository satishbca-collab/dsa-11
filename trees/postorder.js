/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var postorderTraversal = function(root) {
    var result = [];
    helper(root, result);
    return result;
};

function helper(root, result){
    if(root == null) return;
    helper(root.left, result);
    helper(root.right, result);
    result.push(root.val);
}