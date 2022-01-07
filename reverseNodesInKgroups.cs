/** Given the head of a linked list, reverse the nodes of the list k at a time, and return the modified list.
* 
* k is a positive integer and is less than or equal to the length of the linked list. If the number of nodes is not a multiple of k then left-out nodes, in * the end, should remain as it is.
* 
* You may not alter the values in the list's nodes, only nodes themselves may be changed.
* 
*  
* 
* Example 1:
* 
* 
* Input: head = [1,2,3,4,5], k = 2
* Output: [2,1,4,3,5]
* Example 2:
* 
* 
* Input: head = [1,2,3,4,5], k = 3
* Output: [3,2,1,4,5]
*  
* 
* Constraints:
* 
* The number of nodes in the list is n.
* 1 <= k <= n <= 5000
* 0 <= Node.val <= 1000
* 
* 
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        (ListNode, ListNode) ReverseKConnectionsAndGetNewHead(System.Collections.Generic.Stack<ListNode> s, ListNode linkPrevGroup, ListNode linkNextGroup)
        {
            ListNode localHead = null, newHead = null;
            while (s.Count > 0)
            {
                var item = s.Pop();
                if (localHead == null)
                {
                    newHead = item;
                    if (linkPrevGroup != null) linkPrevGroup.next = newHead;
                    localHead = item;
                }
                else
                {
                    localHead.next = item;
                    localHead = item;
                }
            }

            localHead.next = linkNextGroup;
            return (newHead, localHead);
        }

        if (head == null || head.next == null) return head;
        if (k == 1) return head;
        var originalK = k;
        var stack = new System.Collections.Generic.Stack<ListNode>();
        ListNode newHead = null, lastItemOfGroup = null;
        while (head != null)
            {
            if (k == 0)
            {
                k = originalK;
                var (firstNodeInGroup, lastNodeInGroup) = ReverseKConnectionsAndGetNewHead(stack, lastItemOfGroup, head);
                lastItemOfGroup = lastNodeInGroup;
                if (newHead == null) newHead = firstNodeInGroup;
            }
            else
            {
                k--;
                stack.Push(head);
                head = head.next;
            }
        }
        if (k == 0)
        {
            var (first, _) = ReverseKConnectionsAndGetNewHead(stack, lastItemOfGroup, head);
            if (newHead == null) newHead = first;
        }
        return newHead;


    }
}