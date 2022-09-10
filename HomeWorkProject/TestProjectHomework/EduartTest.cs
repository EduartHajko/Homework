using HomeWorkProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectHomework
{
    [TestClass]
    public class EduartTest
    {
        public TestContext TestContext { get; set; }


        [TestMethod]
        public void FileNameExists()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            bool fromcall;

            fromcall = test.FileExists(@"C:\Windows\regedit.exe");

            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(fromcall);
        }

        [TestMethod]
        public void FileNameNotExists()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            bool fromcall;

            fromcall = test.FileExists(@"C:\Windows\edi.exe");

            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsFalse(fromcall);
        }

        [TestMethod]
        public void TestNotCompiled()
        {
            Assert.Inconclusive();
        }

        //dua te tstoj erroret duke perdorur try catch
        [TestMethod]
        public void FileNameNullOrEmpty_Try_Catch()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();
            //Assert.Inconclusive();
            try
            {
                test.FileExists(null);
            }
            catch (ArgumentNullException)
            {
                TestContext.WriteLine("//test was sucess it throw exception");
                return;
            }

            Assert.Fail("call to method did not throw an exception");


        }

        [TestMethod]
        public void AreEqualsStrings()
        {

            E_H_ClassToTest test = new E_H_ClassToTest();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            bool fromcall;

            fromcall = test.StringCompare("edi","Edi");

            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(fromcall);


        }


    }
}