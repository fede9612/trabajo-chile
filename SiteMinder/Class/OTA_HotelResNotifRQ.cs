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
    public class OTA_HotelResNotifRQ
    {
        OTA_HotelResNotifRQ()
        {
        }

        [DataMember, XmlAttribute]
        public string Version { get; set; }

        [DataMember, XmlAttribute]
        public string EchoToken { get; set; }

        [DataMember, XmlAttribute]
        public DateTime TimeStamp { get; set; }  
        
        [DataMember, XmlAnyAttribute]
        public DateTime CreateDateTime { get; set; }

        [DataMember]
        public List<HotelReservation> HotelReservations { get; set; }
    }
        
}
