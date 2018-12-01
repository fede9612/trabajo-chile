using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SiteMinder
{
    [DataContract]
    public class RoomStay
    {
        public RoomStay()
        {
        }

        [DataMember]
        public TimeSpan TimeSpan{ get; set; }
    }
}