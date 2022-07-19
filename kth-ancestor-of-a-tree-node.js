/**
 * @param {number} n
 * @param {number[]} parent
 */
 var TreeAncestor = function(n, parent) {
    this.parent = parent
    this.n = n
};

/** 
 * @param {number} node 
 * @param {number} k
 * @return {number}
 */
TreeAncestor.prototype.getKthAncestor = function(node, k) {
    let sol = -1
    let index = node

    while(k > 0 && index > -1){
        sol = this.parent[index]
        index = sol
        k--
    }

    return sol;
};

/** 
 * Your TreeAncestor object will be instantiated and called as such:
 * var obj = new TreeAncestor(n, parent)
 * var param_1 = obj.getKthAncestor(node,k)
 */