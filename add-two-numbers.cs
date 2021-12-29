// https://leetcode.com/problems/add-two-numbers/

/**
 * Definition for singly-linked list.
 * 
 */

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        ListNode l1 = new ListNode(7, 
            new ListNode(8,
                new ListNode(7)));
        ListNode l3 = new ListNode(9);
        ListNode l2 = new ListNode(1, 
            new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(9,
                                new ListNode(9,
                                    new ListNode(9,
                                        new ListNode(9,
                                            new ListNode(9))))
                                ))))));

        // 787 + 913 = 1700
        ListNode sum = sol.AddTwoNumbers(l3,l2);
        while(sum!=null){
            Console.Write(sum.val);
            sum=sum.next;
        }
    }
}

public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
         this.next = next;
      }
  }

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode solution = new ListNode(0);
        ListNode solutionIndex = solution;
        int carry = 0;
        int s = 0;

        while(l1 != null | l2 != null){
            if(l1 == null ){
                s = l2.val + carry;
                l2 = l2.next;
            }
            else if(l2 == null){
                s = l1.val + carry;
                l1 = l1.next;
            }
            else{
                s = l1.val + l2.val + carry;
                l1 = l1.next;
                l2 = l2.next;
            }

            if(s>9){
                carry = 1;
                s = s - 10;
            }
            else carry = 0; 

            solutionIndex.val = s;
            solutionIndex.next = new ListNode(0);
            solutionIndex = solutionIndex.next;
        }

      

        if(carry==0) solutionIndex = null;
        else solutionIndex.val = carry;

        return solution;
    }
}