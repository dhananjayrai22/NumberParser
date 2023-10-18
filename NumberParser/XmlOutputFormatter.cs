using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NumberParser
{
    public class XmlOutputFormatter : IOutputFormatter
    {
        public void FormatAndSave(int[] numbers, string fileName)
        {
            var xmlDocument = new XDocument(new XElement("Numbers",
                numbers.Select(n => new XElement("Number", n))));

            xmlDocument.Save(fileName);
        }
    }
}
