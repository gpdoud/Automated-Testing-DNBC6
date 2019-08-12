using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedTestingLibraryProject;

namespace AutomatedTestingMSTestProject {

    [TestClass]
    public class TestFunctions {

        Functions functions = null;

        [TestInitialize]
        public void Setup() {
            functions = new Functions();
        }

        [TestMethod]
        public void TestAdd1() {
            var answer = functions.Add1(0);
            Assert.AreEqual(1, answer);
            answer = functions.Add1(-1);
            Assert.AreEqual(0, answer);
        }
        [TestMethod]
        public void TestXSquaredPlus3() {
            // test input 0
            var ans = functions.XSquaredPlus3(0);
            Assert.AreEqual(3, ans);
            // test input 3
            ans = functions.XSquaredPlus3(3);
            Assert.AreEqual(12, ans);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestX7X12() {
            // test zero
            var ans = functions.X7X12(0);
            Assert.AreEqual(12, ans);
            // test one
            ans = functions.X7X12(1);
            Assert.AreEqual(6, ans);
            // test negative one
            Assert.AreEqual(20, functions.X7X12(-1));
            // test four
            //Assert.AreEqual(0, functions.X7X12(4));
        }
        [TestMethod]
        public void ABC() {
            Assert.Fail();
        }
    }

}
