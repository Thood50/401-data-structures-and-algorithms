using System;
using Xunit;
using array_binary_search;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestOne()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(0, Program.BinarySearch(testArray, 1));
        }

        [Fact]
        public void TestTwo()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(1, Program.BinarySearch(testArray, 2));
        }

        [Fact]
        public void TestThree()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(2, Program.BinarySearch(testArray, 3));
        }

        [Fact]
        public void TestFour()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(3, Program.BinarySearch(testArray, 4));
        }

        [Fact]
        public void TestFive()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(4, Program.BinarySearch(testArray, 5));
        }

        [Fact]
        public void TestSix()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(5, Program.BinarySearch(testArray, 6));
        }

        [Fact]
        public void TestSeven()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(6, Program.BinarySearch(testArray, 7));
        }

        [Fact]
        public void TestEight()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(7, Program.BinarySearch(testArray, 8));
        }

        [Fact]
        public void TestNine()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(8, Program.BinarySearch(testArray, 9));
        }

        [Fact]
        public void TestTen()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(9, Program.BinarySearch(testArray, 10));
        }

        [Fact]
        public void TestEleven()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(10, Program.BinarySearch(testArray, 11));
        }

        [Fact]
        public void TestTwelve()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(-1, Program.BinarySearch(testArray, 12));
        }

        [Fact]
        public void TestZero()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(-1, Program.BinarySearch(testArray, 0));
        }
    }
}
