using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace SiteMinder
{
    [DataContract]
    public class TimeSpan
    {
        [DataMember, XmlAttribute]
        public DateTime Start { get; set; }

        [DataMember, XmlAttribute]
        public DateTime End { get; set; }
    }
}