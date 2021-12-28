/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode middle = head;
        int count = 0;
        while(head != null){
            if(count%2 == 1){
                middle = middle.next;
            }
            count+=1;
            head = head.next;
        }
        return middle;
    }
}