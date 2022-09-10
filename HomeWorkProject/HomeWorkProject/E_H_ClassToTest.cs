using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class E_H_ClassToTest
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("filename");
            }

            var result=File.Exists(fileName);

            return result;
        }

        public bool StringCompare(string stringName1,string  stringName2)
        {
            bool result = false;
            if (stringName1.ToLower().Equals(stringName2.ToLower()))
                result = true;
            return result;
        }

        public  int Fibonacci(int index)
        {
            
                if (index == 0)
                    return 0;

                if (index == 1)
                    return 1;

                var response = Fibonacci(index - 1) + Fibonacci(index - 2);
              
                return response;
           
        }

    }
}
