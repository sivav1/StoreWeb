using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace StoreWeb.Core
{
    [XmlRoot(ElementName = "Product")]
    public class Product
    {
        [XmlAttribute(AttributeName = "Id")]
        public int Id { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Cost")]
        public float Cost { get; set; }
        [XmlAttribute(AttributeName = "Image")]
        public string Image { get; set; }
    }
}
