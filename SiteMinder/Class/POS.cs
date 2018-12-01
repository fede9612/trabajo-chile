using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SiteMinder
{
    [DataContract]
    public class POS
    {
        public POS()
        {
        }

        [DataMember]
        public Source Source{get; set; }
    }
}