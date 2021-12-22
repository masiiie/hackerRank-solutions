// https://leetcode.com/problems/reorder-list/

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
    public void ReorderList(ListNode head) {
        if(head.next == null) return head;
    }

    public void auxiliarReorder(ListNode head){

    }

    public void recursiveReorder(ListNode first, ListNode last)
    {
        ListNode temp = first.next;
        first.next = last;
        last.next = temp;
        return recursiveReorder()
    }
}