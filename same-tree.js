/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} p
 * @param {TreeNode} q
 * @return {boolean}
 */
 var isSameTree = function(p, q) {
    let n1 = p == null
    let n2 = q == null
    
    if(n1 && n2) return true
    if(n1 ^ n2) return false
    if(p.val != q.val) return false
    
    let queue1 = [p]
    let queue2 = [q]
    
    while(queue1.length > 0 && queue1.length == queue2.length){
        var c1 = queue1.shift();
        var c2 = queue2.shift();
        
        let cl1 = c1.left != null
        let cl2 = c2.left != null
        
        let cr1 = c1.right != null
        let cr2 = c2.right != null
        
        if(cl1 && cl2 && c1.left.val != c2.left.val) return false
        else if(cl1 ^ cl2) return false
        else if(cl1 && cl2){
            queue1.push(c1.left)
            queue2.push(c2.left)
        }
        
        if(cr1 && cr2 && c1.right.val != c2.right.val) return false
        else if(cr1 ^ cr2) return false
        else if(cr1 && cr2){
            queue1.push(c1.right)
            queue2.push(c2.right)
        }
        
    }
    
    return queue1.length + queue2.length == 0
};