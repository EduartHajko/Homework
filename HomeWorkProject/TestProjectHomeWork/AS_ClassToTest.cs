using HomeWorkProject;
using TestProjectHomeWork;

namespace TestProjectHomeWork
{
    [TestClass]
    public class AS_ClassToTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FileNameDoesNotExists()
        {
            AlexSinaniTest test = new AlexSinaniTest();
            TestContext.WriteLine("Kemi aksesuar klasen me sukses:");
            bool fromcall;
            fromcall = test.filExists(@"C:\Windows\kridens.exe");
            TestContext.WriteLine("Kemi aksesuar metoden me sukses:");

            Assert.IsFalse(fromcall);

        }
        [TestMethod]
        public void TestNotCompiled()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void FileNameExists()
        {
            AlexSinaniTest test = new AlexSinaniTest();
            TestContext.WriteLine("Kemi aksesuar klasen me sukses:");
            bool fromcall;
            fromcall = test.FileExists(@"C:\Windows\regedit.exe");
            TestContext.WriteLine("Kemi aksesuar metoden me sukses:");

            Assert.IsTrue(fromcall);

        }
        [TestMethod] // per te pare erroret me try catch
        public void FileNameNullOrEmpty_Try_Catch()
        {
            AlexSinaniTest test = new AlexSinaniTest();
            try
            {
                test.FileExists(null);
            }
            catch (ArgumentNullException)
            {
                TestContext.WriteLine("//test was success it throws expection");
                return;
            }
            Assert.Fail("call to method did not throw an exception");
        }
        [TestMethod]
        public void StringAreEqualOrNot()
        {
            AlexSinaniTest test = new AlexSinaniTest();
            //Assert.Inconclusive();

            string st1 = "alex";
            string st2 = "Alex";

            Assert.AreEqual(st1, st2);
        }
        [TestMethod]
        public bool StringCompare(string stringName1, string stringName2)
        {
            bool result = false;
            if (stringName1.ToLower().Equals(stringName2.ToLower()))
                result = true;
            return result;
        }

        [TestMethod]
        public void TestIfIsFibonnaci()
        {
            AlexSinaniTest test = new AlexSinaniTest();
            //therrasim klasen fibonnaci

            int fib = test.Fibonacci(4);
        }

    }
}


