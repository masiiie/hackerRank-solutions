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
 * @return {number[][]}
 */
 var pathSum = function(root, targetSum) {
    let paths = [];
    var pathSumAux = function(root, currPath, sum) {
        if(!root) return;
        if(!root.left && !root.right){
            if(sum + root.val == targetSum) paths.push(currPath.concat([root.val]));
        }
        else{
            currPath.push(root.val);
            pathSumAux(root.left, currPath, sum + root.val);
            pathSumAux(root.right, currPath, sum + root.val);
            currPath.pop();
        }
    };

    pathSumAux(root, [], 0);  
    return paths;  
};