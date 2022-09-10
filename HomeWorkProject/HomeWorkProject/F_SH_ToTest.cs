using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class F_SH_ToTest
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("filename");
            }

            var result = File.Exists(fileName);
            return result;
        }
        public bool StringCompare(string stringName1, string stringName2)
        {
            if (stringName1.ToLower().Equals(stringName2.ToLower()))

                return true;
            else
            {
                return false;
            }

        }
        public int Fibonacci(int index)
        {

            {
                if (index == 0)
                    return 0;
                if (index == 1)
                    return 1;
                var response = Fibonacci(index - 1) + Fibonacci(index - 2);
                return response;

            }
        }
        public void copyFileIntoPath(string fileToCopyPath, string targetFolderPath)
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

