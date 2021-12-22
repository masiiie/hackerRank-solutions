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
        Stack<ListNode> stack = new Stack<ListNode>();
        ListNode last = head;
        while(last.next != null){
            stack.Push(last);
            last = last.next;
        }

        ListNode actualHead = head;
        while(true){
            if(actualHead == stack.Peek()){
                actualHead.next = null;
                break;
            }

            ListNode temp = actualHead.next;
            ListNode top = stack.Pop(); 

            if(actualHead.next == top){
                top.next = null;
                break;
            }

            actualHead.next = top;
            top.next = temp;
            actualHead = temp;
        }
    }
}