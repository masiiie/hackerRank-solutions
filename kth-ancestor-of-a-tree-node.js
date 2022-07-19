/**
 * @param {number} n
 * @param {number[]} parent
 */
 var TreeAncestor = function(n, parent) {
    this.parent = parent
    this.n = n
    this.ancestors = new Array(n).fill(0).map(() => new Array(n).fill(0));
};

/** 
 * @param {number} node 
 * @param {number} k
 * @return {number}
 */
TreeAncestor.prototype.getKthAncestor = function(node, k) {
    if(this.ancestors[(node, k)] != undefined) return this.ancestors[(node, k)]
    let sol = -1
    let index = node
    let i = 0

    while(i < k){
        if(this.ancestors[(node, k)] != undefined) return this.ancestors[(node, k)]
        sol = this.parent[index]
        if(sol === -1) return -1
        index = sol
        i++
        if(this.ancestors[(node, i)] != undefined) return this.ancestors[(node, i)]
    }

    return sol;
};

/** 
 * Your TreeAncestor object will be instantiated and called as such:
 * var obj = new TreeAncestor(n, parent)
 * var param_1 = obj.getKthAncestor(node,k)
 */