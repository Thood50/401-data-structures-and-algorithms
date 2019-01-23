using System;
using Xunit;
using StackAndQueue.Classes;
using QueueWithStacks.Classes;

namespace TestQueueWithStacks
{
    public class UnitTest1
    {
        [Fact]
        public void TestPeekWithPop()
        {
            PseudoQueue QS = new PseudoQueue();
            QS.Enqueue(10);
            Node result = QS.Peek();
            Assert.Equal(10, result.Value);
        }

        [Fact]
        public void TestPeekNoPop()
        {
            PseudoQueue QS = new PseudoQueue();
            Node result = QS.Peek();
            Assert.Null(result);
        }

        [Fact]
        public void TestEnqueueNull()
        {
            PseudoQueue QS = new PseudoQueue();
            Node results = QS.Peek();
            Assert.Null(results);
        }

        [Fact]
        public void TestEnqueueFirstNode()
        {
            PseudoQueue QS = new PseudoQueue();
            QS.Enqueue(10);
            Node results = QS.Peek();
            Assert.Equal(10, results.Value);
        }

        [Fact]
        public void TestEnqueueThirdNode()
        {
            PseudoQueue QS = new PseudoQueue();
            QS.Enqueue(10);
            QS.Enqueue(100);
            QS.Enqueue(1);
            QS.Dequeue();
            QS.Dequeue();
            Node results = QS.Peek();
            Assert.Equal(1, results.Value);
        }

        [Fact]
        public void TestDequeueFirstDump()
        {
            PseudoQueue QS = new PseudoQueue();
            QS.Enqueue(10);
            QS.Enqueue(100);
            QS.Enqueue(1);

            Node results = QS.Dequeue();
            Assert.Equal(10, results.Value);
        }

        [Fact]
        public void TestDequeueSecondDump()
        {
            PseudoQueue QS = new PseudoQueue();
            QS.Enqueue(10);
            QS.Enqueue(100);
            QS.Enqueue(1);
            QS.Dequeue();
            QS.Enqueue(1000);
            QS.Dequeue();
            QS.Dequeue();
            Node results = QS.Dequeue();
            Assert.Equal(1000, results.Value);

        }

        [Fact]
        public void TestDequeueNull()
        {
            PseudoQueue QS = new PseudoQueue();
            QS.Enqueue(10);
            QS.Enqueue(100);
            QS.Enqueue(1);
            QS.Dequeue();
            QS.Dequeue();
            QS.Dequeue();
            Node results = QS.Peek();
            Assert.Null(results);
        }
    }
}
