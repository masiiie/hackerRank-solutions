/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode[]} lists
 * @return {ListNode}
 */
 var mergeKLists = function(lists) {
    if(lists.length == 0) return new ListNode()
    if(lists.length == 1) return lists[0]

    let N = Math.trunc(lists.length/2) 
    let p1 = mergeKLists(lists.slice(0, N))
    let p2 = mergeKLists(lists.slice(N))

    return merge(p1, p2)
};


var merge = function(l1, l2){
    let sol = new ListNode()
    let solHead = sol

    while(l1 && l2){
        if(l1.val < l2.val){
            solHead.val = l1.val
            l1 = l1.next
        }
        else{
            solHead.val = l2.val
            l2 = l2.next
        }

        solHead.next = new ListNode()
        solHead = solHead.next
    }
    
    if(l1) solHead = l1
    if(l2) solHead = l2

    return sol
}