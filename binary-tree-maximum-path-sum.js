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
 * @return {number}
 */
 var maxPathSum = function(root) {
    let max = [-1000];


    var maxPathSumAux = function(root) {
        if(!root) return 0;
    
        let p1 = Math.max(maxPathSumAux(root.left), 0);
        let p2 = Math.max(maxPathSumAux(root.right), 0);
        let maxCurr = Math.max(p1, p2) + root.val;
        max[0] = Math.max(p1 + p2 + root.val, max[0]);
        return maxCurr;
    };

    maxPathSumAux(root, max);
    return max[0];
};