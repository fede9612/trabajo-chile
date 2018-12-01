using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace SiteMinder
{

    [DataContract]
    public class Total
    {
        public Total()
        {

        }

        [DataMember, XmlAttribute]
        public double AmountAfterTax { get; set; }
    }
}