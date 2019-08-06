using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace StoreWeb.Repo
{
    public class BaseRepo<T>
    {
        public List<T> ObjectsList = new List<T>();

        public BaseRepo(string xmlPath, string rootElement)
        {
            using (var reader = new StreamReader(xmlPath))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<T>),
                    new XmlRootAttribute(rootElement));
                ObjectsList = (List<T>)deserializer.Deserialize(reader);
            }
        }
    }
}