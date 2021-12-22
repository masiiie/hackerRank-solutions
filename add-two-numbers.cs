// https://leetcode.com/problems/add-two-numbers/

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int number1 = 0;
        int number2 = 0;

        for(int i = 0; i < 100; i++){
            if(l1 == null && l2 == null) break;
            if(l1 != null ){
                number1 += l1.val*Math.Pow(10,i);
                l1 = l1.next;
            }
            if(l2 != null){
                number2 += l2.val*Math.Pow(10,i);
                l2 = l2.next;
            }
        }
    }
}