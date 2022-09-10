using HomeWorkProject;
using TestProjectHomeWork;


namespace TestProjectHomeWork
{
    [TestClass]
    public class KridensTest
    {
        
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FileNameExists()
        {
            K_L_ClassToTest test = new K_L_ClassToTest();
            TestContext.WriteLine("Kemi aksesuar klasën me sukses");
            bool fromcall;

            fromcall = test.FileExists(@"C:\Windows\regedit.exe");
            TestContext.WriteLine("Kemi aksesuar metodën me sukses");
            Assert.IsTrue(fromcall);
        }

        [TestMethod]
        public void FileNameDoesNotExists()
        {
            K_L_ClassToTest test = new K_L_ClassToTest();
            TestContext.WriteLine("Kemi aksesuar klasën me sukses");
            bool fromcall;

            fromcall = test.FileExists(@"C:\Windows\kridens.exe");
            TestContext.WriteLine("Kemi aksesuar metodën me sukses");
            Assert.IsFalse(fromcall);
        }

        //dua të testoj erroret duke përdorur try and catch
        [TestMethod]
        public void FileNameNullOrEmpty_Try_Catch()
        {
            K_L_ClassToTest test = new K_L_ClassToTest();
            //Assert.Inconclusive();
            try
            {
                test.FileExists(""); // Inside ("null") kjo del gabim, for we made it so.
            }
            catch (ArgumentNullException)
            {
                //test was sucessfull
                TestContext.WriteLine("//test was sucessfull it throw exception");
                return;
            }
            Assert.Fail("call to method did not throw an exception");
        }

        [TestMethod]
        public void StringAreEqualOrNot()
        {
            K_L_ClassToTest test = new K_L_ClassToTest();
            //Assert.Inconclusive();

            string st1 = "edit";
            string st2 = "Edit";

            Assert.AreEqual(st1,st2, true);
        }
    }
}