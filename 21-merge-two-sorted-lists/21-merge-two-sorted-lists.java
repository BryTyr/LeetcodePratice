/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        // edge cases
        if(list1 == null)
            return list2;
        if(list2 == null)
            return list1;
        
        ListNode dummyNode = new ListNode();
        ListNode newHead = list1.val <= list2.val ? list1 : list2;
        
        // while both lists not empty, sort by smallest
        while(list1 != null & list2 != null){
            if(list1.val <= list2.val){
                dummyNode.next = list1;
                list1 = list1.next;
            }
            else{
                dummyNode.next = list2;
                list2 = list2.next;
            }
            
            dummyNode = dummyNode.next;
        }
        
        // check for leftover nodes
        while(list1 != null){
            dummyNode.next = list1;
            dummyNode = dummyNode.next;
            list1 = list1.next;
        }
        
        while(list2 != null){
            dummyNode.next = list2;
            dummyNode = dummyNode.next;
            list2 = list2.next;
        }
        
        return newHead;
    }
}