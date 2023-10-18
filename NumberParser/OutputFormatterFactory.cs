using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser
{
    public class OutputFormatterFactory
    {
        public static IOutputFormatter GetFormatter(string format)
        {
            switch (format.ToLower())
            {
                case "xml":
                    return new XmlOutputFormatter();
                case "json":
                    return new JsonOutputFormatter();
                case "text":
                    return new TextOutputFormatter();
                default:
                    throw new ArgumentException("Unsupported format");
            }
        }
    }
}
