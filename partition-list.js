/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} x
 * @return {ListNode}
 */
 var partition = function(head, x) {
    let greaterThanHead = null
    let greaterThan = new ListNode()
    let prev = null
    let lessThan = head

    while (lessThan) {
        if(lessThan.val >= x){
            greaterThan.val = lessThan.val
            greaterThan.next = new ListNode(0, null)
            if(greaterThanHead == null) greaterThanHead = greaterThan
            greaterThan = greaterThan.next

            if(prev != null) prev.next = prev.next.next 
        }
        else if(lessThan.val < x){
            if(prev == null) head = lessThan
            prev = lessThan
        }
        lessThan = lessThan.next
    }
    if(prev != null) prev.next = greaterThanHead
    return head
};