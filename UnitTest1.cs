﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Part3UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           var firstTest = Part3.StringExtender.Truncate("This is a test", 20);
        }
    }
}
