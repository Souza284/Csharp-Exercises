using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise37.Model.XmlModel
{
    [XmlRoot(ElementName = "Root")]
    public class Root
    {

        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlElement(ElementName = "next")]
        public string Next { get; set; }

        [XmlElement(ElementName = "previous")]
        public object Previous { get; set; }

        //[XmlElement(ElementName = "results")]
        //public List<Results> Results { get; set; }
    }
}