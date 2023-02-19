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
 * @return {number[][]}
 */
var zigzagLevelOrder = function(root) {
    if(root == 0 || root == null) return []
    if(root.left == null && root.right == null) return [[root.val]]

    let orderLeft = zigzagLevelOrder(root.left)
    let orderRight = zigzagLevelOrder(root.right)

    let sol = [[root.val]];

    let deep = 0;  // Las deep pares son de izquierda a derecha y las impares son de derecha a izquierda
    
    while(orderLeft.length > 0 || orderRight.length > 0) {
        let o1 = orderLeft.length == 0 ? [] : orderLeft[0];
        let o2 = orderRight.length == 0 ? [] : orderRight[0]; 

        if(deep%2 == 0) {
            sol.push(o2.reverse().concat(o1.reverse()))
        } else {
            sol.push(o1.reverse().concat(o2.reverse()))
        }

        orderLeft.shift();
        orderRight.shift();

        deep++
    }

    return sol;
};