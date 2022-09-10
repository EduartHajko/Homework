using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class D_Sh_ClassToTest
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("filename");
            }


            var result = File.Exists(fileName);

            return File.Exists(fileName);
            return result;
        }
        public bool StringCompare(string stringName1, string stringName2)
        {
            if (stringName1.Equals(stringName2))
                return true;
            else
            {
                return false;
            }
        }
    }
}