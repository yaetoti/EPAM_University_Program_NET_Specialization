﻿using NUnit.Framework;

namespace IfStatements.Tests
{
    [TestFixture]
    public class Task14Tests
    {
        [TestCase(true, true, 0, ExpectedResult = 0)]
        [TestCase(true, true, 1, ExpectedResult = -2)]
        [TestCase(true, true, 2, ExpectedResult = -4)]
        [TestCase(true, true, 3, ExpectedResult = -6)]
        [TestCase(true, true, 4, ExpectedResult = -8)]
        [TestCase(true, true, 5, ExpectedResult = -10)]
        [TestCase(true, true, 6, ExpectedResult = -2)]
        [TestCase(true, true, 7, ExpectedResult = -4)]
        [TestCase(true, true, 8, ExpectedResult = -6)]
        [TestCase(true, true, 9, ExpectedResult = -8)]
        [TestCase(true, true, 10, ExpectedResult = -10)]
        [TestCase(true, true, -1, ExpectedResult = 2)]
        [TestCase(true, true, -2, ExpectedResult = 4)]
        [TestCase(true, true, -3, ExpectedResult = 6)]
        [TestCase(true, true, -4, ExpectedResult = 8)]
        [TestCase(true, true, -5, ExpectedResult = 20)]
        [TestCase(true, true, -6, ExpectedResult = 22)]
        [TestCase(true, true, -7, ExpectedResult = 24)]
        [TestCase(true, true, -8, ExpectedResult = 26)]
        [TestCase(true, true, -9, ExpectedResult = 28)]
        [TestCase(true, true, -10, ExpectedResult = 30)]
        [TestCase(true, false, 0, ExpectedResult = 0)]
        [TestCase(true, false, 1, ExpectedResult = 1)]
        [TestCase(true, false, 2, ExpectedResult = 4)]
        [TestCase(true, false, 3, ExpectedResult = 9)]
        [TestCase(true, false, 4, ExpectedResult = 16)]
        [TestCase(true, false, 5, ExpectedResult = 25)]
        [TestCase(true, false, 6, ExpectedResult = 216)]
        [TestCase(true, false, 7, ExpectedResult = 343)]
        [TestCase(true, false, 8, ExpectedResult = 512)]
        [TestCase(true, false, 9, ExpectedResult = 729)]
        [TestCase(true, false, 10, ExpectedResult = 1000)]
        [TestCase(true, false, -1, ExpectedResult = 1)]
        [TestCase(true, false, -2, ExpectedResult = 4)]
        [TestCase(true, false, -3, ExpectedResult = 9)]
        [TestCase(true, false, -4, ExpectedResult = 16)]
        [TestCase(true, false, -5, ExpectedResult = -125)]
        [TestCase(true, false, -6, ExpectedResult = -216)]
        [TestCase(true, false, -7, ExpectedResult = -343)]
        [TestCase(true, false, -8, ExpectedResult = -512)]
        [TestCase(true, false, -9, ExpectedResult = -729)]
        [TestCase(true, false, -10, ExpectedResult = -1000)]
        [TestCase(false, true, 0, ExpectedResult = 0)]
        [TestCase(false, true, 1, ExpectedResult = 1)]
        [TestCase(false, true, 2, ExpectedResult = 2)]
        [TestCase(false, true, 3, ExpectedResult = 3)]
        [TestCase(false, true, 4, ExpectedResult = 4)]
        [TestCase(false, true, 5, ExpectedResult = 5)]
        [TestCase(false, true, 6, ExpectedResult = 6)]
        [TestCase(false, true, 7, ExpectedResult = 7)]
        [TestCase(false, true, 8, ExpectedResult = -8)]
        [TestCase(false, true, 9, ExpectedResult = -9)]
        [TestCase(false, true, 10, ExpectedResult = -10)]
        [TestCase(false, true, -1, ExpectedResult = -1)]
        [TestCase(false, true, -2, ExpectedResult = -2)]
        [TestCase(false, true, -3, ExpectedResult = -3)]
        [TestCase(false, true, -4, ExpectedResult = -40)]
        [TestCase(false, true, -5, ExpectedResult = -50)]
        [TestCase(false, true, -6, ExpectedResult = -60)]
        [TestCase(false, true, -7, ExpectedResult = -70)]
        [TestCase(false, true, -8, ExpectedResult = -8)]
        [TestCase(false, true, -9, ExpectedResult = -9)]
        [TestCase(false, true, -10, ExpectedResult = 10)]
        [TestCase(false, false, 0, ExpectedResult = 0)]
        [TestCase(false, false, 1, ExpectedResult = -100)]
        [TestCase(false, false, 2, ExpectedResult = -200)]
        [TestCase(false, false, 3, ExpectedResult = -300)]
        [TestCase(false, false, 4, ExpectedResult = -400)]
        [TestCase(false, false, 5, ExpectedResult = 5)]
        [TestCase(false, false, 6, ExpectedResult = 6)]
        [TestCase(false, false, 7, ExpectedResult = 7)]
        [TestCase(false, false, 8, ExpectedResult = -8)]
        [TestCase(false, false, 9, ExpectedResult = -9)]
        [TestCase(false, false, 10, ExpectedResult = -10)]
        [TestCase(false, false, -1, ExpectedResult = 100)]
        [TestCase(false, false, -2, ExpectedResult = 200)]
        [TestCase(false, false, -3, ExpectedResult = 300)]
        [TestCase(false, false, -4, ExpectedResult = -4)]
        [TestCase(false, false, -5, ExpectedResult = -5)]
        [TestCase(false, false, -6, ExpectedResult = -6)]
        [TestCase(false, false, -7, ExpectedResult = -7)]
        [TestCase(false, false, -8, ExpectedResult = -8)]
        [TestCase(false, false, -9, ExpectedResult = -9)]
        [TestCase(false, false, -10, ExpectedResult = 10)]
        public int DoSomething_ReturnsBool(bool b1, bool b2, int i)
        {
            return Task14.DoSomething(b1, b2, i);
        }
    }
}
