using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SiteMinder
{

    [DataContract(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public class OTA_HotelResNotifRS
    {
        public OTA_HotelResNotifRS()
        {
        }

        public OTA_HotelResNotifRS(string Token) 
        {
            EchoToken = Token;
            Version = "1.0"; // Esto se deberia configurar con el web.config
            TimeStamp = DateTime.Now;
        }

        public OTA_HotelResNotifRS(string Token, string ResponseType)
        {
            EchoToken = Token;
            Version = "1.0"; // Esto se deberia configurar con el web.config
            TimeStamp = DateTime.Now;
            ResResponseType = ResponseType; 
        }

        [DataMember, XmlAttribute]
        public string Version { get; set; }

        [DataMember, XmlAttribute]
        public string EchoToken { get; set; }

        [DataMember, XmlAttribute]
        public DateTime TimeStamp { get; set; }

        [DataMember, XmlAttribute]
        public string ResResponseType { get; set; }

        [DataMember]
        public Success Success { get; set; }

        [DataMember]
        public List<HotelReservation> HotelReservations { get; set; }

        [DataMember]
        public List<Warning> Warnings { get; set; }

        [DataMember]
        public List<Error> Errors{get; set; }
    } 
}
