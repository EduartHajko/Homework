using HomeWorkProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectHomework
{
    [TestClass]
    public class EduartTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            E_H_ClassToTest test = new E_H_ClassToTest();
            test.FileExists("");

        }
    }
}