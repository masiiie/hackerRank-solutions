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
 var sumNumbers = function(root) {
    return sumNumbersAux(root, []);  
};

var sumNumbersAux = function(root, path) {
   if(!root) return 0;
   if(!root.left && !root.right){
       let answer = root.val;
       for (let i = 0; i < path.length; i++) {
           answer += path[path.length - 1 - i] * Math.pow(10, i + 1);
       }
       return answer;
   }

   path.push(root.val);
   let s1 = sumNumbersAux(root.left, path);
   let s2 = sumNumbersAux(root.right, path);
   path.pop();
   return s1 + s2;
};