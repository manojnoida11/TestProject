using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestProject
{
    public class XmlDemo
    {
        private XmlDocument m_oXmlDoc = new XmlDocument();
        private string c_sFilenameBIxml = "BI_LOG.xml";
        
        public void Test()
        {
            Console.WriteLine("Change 4 made by manoj noida111");

            Console.WriteLine("Change 3 made by manoj noida");
            Console.WriteLine("change 2 made by manojnoida");

            Console.WriteLine("change 1 made by manojnoida");
            Console.WriteLine("Change 1 made ny manoj");
            m_oXmlDoc.Load(c_sFilenameBIxml);
            XmlNode node = m_oXmlDoc.SelectSingleNode("Log/EN/Legend");
        }

    }
}
