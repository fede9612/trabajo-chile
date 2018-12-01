using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SiteMinder
{
    [DataContract]
    public class ResGlobalInfo
    {
        public ResGlobalInfo()
        {
        }

        [DataMember]
        public TimeSpan TimeSpan{ get; set; }

        [DataMember]
        public Total Total { get; set; }

        [DataMember]
        public BasicPropertyInfo BasicPropertyInfo { get; set; }

        [DataMember]
        public HotelReservationIDs HotelReservationIDs { get; set; }
    }
}