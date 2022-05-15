using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestClass()]
    public class MyClassTests
    {
        [TestMethod()]
        public void SomeMethod1Test()
        {
            //arrange

            int x = 32;
            int y = 22;
            int expect = 54;

            //act
            int result = MyClass.SomeMethod1(x, y);

            //assert
            Assert.AreEqual(expect, result);

            //Assert.Fail();
        }

        [TestMethod()]
        public void SomeMethod2Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SomeMethod3Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SomeMethod4Test()
        {
            Assert.Fail();
        }
    }
}