using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
    public interface IOutputFormatter
    {
        void FormatAndSave(int[] numbers, string fileName);
    }
    //internal class IOutputFormatter
    //{
    //}
}


