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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null) return null;
        if (lists.Length == 0) return null;
        if (lists.Length == 1) return lists[0];

        ListNode[] listsPointers = new ListNode[lists.Length];
        for (var listIndex = 0; listIndex < lists.Length; listIndex++)
        {
            if (lists[listIndex] != null)
            {
                listsPointers[listIndex] = new ListNode(lists[listIndex].val, lists[listIndex].next);
            }
        }

        ListNode result = null, localResult = null;

        while (true)
        {
            var minIndex = 0;
            var minValue = int.MaxValue;
            for (var listIndex = 0; listIndex < listsPointers.Length; listIndex++)
            {
                if (listsPointers[listIndex] != null && listsPointers[listIndex].val < minValue)
                {
                    minIndex = listIndex;
                    minValue = listsPointers[listIndex].val;
                }
            }

            if (minValue == int.MaxValue) return result;

            if (result == null)
            {
                result = new ListNode(listsPointers[minIndex].val);
                localResult = result;
            }
            else
            {
                localResult.next = new ListNode(listsPointers[minIndex].val);
                localResult = localResult.next;
            }
            if (listsPointers[minIndex] != null) listsPointers[minIndex] = listsPointers[minIndex].next;
        }
    }
}