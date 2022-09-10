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
    }
}