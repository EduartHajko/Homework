using System.Security.Cryptography.X509Certificates;
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
        [TestMethod]
        public void AreEqualStrings()
        {
            K_L_ClassToTest test = new K_L_ClassToTest();
            //Assert.Inconclusive();
            TestContext.WriteLine("keni aksesuar klasën me sukses");

            bool fromcall;

            fromcall = test.StringCompare("edi", "Edi");
            TestContext.WriteLine("kemi aksesuar metodën me sukses");


            Assert.IsTrue(fromcall);
        }

        [TestMethod]

        public void TestIfIsFibonnaci()
        {
            K_L_ClassToTest test = new K_L_ClassToTest();

            //E thirra klasën Fibonnaci
            int fib = test.Fibonacci(4);

            try
            {
                test.Fibonacci(-4);   
            }
            catch (ArgumentNullException)
            {
                TestContext.WriteLine("//test was successfull and it throw exception");
                return;
            }

            Assert.Fail("Call to method did not throw an exception");
            
        }
        public void copyFileIntoPath(string fileToCopyPath, string targetFolderPath)
        {
            {
                if (!File.Exists(fileToCopyPath))
                    throw new FileNotFoundException("Can't find file to copy");
                if (!Directory.Exists(targetFolderPath))
                    throw new DirectoryNotFoundException("Can't find target folder!");
                var fileName = Path.GetFileName(fileToCopyPath);
                if (Directory.EnumerateFiles(targetFolderPath).Contains(fileName))
                    throw new Exception("File already exists at the target destination!");
                File.Copy(fileToCopyPath, $"{targetFolderPath}/{fileName}");
            }

        }



    }
}