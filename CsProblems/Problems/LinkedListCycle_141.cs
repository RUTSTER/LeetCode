using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class LinkedListCycle_141
    {
        public bool HasCycle(ListNode head)
        {
            var dummy = new ListNode();

            while (true)
            {
                if (head is null)
                {
                    return false;
                }

                if (head == dummy)
                {
                    return true;
                }

                var current = head;
                head = head.next;
                current.next = dummy;
            }
        }

        public void Test()
        {
            var middleNode = new ListNode(2, null);

            var list = new ListNode(1, middleNode);
            middleNode.next = new ListNode(2,
                                new ListNode(4,
                                    new ListNode(8, middleNode)
                                )

                            );

            var res = HasCycle(list);

            Console.WriteLine();
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
}
