﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Final_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Tests
{
    [TestClass()]
    public class Kế_Toán_FormTests
    {
        [TestMethod()]
        public void Kế_Toán_FormTest()
        {
            int a = 4;
            int b = 4;
            Assert.IsTrue(a == b, "Test Sucessful");
        }
        [TestMethod()]
        public void Kế_Toán_FormTest1()
        {
            int a = 4;
            int b = 5;
            Assert.IsTrue(a == b, "Test Sucessful");

        }

        [TestMethod()]
        public void XPTest()
        {
            int a = 4;
            int b = 5;
            Assert.IsTrue(a == b, "Test Sucessful");
        }

        [TestMethod()]
        public void Kế_Toán_Form_LoadTest()
        {
            Assert.Fail();
        }
    }
}