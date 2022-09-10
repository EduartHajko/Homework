using HomeWorkProject;
using static System.Net.Mime.MediaTypeNames;

namespace TestProjectHomework
{
    [TestClass]
    public class testing
    {

        public TestContext TestContext { get; set; }

        /*[TestMethod]
        public void FileNameExists()
        {
            ArmirClassToTest test = new ArmirClassToTest();

            TestContext.WriteLine("Kemi aksesuar me sukses klasen");

            bool fromCall;

            fromCall = test.FileExists(@"C:\Windows\regedit.exe");

            TestContext.WriteLine("kemi aksesuar etoden me sukses");

            Assert.IsTrue(fromCall);
        }*/

        /*[TestMethod]
        public void TestNotCompiled()
        {
            Assert.Inconclusive();
        }*/

      /*  [TestMethod]
        // dua te testoj errors duke perdorur try catch
        public void FileNameNullOrEmpty_Try_Catch()
        {
            // Assert.Inconclusive();

            ArmirClassToTest file = new ArmirClassToTest();

            try
            {
                file.FileExists(null);
            }
            catch (ArgumentNullException)
            {
                //test was sucess
                TestContext.WriteLine("tst was successful in throwing exception");
                return;
            }
            Assert.Fail("call to method did not throw an exception");
        }*/
/*
        [TestMethod]
        public void IsEqualOrNot()
        {
            *//*string name = "armir";
            string surname = "Armir";
            Assert.AreEqual(name, surname, true);
            TestContext.WriteLine("yeap they are =");*//*

            ArmirClassToTest test = new ArmirClassToTest();
            TestContext.WriteLine("Kmei aksesuar klasen me sukses te plote");

            bool fromcall;


            fromcall = test.StringCompare("armir","Armir");
            Assert.IsTrue(fromcall);
            TestContext.WriteLine("Strings are equal");
        }*/

        [TestMethod]
        public void TestIfisFibonaci()
        {
            ArmirClassToTest test = new ArmirClassToTest();
           int fib = test.Fibonacci(5);

            Assert.AreEqual(5, fib);
        }

        [TestMethod]
        public void TestFileToCopy()
        {
            ArmirClassToTest test = new ArmirClassToTest();

            test.copyFileIntoPath("armir.txt", "leshi");

            TestContext.WriteLine("KALAMITI");
        }

    }
}