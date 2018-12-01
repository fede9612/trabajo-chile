using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace SiteMinder
{
    [DataContract]
    public class HotelReservationID
    {
        public HotelReservationID()
        {

        }

        public HotelReservationID(int Id_Type, string Id_Value )
        {
            ResID_Type = Id_Type;
            ResID_Value = Id_Value;
        }

        public HotelReservationID(int Id_Type, string Id_Value, string ID_Source, string Guest)
        {
            ResID_Type = Id_Type;
            ResID_Value = Id_Value;
            ResID_Source = ID_Source;
            ForGuest = Guest;
        }

        [DataMember, XmlAttribute]
        public int ResID_Type { get; set; }

        [DataMember, XmlAttribute]
        public string ResID_Value { get; set; }

        [DataMember, XmlAttribute]
        public string ResID_Source { get; set; }

        [DataMember, XmlAttribute]
        public string ForGuest { get; set; }
    }
}