// https://leetcode.com/problems/linked-list-random-node/

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

    ListNode listNode;
    Random rnd;

    public Solution(ListNode head) {
        listNode = head;
        rnd = new Random();
    }
    
    public int GetRandom() {
        ListNode actual = listNode;
        int sol = actual.val;
        int index = 1;
        
        while(actual!=null){
            int random  = rnd.Next(0, index);
            if(random==0) sol=actual.val;
            actual=actual.next;
            index++;
        }
        return sol;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */