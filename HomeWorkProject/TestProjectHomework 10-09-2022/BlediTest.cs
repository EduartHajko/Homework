using HomeWorkProject;

namespace TestProjectHomework

{
    [TestClass]
    public class BlediTest
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void FileNameExists()
        {
            B_P_ClassToTest test = new B_P_ClassToTest();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            bool fromcall;

            fromcall = test.FileExists(@"C:\Windows\regedit.exe");
            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsTrue(fromcall);
        }
        [TestMethod]
        public void FileNameNotExists()
        {
            B_P_ClassToTest test = new B_P_ClassToTest();
            TestContext.WriteLine("kemi aksesuar klasen me sukses");
            bool fromcall;

            fromcall = test.FileExists(@"C:\Windows\bledi.exe");
            TestContext.WriteLine("kemi aksesuar metoden me sukses");
            Assert.IsFalse(fromcall);
        }

        [TestMethod]
        public void TestNotCompiled()
        {
            Assert.Inconclusive();
        }

        //dua te testoj erroret duke perdorur try catch
        [TestMethod]
        public void FileNameNullOrEmpty_Try_Catch()
        {
            B_P_ClassToTest test = new B_P_ClassToTest();
            //Asser.Inconclusive();
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
        public bool StringCompare(string stringName1, string stringName2)
        {
            bool result = false;
            if (stringName1.ToLower().Equals(stringName2.ToLower()))
                result = true;
            return result;
        }
    }
}