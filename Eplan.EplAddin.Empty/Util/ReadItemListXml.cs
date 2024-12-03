using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Eplan.EplAddin.Empty.Util
{
    internal class ReadItemListXml
    {

        public static IEnumerable<XElement> GetXmlGroups()
        {
            string xmlFilePath = "C:\\Users\\gustavo.oliveira\\source\\repos\\Digitos\\Eplan.EplAddin.Empty\\newItemList.xml";

            XDocument doc = XDocument.Load(xmlFilePath);
            return doc.Descendants("group");
        }

    }
}
