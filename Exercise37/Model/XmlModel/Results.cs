using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise37.Model.XmlModel
{
    [XmlRoot(ElementName="results")]
    public class XmlResults
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "url")]
        public string Url { get; set; }
    }
}