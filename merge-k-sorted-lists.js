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
    let heap = []; // ver como es esto
    let sol = new ListNode()
    let solHead = sol

    for (let i = 0; i < lists.length; i++) {
        if(lists[i] != null) heap.push((lists[i].val, i));
    }

    while(heap.length > 0){
        let current = heap.pop()
        solHead.val = current[0]
        solHead.next = new ListNode()
        solHead = solHead.next

        const idx = current[1]
        lists[idx] = lists[idx].next
        if(lists[idx] != null) heap.push((lists[idx].val, idx))
    }

    solHead.next= null
    return sol
};