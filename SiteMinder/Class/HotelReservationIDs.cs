using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SiteMinder
{
    [DataContract]
    public class HotelReservationIDs
    {
        public HotelReservationIDs()
        {

        }

        public HotelReservationIDs(int Id_type, string Id_Value)
        {
            HotelReservationID = new HotelReservationID(Id_type, Id_Value);
        }

        public HotelReservationIDs(int Id_type, string Id_Value, string ID_Source, string Guest)
        {
            HotelReservationID = new HotelReservationID(Id_type, Id_Value, ID_Source, Guest);
        }

        [DataMember]
        public HotelReservationID HotelReservationID { get; set; }

    }
}