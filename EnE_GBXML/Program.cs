using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Workflow
{
    public class ServiceMethods
    {
        public static GreenBuildingXML_Ver501.gbXML DeserializeGBXML_ArchiCAD(out GreenBuildingXML_Ver501.gbXML rtObject_In)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("EnE_GBXML.Properties.Resources", Assembly.GetExecutingAssembly());
            XmlSerializer serializer = new XmlSerializer(typeof(GreenBuildingXML_Ver501.gbXML));

            using (StreamReader srReader = new StreamReader(@EnE_GBXML.Properties.Resources.GBXML_ArchiCAD_Input))
            {
                FileStream fs = new FileStream(@"G:\Team Drives\DataTemp\UNC\02-SHA\Export\GBXML-Archicad\UNC-D02-B08-YBP-ZZ - Copy.xml", FileMode.Open);
                XmlReader reader = XmlReader.Create(fs);
                XmlDeserializationEvents e = new XmlDeserializationEvents();
                e.OnUnknownAttribute += On_UnknownAttribute;
                e.OnUnknownElement += On_UnknownElement;
                e.OnUnknownNode += On_UnknownNode;
                e.OnUnreferencedObject += On_UnreferencedObject;
                // Call the Deserialize method to restore the object's state.
                rtObject_In = (GreenBuildingXML_Ver501.gbXML)serializer.Deserialize(reader, e);
                srReader.Dispose();
                srReader.Close();
            }
            

            //StreamReader srReader = new StreamReader(@EnE_GBXML.Properties.Resources.GBXML_ArchiCAD_Input);
            //string gbxml = srReader.ReadToEnd();
            //MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            //DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(Workflow.JSONInput_Rootobject));
            //rtObject_In = (Workflow.JSONInput_Rootobject)deserializer.ReadObject(ms);
            
            return rtObject_In;
        }
        public static void On_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            Console.WriteLine("OnUnknownAttribute");
        }

        public static void On_UnknownElement(object sender, XmlElementEventArgs e)
        {
            Console.WriteLine("OnUnknownElement");
        }

        public static void On_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("OnUnknownNode");
        }

        public static void On_UnreferencedObject(object sender, UnreferencedObjectEventArgs e)
        {
            Console.WriteLine("OnUnreferencedObject");
        }
    }

}
namespace EnE_GBXML
{
    class Program
    {
        static void Main(string[] args)
        {
            GreenBuildingXML_Ver501.gbXML gbxml_ArchiCAD = new GreenBuildingXML_Ver501.gbXML();
            Workflow.ServiceMethods.DeserializeGBXML_ArchiCAD(out gbxml_ArchiCAD);
        }
    }
}
