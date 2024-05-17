using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class MergeTwoSortedLists_21
    {
        public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            if (list1 is null || list2 is null)
            {
                return list1 ?? list2;
            }

            var dummy = new ListNode();
            var current = dummy;

            while (list1 is not null && list2 is not null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }

            current.next = list1 ?? list2;

            return dummy.next;
        }

        public void Test()
        {
            var list1 = new ListNode(1,
                            new ListNode(2,
                                new ListNode(4,
                                    new ListNode(8, null)
                                    )
                                )
                            );

            var list2 = new ListNode(1,
                            new ListNode(3,
                                new ListNode(4,
                                    new ListNode(7, null)
                                    )
                                )
                            );

            var res = MergeTwoLists(list1, list2);

            Console.WriteLine();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
