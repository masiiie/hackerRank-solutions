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
 * @return {string[]}
 */
 var binaryTreePaths = function(root) {
    if(root == null || root == undefined) return []
    if(root.left==null && root.right==null) return [`${root.val}`]
    
    let pathsLeft = binaryTreePaths(root.left)
    let pathsRight = binaryTreePaths(root.right)
    let paths = pathsLeft.concat(pathsRight)
    for (let i = 0; i < paths.length; i++) {
        paths[i] =  `${root.val}->${paths[i]}`
    }
    return paths
};