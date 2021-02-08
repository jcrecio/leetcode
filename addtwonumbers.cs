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
        ListNode result = new ListNode(0);
        ListNode current = result;

        do
        {
            var sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + current.val;
            current.val = sum >= 10 ? GetUnits(sum) : sum;

            if ((l1 != null && l1.next != null) || (l2 != null && l2.next != null))
            {
                current.next = new ListNode(sum >= 10 ? 1 : 0);
                current = current.next;
            }
            else if (sum >= 10) current.next = new ListNode(1);

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        while (l1 != null || l2 != null);
        return result;
    }
    
    public int GetUnits(int number){
            var numberString = number.ToString();
            return Int32.Parse(numberString.Substring(numberString.Length - 1));
    }
}