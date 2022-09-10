using HomeWorkProject;

namespace TestProjectHomework

{
    [TestClass]
    public class S_Testing
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FileNameExists()
        {
            S_N_ProjectToTest test = new S_N_ProjectToTest();
            TestContext.WriteLine("Kemi aksesuar klasen me sukses");

            bool fromcall;

            fromcall = test.FileExists(@"C:\Windows\regedit.exe");

            TestContext.WriteLine("Kemi aksesuar klasen me sukses");
            Assert.IsTrue(fromcall);

        }

        [TestMethod]
        public void TestNotCompiled()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        // dua te testoj errors duke perdorur try catch
        public void FileNameNullOrEmpty_Try_Catch()
        {
            S_N_ProjectToTest test = new S_N_ProjectToTest();
            try
            {

            }
            catch (ArgumentNullException)
            {
                TestContext.WriteLine("//Test was successful it threw exeption:");

                return;
            }
            Assert.Inconclusive();
        }

        [TestMethod]
        public void AreEqualsStrings()
        {
            S_N_ProjectToTest test = new S_N_ProjectToTest();
            TestContext.WriteLine("Kemi aksesuar klasen me sukses");
            bool fromcall;
            fromcall = test.StringCompare("edi","Edi");
            TestContext.WriteLine("Kemi aksesuar metoden me sukses");
            Assert.IsTrue(fromcall);
            
        }









    }
}