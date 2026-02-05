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
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null) {
            return head; // Base case: list is already sorted
        }

        // Step 1: Split the list into two halves
        ListNode middle = GetMiddle(head);
        ListNode left = head;
        ListNode right = middle.next;
        middle.next = null; // Break the list into two halves

        // Step 2: Recursively sort both halves
        left = SortList(left);
        right = SortList(right);

        // Step 3: Merge the sorted halves
        return Merge(left, right);
    }

    private ListNode GetMiddle(ListNode head) {
        ListNode slow = head, fast = head;
        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow; // Returns the middle node
    }

    private ListNode Merge(ListNode left, ListNode right) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (left != null && right != null) {
            if (left.val <= right.val) {
                current.next = left;
                left = left.next;
            } else {
                current.next = right;
                right = right.next;
            }
            current = current.next;
        }

        // Append any remaining nodes
        current.next = (left != null) ? left : right;

        return dummy.next;
    }
}