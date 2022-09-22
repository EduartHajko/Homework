using HomeWorkProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectHomework2
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestIfFileExists()
        {
            E_H_ClassToTest2 test = new E_H_ClassToTest2();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            bool resp;
            resp =test.FileExists(@"C:\Windows\regedit.exe");
            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(resp);

        }
        [TestMethod]
        public void TestIftFileNotExists()
        {
            E_H_ClassToTest2 test = new E_H_ClassToTest2();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            bool resp;
            resp = test.FileExists(@"C:\Windows\edi.exe");
            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(resp);

        }
       
        
        [TestMethod]
        public void TestTryCatchErrors()
        {
            E_H_ClassToTest2 test = new E_H_ClassToTest2();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            try
            {
                test.FileExists(null);
                TestContext.WriteLine("kemi aksesuar metoden me sukses");
            }
            catch (ArgumentNullException)
            {
                TestContext.WriteLine("//test was sucess it throw exception");
                return;

            }
            Assert.Fail("call to method did not throw an exception");
        }


        [TestMethod]
        public void TestTryCatchNotErrors()
        {
            E_H_ClassToTest2 test = new E_H_ClassToTest2();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            try
            {
                test.FileExists(@"C:\Windows\regedit.exe");
                TestContext.WriteLine("kemi aksesuar metoden me sukses");
            }
            catch (ArgumentNullException)
            {
                TestContext.WriteLine("//test was sucess it throw exception");
                return;

            }
            Assert.Fail("call to method did not throw an exception");
        }



        [TestMethod]
        public void TestNotCompiled()
        {
            Assert.Inconclusive();
        }
        
    }
}