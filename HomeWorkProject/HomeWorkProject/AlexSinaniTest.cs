using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject;
public class AlexSinaniTest
{
    public bool StringCompare(string stringName1, string stringName2)
    {
        if (stringName1.Equals(stringName2))
            return true;
        else
        {
            return false;
        }
    }


    public static int Fibonacci(int index)
    {
        if (index == 0)
            return 0;
        if (index == 1)
            return 1;
        return Fibonacci(index - 1) + Fibonacci(index - 2);
    }

    public object Fibonacci()
    {
        throw new NotImplementedException();
    }

    public void FileExists(object value)
    {
        throw new NotImplementedException();
    }
}