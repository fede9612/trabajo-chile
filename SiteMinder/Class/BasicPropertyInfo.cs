using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace SiteMinder
{

    [DataContract]
    public class BasicPropertyInfo
    {
        public BasicPropertyInfo()
        {

        }

        [DataMember, XmlAttribute]
        public string HotelCode { get; set; }
    }
}