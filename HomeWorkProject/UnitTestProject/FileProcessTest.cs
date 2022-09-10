using HomeWorkProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectToTest;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class FileProcessTest
    {
        private const string FileName = @"c:\Windows\bogus.exe";

        public TestContext TestContext { get; set; }
        [TestMethod]
        public void FileNameDoesExists()
        {
            //Assert.Inconclusive();
            FileProcess file = new FileProcess();
            TestContext.WriteLine(@"test context");
            bool fromcall;

            fromcall = file.FileExists(@"C:\Windows\regedit.exe");
           
            Assert.IsTrue(fromcall);    
        }
        [TestMethod]
        public void FileNameDoesNotExists()
        {
            e_h_Task3 test = new e_h_Task3();
            TestContext.WriteLine(@"test  eduart class homework project context");
            bool fromcall;

            fromcall = test.FileExists(FileName);

            Assert.IsFalse(fromcall);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingAtribute()
        {
            FileProcess file = new FileProcess();
           
            file.FileExists("");
        }
        [TestMethod]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            FileProcess file = new FileProcess();
           
            try
            {
                file.FileExists("file");
            }
            catch (ArgumentNullException)
            {
                //test was sucess
                return;
            }

            Assert.Fail("call to method did not throw an exception");

        }

        [TestMethod]
        public void AreEqualsStrings()
        {
            string str1 = "edi";
            string str2 = "Edi";

            Assert.AreEqual(str1, str2 ,true);    

        }

        [TestMethod]
        public void AreEqualsObjects()
        {
            FileProcess file = new FileProcess();
            FileProcess file2 = file;

            Assert.AreSame(file, file2);

        }

    }
}