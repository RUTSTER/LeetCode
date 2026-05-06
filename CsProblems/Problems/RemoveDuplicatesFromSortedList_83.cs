namespace CsProblems.Problems;

internal class RemoveDuplicatesFromSortedList_83
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        var current = head;

        while (current?.next is not null)
        {
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }

    public void Test()
    {
        var list = ListNode.FromArr([10, 10, 20, 30, 30]);

        var res = DeleteDuplicates(list);

        var curr = list;
        while (curr is not null)
        {
            Console.WriteLine(curr.val);
            curr = curr.next;
        }

        Console.WriteLine();
    }
}

public class ListNode
{
    public int id;
    public int val;
    public ListNode? next;

    public ListNode(int id, int val = 0, ListNode? next = null)
    {
        this.id = id;
        this.val = val;
        this.next = next;
    }

    public static ListNode? FromArr(int[] arr)
    {
        ListNode? list = null;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            list = new ListNode(i, arr[i], list);
        }

        return list;
    }
}