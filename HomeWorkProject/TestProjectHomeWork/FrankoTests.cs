using HomeWorkProject;
using System;

namespace TestProjectHomeWork
{
    [TestClass]
    public class FrankoTests
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void FileNameExist()
        {
            F_SH_ToTest test = new F_SH_ToTest();
            TestContext.WriteLine("Kemi aksesuar klasen me sukses");
            bool fromcall;
            fromcall = test.FileExists(@"C:\Windows\regedit.exe");
            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(fromcall);
        }
        [TestMethod]
        public void FileNameDoesNotExist()
        {
            F_SH_ToTest test = new F_SH_ToTest();
            TestContext.WriteLine("Kemi aksesuar klasen me sukses");
            bool fromcall;
            fromcall = test.FileExists(@"C:\Windows\regedit.exe");
            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(fromcall);
        }
        [TestMethod]
        public void TestNotCompiled()
        {
            Assert.Inconclusive();
        }
        //Dua te testoj erroret duke perdorur try catch
        [TestMethod]
        public void FileNameNullorEmpty_Try_Catch()
        {
            F_SH_ToTest test = new F_SH_ToTest();
            //Assert.Inconclusive();
            try
            {
                test.FileExists(null);
            }
            catch (ArgumentNullException)
            {
                TestContext.WriteLine("test was succesful it throw exeption");
                return;
            }
            Assert.Fail("Call to method did not throw an exeption");

        }
        [TestMethod]
        public void StringIsEqualOrNot()
        {
            string str1 = "franko";
            string str2 = "Franko";
            Assert.AreEqual(str1, str2, true);
        }
        [TestMethod]
        public void AreEqualsStrings()
        {
            F_SH_ToTest test = new F_SH_ToTest();
            TestContext.WriteLine("Kemi aksesuar klasen me sukses");
            bool fromcall;
            fromcall = test.StringCompare("franko", "Franko");
            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(fromcall);
        }

        //public void TestFibonacci()
        //{
        //    Assert.AreEqual(0, F_SH_ToTest.Fibonacci(0));
        //    Assert.AreEqual(1,F_SH_ToTest.Fibonacci(1));
        //    Assert.AreEqual(7,F_SH_ToTest.Fibonacci(13));
        //    Assert.ThrowsException<Exception>(() => { F_SH_ToTest.Fibonacci(-1); });
        //    Assert.ThrowsException<Exception>(() => { F_SH_ToTest.Fibonacci(int.MaxValue); });
        //    Assert.Inconclusive();
        //}
        [TestMethod]
        public void TestifFibonacci()
        {
            F_SH_ToTest test = new F_SH_ToTest();
            int fib = test.Fibonacci(4);
            Assert.AreEqual(3, fib);
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

