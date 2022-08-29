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
        
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        
        ListNode dummyNode = new ListNode();
        ListNode head = dummyNode;
        
        // While both lists have nodes, merge the smallest one
        while(list1 != null & list2 != null){
            ListNode smallestNode = null;
            if(list1.val <= list2.val){
                smallestNode = list1;
                list1 = list1.next;
            }
            else{
                smallestNode = list2;
                list2 = list2.next;
            }
            dummyNode.next = smallestNode;
            dummyNode = dummyNode.next;
        }
        
        // add leftover nodes if one of the lists was bigger than the other
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
        
        
        return head.next;
    }
}