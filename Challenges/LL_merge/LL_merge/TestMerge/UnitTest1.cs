using System;
using Xunit;
using Linked_List;
using ll_kth_from_end;
using LL_merge;

namespace TestMerge
{
    public class UnitTest1
    {
        [Fact]
        public void TestIfLL2IsInLL1()
        {
            LinkedList LL1 = new LinkedList();
            LL1.Insert(100);
            LL1.Insert(200);
            LL1.Insert(300);
            LL1.Insert(400);

            LinkedList LL2 = new LinkedList();
            LL2.Insert(10);
            LL2.Insert(20);

            LL1 = LL_merge.Program.MergeLL(LL1, LL2);
            bool isTrue = LL1.Includes(10);
            Assert.True(isTrue);
        }

        [Fact]
        public void TestIfLL1HasNewLength()
        {
            LinkedList LL1 = new LinkedList();
            LL1.Insert(100);
            LL1.Insert(200);
            LL1.Insert(300);
            LL1.Insert(400);

            LinkedList LL2 = new LinkedList();
            LL2.Insert(10);
            LL2.Insert(20);

            Node C1 = LL1.Head;
            Node C2 = LL2.Head;
            int L1 = 1;
            int L2 = 1;

            while ((C1.Next != null) || (C2.Next != null))
            {
                if (C1.Next != null)
                {
                    L1++;
                    C1 = C1.Next;
                }
                if (C2.Next != null)
                {
                    L2++;
                    C2 = C2.Next;
                }
            }

            LL1 = LL_merge.Program.MergeLL(LL1, LL2);
            C1 = LL1.Head;

            int Length = L1 + L2;
            int ActualLength = 1;

            while (C1.Next != null)
            {
                ActualLength++;
                C1 = C1.Next;
            }

            Assert.Equal(Length, ActualLength);

        }

        [Fact]
        public void TestIfProperLastNode()
        {
            LinkedList LL1 = new LinkedList();
            LL1.Insert(100);
            LL1.Insert(200);
            LL1.Insert(300);
            LL1.Insert(400);

            LinkedList LL2 = new LinkedList();
            LL2.Insert(10);
            LL2.Insert(20);

            Node C1 = LL1.Head;
            Node C2 = LL2.Head;
            int L1 = 1;
            int L2 = 1;

            while ((C1.Next != null) || (C2.Next != null))
            {
                if (C1.Next != null)
                {
                    L1++;
                    C1 = C1.Next;
                }
                if (C2.Next != null)
                {
                    L2++;
                    C2 = C2.Next;
                }
            }

            LL1 = LL_merge.Program.MergeLL(LL1, LL2);
            C1 = LL1.Head;

            int output = ll_kth_from_end.Program.LLFromEnd(0, LL1);

            Assert.Equal(100, output);

        }
    }
}
