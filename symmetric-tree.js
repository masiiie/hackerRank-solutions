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
 * @return {boolean}
 */
 var isSymmetric = function(root) {
    if(root == null) return true
    var queue = [root.left, root.right]
    let N = 1
    let next = 0
    
    while(queue.length > 0 && N > 0){
        let n = Math.pow(2, N)
        console.log(`n: ${n}        queue: ${queue}`)
        for(let i = 0; i < n; i++){
            if(i < n/2){
                let q1 = queue[0] != null
                let q2 = queue[n - i - 1] != null
                if(q1 ^ q2) return false
                if(q1 && q2 && queue[0].val != queue[n - i - 1].val) {
                    console.log(`q1: ${queue[0].val}  q2: ${queue[n - i - 1].val}`)
                    return false
                }
            }
            
            if(queue[0]!=null){
                if(queue[0].left != null) next++
                if(queue[0].right != null) next++
                queue.push(queue[0].left)
                queue.push(queue[0].right)
            }
            
            queue.shift();
        }
        
        N = next 
        next = 0
    }
    
    return queue.length == 0
};