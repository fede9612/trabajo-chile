using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SiteMinder
{
    [DataContract]
    public class Source
    {
        public Source()
        {
        }

        [DataMember]
        public RequestorID RequestorID { get; set; }
    }
}