using System;
using Xunit;
using ll_kth_from_end;
using Linked_List;

namespace TestKth
{
    public class UnitTest1
    {
        [Fact]
        public void TestForTen()
        {
            LinkedList ll = new LinkedList();
            ll.Insert(1);
            ll.Insert(10);
            ll.Insert(100);
            ll.Insert(1000);
            Assert.Equal(10, ll_kth_from_end.Program.LLFromEnd(1, ll));

        }

        [Fact]
        public void TestForOutOfRange()
        {
            LinkedList ll = new LinkedList();
            ll.Insert(1);
            ll.Insert(10);
            ll.Insert(100);
            ll.Insert(1000);
            Assert.Equal(-1, ll_kth_from_end.Program.LLFromEnd(10, ll));

        }

        [Fact]
        public void TestForThousand()
        {
            LinkedList ll = new LinkedList();
            ll.Insert(1);
            ll.Insert(10);
            ll.Insert(100);
            ll.Insert(1000);
            Assert.Equal(1000, ll_kth_from_end.Program.LLFromEnd(3, ll));

        }

        [Fact]
        public void TestForOne()
        {
            LinkedList ll = new LinkedList();
            ll.Insert(1);
            ll.Insert(10);
            ll.Insert(100);
            ll.Insert(1000);
            Assert.Equal(1, ll_kth_from_end.Program.LLFromEnd(0, ll));

        }
    }
}
