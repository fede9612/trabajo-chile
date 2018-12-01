using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace SiteMinder
{
    [DataContract]
    public class UniqueID
    {
        public UniqueID()
        {

        }

        public UniqueID(int id)
        {
            ID = id;
        }

        public UniqueID(int id, int? tipo)
        {
            ID = id;
            Type = tipo;
        }

        [XmlIgnore]
        public int? Type { get; set; }

        [DataMember, XmlAttribute("Type")]
        public string TypeAsText
        {
            get { return (Type.HasValue) ? Type.ToString() : null; }
            set { Type = !string.IsNullOrEmpty(value) ? int.Parse(value) : default(int?); }
        }

        [DataMember, XmlAttribute]
        public int ID { get; set; }
    }
}