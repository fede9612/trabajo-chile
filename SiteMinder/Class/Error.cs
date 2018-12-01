using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace SiteMinder
{
    [DataContract]
    public class Error
    {
        public Error()
        {

        }

        public Error(int tipo)
        {
            Type = tipo;
        }

        public Error(int tipo, string Codigo, int recordId, string mensaje)
        {
            Type = tipo;
            Code = Codigo;
            RecordID = recordId;
            Message = mensaje;
        }

        [DataMember, XmlAttribute]
        public int Type { get; set; }

        [DataMember, XmlAttribute]
        public string Code { get; set; }

        [DataMember, XmlAttribute]
        public int RecordID { get; set; }

        [DataMember, XmlText]
        public string Message { get; set; }
    }
}