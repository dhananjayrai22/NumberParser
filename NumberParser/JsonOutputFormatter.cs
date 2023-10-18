using System;
using System.IO;
using Newtonsoft.Json; // Add this using directive


namespace NumberParser
{
    public class JsonOutputFormatter : IOutputFormatter
    {
        public void FormatAndSave(int[] numbers, string fileName)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(numbers, Newtonsoft.Json.Formatting.Indented)); // Fully qualify Formatting
        }
    }
}






//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;

//namespace NumberParser
//{
//    public class JsonOutputFormatter : IOutputFormatter
//    {
//        public void FormatAndSave(int[] numbers, string fileName)
//        {
//            File.WriteAllText(fileName, JsonConvert.SerializeObject(numbers, Formatting.Indented));
//        }
//    }
//}
