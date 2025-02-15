using System;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class ReverseLinkedListProgram
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        while (current != null)
        {
            ListNode nextTemp = current.next;
            current.next = prev;
            prev = current;
            current = nextTemp;
        }
        return prev;
    }

    public static void Main()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode reversed = ReverseList(head);

        while (reversed != null)
        {
            if (reversed.next != null)
                Console.Write(reversed.val + " -> ");
            else
                Console.Write(reversed.val);
            reversed = reversed.next;
        }
    }
}
