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
 * @param {number} targetSum
 * @return {boolean}
 */
 var hasPathSum = function(root, targetSum) { 
    var hasPathSumAux = function(root, current) {
        if(!root) return false;
        if(!root.left && !root.right) return current + root.val == targetSum;
    
        let p1 = hasPathSumAux(root.left, current + root.val);
        let p2 = hasPathSumAux(root.right, current + root.val);
        return p1 || p2;
    };

    return hasPathSumAux(root, 0);
};