using System;
using Xunit;
using StackAndQueue.Classes;

namespace TestStackAndQueue
{
    public class UnitTest1
    {
        [Fact]
        public void CreateStack()
        {
            Node node = new Node(10);
            Stack stack = new Stack(node);
            Assert.IsType<Stack>(stack);
        }

        [Fact]
        public void StackPush()
        {
            Node node = new Node(10);
            Stack stack = new Stack(node);
            stack.Push(100);
            Assert.Equal(100, stack.Top.Value);
        }

        [Fact]
        public void StackPop()
        {
            Node node = new Node(10);
            Stack stack = new Stack(node);
            stack.Push(100);
            stack.Push(1000);
            stack.Push(1);
            stack.Pop();
            Assert.Equal(1000, stack.Top.Value);
        }

        [Fact]
        public void StackPeek()
        {
            Node node = new Node(10);
            Stack stack = new Stack(node);
            stack.Push(100);
            Node peek = stack.Peek();
            Assert.IsType<Node>(peek);
        }

        [Fact]
        public void CreateQueue()
        {
            Node node = new Node(10);
            Queue queue = new Queue(node);
            Assert.IsType<Queue>(queue);
        }

        [Fact]
        public void QueueEnqueue()
        {
            Node node = new Node(10);
            Queue q = new Queue(node);
            q.Enqueue(100);
            Assert.Equal(100, q.Rear.Value);
        }

        [Fact]
        public void QueueDequeue()
        {
            Node node = new Node(10);
            Queue q = new Queue(node);
            q.Enqueue(100);
            q.Enqueue(1);
            Node output = q.Dequeue();
            Assert.Equal(100, q.Front.Value);
        }

        [Fact]
        public void QueuePeek()
        {
            Node node = new Node(10);
            Queue q = new Queue(node);
            q.Enqueue(100);
            q.Enqueue(1);
            Node output = q.Peek();
            Assert.Equal(10, output.Value);
        }
    }
}
