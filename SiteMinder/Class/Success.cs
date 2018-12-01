using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace SiteMinder
{

    [DataContract]
    public class Success
    {

        [XmlIgnore]
        public bool Value { get; set; }
    }
}