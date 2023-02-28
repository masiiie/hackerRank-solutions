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
 * @return {TreeNode[]}
 */
var findDuplicateSubtrees = function(root) {
    let frecuencies = {};
    let duplicates = [];

    auxFun(root, frecuencies, duplicates);

    return duplicates;
};


var auxFun = function(tree, frecs, dupl) {
    if(tree == null) return '#';
    let left = auxFun(tree.left, frecs, dupl);
    let right = auxFun(tree.right, frecs, dupl);

    let serialization = left + ',' + right + ',' + tree.val;
    
    if(serialization in frecs && frecs[serialization] == 1) {
        dupl.push(tree);
        frecs[serialization]++;
    } else frecs[serialization] = 1;

    return serialization;
}