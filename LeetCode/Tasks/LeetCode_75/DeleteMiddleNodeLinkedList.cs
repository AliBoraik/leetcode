using LeetCode.Models;

namespace LeetCode.Tasks.LeetCode_75;

public class DeleteMiddleNodeLinkedList
{
    /*
     * You are given the head of a linked list. Delete the middle node, and return the head of the modified linked list.
       
       The middle node of a linked list of size n is the ⌊n / 2⌋th node from the start using 0-based indexing, 
       where ⌊x⌋ denotes the largest integer less than or equal to x.
       
       For n = 1, 2, 3, 4, and 5, the middle nodes are 0, 1, 1, 2, and 2, respectively.
     */
    public ListNode DeleteMiddle(ListNode head) {
        if(head == null)return null;
        ListNode prev = new ListNode();
        prev.next = head;
        ListNode slow = prev;
        ListNode fast = head;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        slow.next = slow.next.next;
        return prev.next;
    }
}