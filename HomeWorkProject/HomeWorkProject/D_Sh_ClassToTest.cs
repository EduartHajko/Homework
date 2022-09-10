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
        public int Fibonacci(int index)
        {
            try
            {
                if (index == 0)
                    return 0;
                if (index == 1)
                    return 1;
                var response = Fibonacci(index - 1) + Fibonacci(index - 2);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}