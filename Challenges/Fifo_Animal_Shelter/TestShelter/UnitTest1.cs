using System;
using Xunit;
using Fifo_Animal_Shelter;
using Fifo_Animal_Shelter.Classes;

namespace TestShelter
{
    public class UnitTest1
    {
        [Fact]
        public void TestQueueEnqueue()
        {
            Animal cat = new Cat();
            Animal cat1 = new Cat();
            Animal cat2 = new Cat();
            Animal cat3 = new Cat();
            Animal cat4 = new Cat();
            ShelterNode node = new ShelterNode(cat, 1);
            Queue Q = new Queue(node);
            Q.Enqueue(cat1, 2);
            Q.Enqueue(cat2, 3);
            Q.Enqueue(cat3, 4);
            Q.Enqueue(cat4, 5);
            int count = 0;
            ShelterNode current = Q.Front;
            while(current != null)
            {
                count++;
                current = current.Next;
            }
            Assert.Equal(5, count);
        }

        [Fact]
        public void TestQueueEnqueueFront()
        {
            Animal cat = new Cat();
            Animal cat1 = new Cat();
            Animal cat2 = new Cat();
            Animal cat3 = new Cat();
            Animal cat4 = new Cat();
            ShelterNode node = new ShelterNode(cat, 1);
            Queue Q = new Queue(node);
            Q.Enqueue(cat1, 2);
            Q.Enqueue(cat2, 3);
            Q.Enqueue(cat3, 4);
            Q.Enqueue(cat4, 5);
            Assert.Equal(1, Q.Front.SerialNumber);
        }

        [Fact]
        public void TestQueueEnqueueRear()
        {
            Animal cat = new Cat();
            Animal cat1 = new Cat();
            Animal cat2 = new Cat();
            Animal cat3 = new Cat();
            Animal cat4 = new Cat();
            ShelterNode node = new ShelterNode(cat, 1);
            Queue Q = new Queue(node);
            Q.Enqueue(cat1, 2);
            Q.Enqueue(cat2, 3);
            Q.Enqueue(cat3, 4);
            Q.Enqueue(cat4, 5);
            Assert.Equal(5, Q.Rear.SerialNumber);
        }

        [Fact]
        public void TestQueueDequeueReturnType()
        {
            Animal cat = new Cat();
            Animal cat1 = new Cat();
            Animal cat2 = new Cat();
            Animal cat3 = new Cat();
            Animal cat4 = new Cat();
            ShelterNode node = new ShelterNode(cat, 1);
            Queue Q = new Queue(node);
            Q.Enqueue(cat1, 2);
            Q.Enqueue(cat2, 3);
            Q.Enqueue(cat3, 4);
            Q.Enqueue(cat4, 5);
            
            Assert.IsType<ShelterNode>(Q.Dequeue());
        }

        [Fact]
        public void TestQueueDequeueFristDe()
        {
            Animal cat = new Cat();
            Animal cat1 = new Cat();
            Animal cat2 = new Cat();
            Animal cat3 = new Cat();
            Animal cat4 = new Cat();
            ShelterNode node = new ShelterNode(cat, 1);
            Queue Q = new Queue(node);
            Q.Enqueue(cat1, 2);
            Q.Enqueue(cat2, 3);
            Q.Enqueue(cat3, 4);
            Q.Enqueue(cat4, 5);
            ShelterNode result = Q.Dequeue();
            Assert.Equal(1, result.SerialNumber);
        }

        [Fact]
        public void TestQueueDequeueSecondDe()
        {
            Animal cat = new Cat();
            Animal cat1 = new Cat();
            Animal cat2 = new Cat();
            Animal cat3 = new Cat();
            Animal cat4 = new Cat();
            ShelterNode node = new ShelterNode(cat, 1);
            Queue Q = new Queue(node);
            Q.Enqueue(cat1, 2);
            Q.Enqueue(cat2, 3);
            Q.Enqueue(cat3, 4);
            Q.Enqueue(cat4, 5);
            Q.Dequeue();
            Q.Dequeue();
            ShelterNode result = Q.Dequeue();
            Assert.Equal(3, result.SerialNumber);
        }

        [Fact]
        public void TestQueuePeekNull()
        {
            Queue Q = new Queue();
            ShelterNode result = Q.Peek();
            Assert.Null(result);
        }

        [Fact]
        public void TestQueuePeek()
        {
            Animal cat = new Cat();
            Animal cat1 = new Cat();
            Animal cat2 = new Cat();
            Animal cat3 = new Cat();
            Animal cat4 = new Cat();
            ShelterNode node = new ShelterNode(cat, 1);
            Queue Q = new Queue(node);
            Q.Enqueue(cat1, 2);
            Q.Enqueue(cat2, 3);
            Q.Enqueue(cat3, 4);
            Q.Enqueue(cat4, 5);
            Assert.Equal(1, Q.Peek().SerialNumber);
        }

        [Fact]
        public void TestAnimalShelterEnqueueDog()
        {
            AnimalShelter AS = new AnimalShelter();
            Animal dog = new Dog();            
            AS.Enqueue(dog);
            ShelterNode test = AS.Dogs.Peek();
            Assert.IsType<Dog>(test.Obj);            
        }

        
    }
}
