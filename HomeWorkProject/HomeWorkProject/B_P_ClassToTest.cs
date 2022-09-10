using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class B_P_ClassToTest
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("filename");
            }
            return File.Exists(fileName);
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
