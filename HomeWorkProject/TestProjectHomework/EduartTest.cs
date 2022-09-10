using HomeWorkProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

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


        [TestMethod]
        public void TestifisFibonaci()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();
           
          int fib= test.Fibonacci(4);

            Assert.AreEqual(3, fib);

        }

        //menyra e pare per te testuar exception
        [TestMethod]
        public void TestFibonaciEXE()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();
            try
            {
                test.Fibonacci(-1);
            }
            catch (ArgumentOutOfRangeException)
            {
               
                TestContext.WriteLine("//test was sucess it throw exception");
                return;
            }

            Assert.Fail("call to method did not throw an exception");



        }


        //menyra e dyte per te testuar exception
        [TestMethod]
        public void TestFibonaciEXE2()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();

   Assert.ThrowsException<ArgumentOutOfRangeException>(() => { test.Fibonacci(-1); });


        }


        [TestMethod]
        public void FileNotExistsException()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();
            Assert.ThrowsException<FileNotFoundException>(() => test.copyFileIntoPath("invalidPath", null));
        }

        [TestMethod]
        public void TargetDestinationNotExistsException()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();
            File.Create("properFilePath.txt");
            Assert.ThrowsException<DirectoryNotFoundException>(() => test.copyFileIntoPath("properFilePath.txt", "invalid directory path"));
        }

        [TestMethod]
        public void TargetFileAlreadyExistsException()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();
            var fileStream = File.Create("properFilePath.txt");
            fileStream.Dispose();
            var directoryInfo = Directory.CreateDirectory("validDirectory");
            var targetPath = Path.Combine(directoryInfo.FullName, fileStream.Name);
            var targetFile = File.Create(targetPath);
            targetFile.Dispose();

            Assert.ThrowsException<IOException>(() => test.copyFileIntoPath("properFilePath.txt", directoryInfo.FullName));
        }

        [TestMethod]
        public void FileProperlyCopied()
        {
            var fileStream = File.Create("properFilePath.txt");
            fileStream.Dispose();
            var directoryInfo = Directory.CreateDirectory("validDirectory");
            var targetPath = Path.Combine(directoryInfo.FullName, fileStream.Name);
            File.Delete(targetPath);
           
            Assert.IsTrue(File.Exists(targetPath));
        }


    }
}