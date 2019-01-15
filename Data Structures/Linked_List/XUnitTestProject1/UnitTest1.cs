using System;
using Xunit;
using Linked_List;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        public void TestIncludesTrue(int number)
        {
            LinkedList ll = new LinkedList();
            ll.Insert(number);
            bool isTrue = ll.Includes(number);
            Assert.True(isTrue);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        public void TestIncludesFalse(int number)
        {
            LinkedList ll = new LinkedList();
            ll.Insert(2);
            ll.Insert(14);
            ll.Insert(26);
            ll.Insert(38);
            bool isFalse = ll.Includes(number);
            Assert.False(isFalse);
        }

        [Fact]
        public void TestAppendSuccess()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(16);
            list.Append(3);
            bool isTrue = list.Includes(3);
            Assert.True(isTrue);
        }

        [Fact]
        public void TestAppendFail()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(16);
            list.Append(3);
            bool isFalse = list.Includes(10);
            Assert.False(isFalse);
        }

        [Fact]
        public void TestInsertBeforeSuccess()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(16);
            list.InsertBefore(16, 3);
            bool isTrue = list.Includes(3);
            Assert.True(isTrue);
        }

        [Fact]
        public void TestInsertAfterSuccess()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(16);
            list.InsertAfter(16, 3);
            bool isTrue = list.Includes(3);
            Assert.True(isTrue);
        }




    }
}
