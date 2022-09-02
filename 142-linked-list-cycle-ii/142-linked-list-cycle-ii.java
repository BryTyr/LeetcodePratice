/**
 * Definition for singly-linked list.
 * class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode detectCycle(ListNode head) {
        
        if(head == null || head.next == null)
            return null;
        
        ListNode slowPointer = head, fastPointer = head;
        
        do {
            if(fastPointer == null || fastPointer.next == null) return null;
            fastPointer = fastPointer.next.next;
            slowPointer = slowPointer.next;
        } while(slowPointer != fastPointer);
        
        // next find the cycle start
        ListNode currNode = head;
        
        while(currNode != slowPointer){
            slowPointer = slowPointer.next;
            currNode = currNode.next;
        }
        
        
        return currNode;
    }
}