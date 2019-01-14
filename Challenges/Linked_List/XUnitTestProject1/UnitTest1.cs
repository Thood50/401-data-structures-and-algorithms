using System;
using Xunit;
using Linked_List;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private const bool V = false;

        [Fact]
        public void Test1()
        {
            Assert.Equal(V, Includes(4));
        }

        private IEnumerable<object> Includes(int v)
        {
            throw new NotImplementedException();
        }
    }
}
