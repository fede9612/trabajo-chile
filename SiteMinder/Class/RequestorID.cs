using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace SiteMinder
{

    [DataContract]
    public class RequestorID
    {
        public RequestorID()
        {

        }

        public RequestorID(string id)
        {
            ID = id;
        }

        [DataMember, XmlAttribute]
        public string ID { get; set; }
    }
}