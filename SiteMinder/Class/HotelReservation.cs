using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SiteMinder
{
    [DataContract]
    public class HotelReservation
    {

        public HotelReservation()
        {

        }

        public HotelReservation(int uniqueID)
        {
            UniqueID = new UniqueID(uniqueID);
        }

        [DataMember]
        public POS POS {get; set; }

        [DataMember]
        public UniqueID UniqueID{ get; set; }

        [DataMember]
        public List<RoomStay> RoomStays {get; set; }

        [DataMember]
        public ResGlobalInfo ResGlobalInfo{ get; set; }
    }
}