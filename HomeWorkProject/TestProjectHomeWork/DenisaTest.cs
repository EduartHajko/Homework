using HomeWorkProject;

namespace TestProjectHomeWork
{
    [TestClass]
    public class DenisaTest
    {
        public TestContext TestContext { get; set; }


        [TestMethod]
        public void FileNameExists()
        {
            D_Sh_ClassToTest test = new D_Sh_ClassToTest();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            test.FileExists("");

            bool fromcall;

            fromcall = test.FileExists(@"C:\Windows\regedit.exe");

            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(fromcall);
        }

        public void FileNameNotExists()
        {
            D_Sh_ClassToTest test = new D_Sh_ClassToTest();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            test.FileExists("");

            bool fromcall;
        
            fromcall = test.FileExists(@"C:\Windows\regedit.exe");

            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsFalse(fromcall);
        }

        [TestMethod]
        public void TestNotCompiled()
        {
            Assert.Inconclusive();
        }
        
        [TestMethod]
        public void FileNameNullOrEmpty_Try_Catch()
        {
            D_Sh_ClassToTest classToTest = new D_Sh_ClassToTest();
            try
            {
                classToTest.FileExists("null");
            }
            catch (ArgumentNullException ex)
            {
                TestContext.WriteLine("//test was secess is throw exception");
                return;
            }
            Assert.Fail("call to method did not throw an exception");
        }

        [TestMethod]
        public void AreEqualsStrings()
        {
            D_Sh_ClassToTest test = new D_Sh_ClassToTest();
            TestContext.WriteLine("Kemi aksesuar klasen me sukses");
            bool fromcall;
            fromcall = test.StringCompare("Denisa", "Denisa");
            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(fromcall);
        }
        [TestMethod]
       public void TestiFisFibonacci()
        {
            D_Sh_ClassToTest test = new D_Sh_ClassToTest();
            int fib = test.Fibonacci(4);
            Assert.AreEqual(3, fib);
        }

    }
    }
