using System;
using Xunit;
using MultiBracketValidation;
using MultiBracketValidation.Classes;

namespace TestMBV
{
    public class UnitTest1
    {
        [Fact]
        public void TestMBVForTrue()
        {
            string thing = "public CharNode(char value) {Value = value; Next = null;}";
            bool test = Program.MBV(thing);
            Assert.True(test);
        }

        [Fact]
        public void TestMBVForWrongBracket()
        {
            string thing = "public CharNode(char value) {Value = value; Next = null;]";
            bool test = Program.MBV(thing);
            Assert.False(test);
        }

        [Fact]
        public void TestMBVForExtraOpening()
        {
            string thing = "public CharNode(char value) {Value = value; Next = null;}(";
            bool test = Program.MBV(thing);
            Assert.False(test);
        }

        [Fact]
        public void TestMBVForComplexTrue()
        {
            string thing = "[[(){}[]({[]})]{}()]";
            bool test = Program.MBV(thing);
            Assert.True(test);
        }
    }
}
