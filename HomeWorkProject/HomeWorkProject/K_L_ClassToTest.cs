using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class K_L_ClassToTest
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("filename");
            }

            var result = File.Exists(fileName);
            return File.Exists(fileName);
        }

        public bool StringCompare(string v1, string v2)
        {
            bool result = false;
            if (v1.ToLower().Equals(v2.ToLower()));
            result = true ;
            return result;
        }


    }
}
