/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if (head == null)
        {
            return null;
        }

        ListNode slow = head;
        ListNode fast = head;

        // Step 1: Detect cycle
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast) // Cycle detected
            {
                // Step 2: Find the start of the cycle
                ListNode pointer = head;
                while (pointer != slow)
                {
                    pointer = pointer.next;
                    slow = slow.next;
                }
                return pointer; // Start of the cycle
            }
        }

        return null; // No cycle detected
    }
}