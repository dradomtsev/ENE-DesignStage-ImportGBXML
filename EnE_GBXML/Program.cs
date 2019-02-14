using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Globalization;

namespace Workflow
{
    public class ServiceMethods
    {
        public static GreenBuildingXML_ArchiCAD.gbXML DeserializeGBXML_ArchiCAD(out GreenBuildingXML_ArchiCAD.gbXML rtObject_In)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("EnE_GBXML.Properties.Resources", Assembly.GetExecutingAssembly());
            XmlSerializer serializer = new XmlSerializer(typeof(GreenBuildingXML_ArchiCAD.gbXML));

            XmlDocument doc = new XmlDocument();
            //using (StreamReader srReader = new StreamReader(@"G:\Team Drives\DataTemp\UNC\02-SHA\Export\GBXML-Archicad\UNC-D02-B08-YBP-ZZ - Copy.xml"))
            using (StreamReader srReader = new StreamReader(@EnE_GBXML.Properties.Resources.GBXML_ArchiCAD_Input))
            {
                doc.Load(srReader);
            }

            XmlNamespaceManager manager = new XmlNamespaceManager(doc.NameTable);
            manager.AddNamespace("NM", "http://www.gbxml.org/schema");
            XmlNode node_ = doc.SelectSingleNode(@"NM:gbXML/NM:DocumentHistory/NM:CreatedBy/@date", manager);
            DateTime MyDateTime = DateTime.Parse(node_.InnerText, null, DateTimeStyles.RoundtripKind);
            node_.Value = MyDateTime.ToString("s");

            XmlReader reader = new XmlNodeReader(doc);
            // Call the Deserialize method to restore the object's state.
            rtObject_In = (GreenBuildingXML_ArchiCAD.gbXML)serializer.Deserialize(reader);
            reader.Dispose();
            reader.Close();
                       
            return rtObject_In;
        }
        public static GreenBuildingXML_Revit.gbXML DeserializeGBXML_Revit(out GreenBuildingXML_Revit.gbXML rtObject_In)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("EnE_GBXML.Properties.Resources", Assembly.GetExecutingAssembly());
            XmlSerializer serializer = new XmlSerializer(typeof(GreenBuildingXML_Revit.gbXML));

            using (StreamReader srReader = new StreamReader(@EnE_GBXML.Properties.Resources.GBXML_Revit_Input))
            {
                FileStream fs = new FileStream(@"G:\Team Drives\DataTemp\UNC\02-SHA\Export\GBXML-Revit\UNC-D02-B08-YBP-ZZ.xml", FileMode.Open);
                XmlReader reader = XmlReader.Create(fs);

                // Call the Deserialize method to restore the object's state.
                rtObject_In = (GreenBuildingXML_Revit.gbXML)serializer.Deserialize(reader);
                srReader.Dispose();
                srReader.Close();
            }

            return rtObject_In;
        }
        public static GreenBuildingXML_Ver601.gbXML DeserializeGBXML_Ver601(out GreenBuildingXML_Ver601.gbXML rtObject_In)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("EnE_GBXML.Properties.Resources", Assembly.GetExecutingAssembly());
            XmlSerializer serializer = new XmlSerializer(typeof(GreenBuildingXML_Ver601.gbXML));
            XmlDocument doc = new XmlDocument();
            using (StreamReader srReader = new StreamReader(@EnE_GBXML.Properties.Resources.GBXML_Revit_Input))
            {
                doc.Load(srReader);
            }
            XmlNamespaceManager manager = new XmlNamespaceManager(doc.NameTable);
            manager.AddNamespace("NM", "http://www.gbxml.org/schema");
            XmlNode node = doc.SelectSingleNode(@"NM:gbXML/NM:DocumentHistory/NM:CreatedBy/@date", manager);
            DateTime dtItem = DateTime.Parse(node.InnerText, null, DateTimeStyles.RoundtripKind);
            node.Value = dtItem.ToString("s");
            string strTemp = "";
            XmlNodeList xndListDates = doc.SelectNodes(@"NM:gbXML/NM:Schedule/NM:YearSchedule/NM:BeginDate", manager);
            foreach (XmlNode item in xndListDates)
            {
                dtItem = DateTime.Parse(item.InnerText, null, DateTimeStyles.RoundtripKind);
                item.InnerText = dtItem.ToString("s");
            }
            xndListDates = doc.SelectNodes(@"NM:gbXML/NM:Schedule/NM:YearSchedule/NM:EndDate", manager);
            foreach (XmlNode item in xndListDates)
            {
                strTemp = item.InnerText;
                strTemp.Replace("24:00", "00:00");
                dtItem = DateTime.Parse(strTemp, null, DateTimeStyles.RoundtripKind);
                item.InnerText = dtItem.ToString("s");
            }

            XmlReader reader = new XmlNodeReader(doc);
            // Call the Deserialize method to restore the object's state.
            rtObject_In = (GreenBuildingXML_Ver601.gbXML)serializer.Deserialize(reader);
            reader.Dispose();
            reader.Close();

            return rtObject_In;
        }
    }

}
namespace EnE_GBXML
{
    class Program
    {
        static void Main(string[] args)
        {
            GreenBuildingXML_ArchiCAD.gbXML gbxml_ArchiCAD  = new GreenBuildingXML_ArchiCAD.gbXML();
            GreenBuildingXML_Revit.gbXML    gbxml_Revit     = new GreenBuildingXML_Revit.gbXML();
            GreenBuildingXML_Ver601.gbXML   gbxml_601       = new GreenBuildingXML_Ver601.gbXML();
            //Workflow.ServiceMethods.DeserializeGBXML_ArchiCAD   (out gbxml_ArchiCAD);
            //Workflow.ServiceMethods.DeserializeGBXML_Revit      (out gbxml_Revit);
            Workflow.ServiceMethods.DeserializeGBXML_Ver601     (out gbxml_601);
        }
    }
}
