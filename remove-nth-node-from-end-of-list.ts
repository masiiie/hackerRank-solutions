class ListNode {
    val: number
    next: ListNode | null
    constructor(val?: number, next?: ListNode | null) {
        this.val = (val===undefined ? 0 : val)
        this.next = (next===undefined ? null : next)
    }
}

function removeNthFromEnd(head: ListNode | null, n: number): ListNode | null {
    if(head==null) return null;
    var current = head;
    var parentOfToDelete = head;
    let i = n;
    while(i>0 && current!=null){
        current=current.next;
        i--;
    }

    if(current==null) return head.next;

    while(current.next!=null){
        parentOfToDelete = parentOfToDelete.next;      
        current = current.next;
    }

    parentOfToDelete.next = parentOfToDelete.next.next;

    return head;
};