using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Test
{
    public partial class Form1 : Form
    {
        SiteMinder.SiteminderClient Client;
        XmlSerializer XmlRequest;
        XmlSerializer XmlResponse;

        public Form1()
        {
            InitializeComponent();

            Client = new SiteMinder.SiteminderClient();
            XmlRequest = new XmlSerializer(typeof(SiteMinder.OTA_HotelResNotifRQ));
            XmlResponse = new XmlSerializer(typeof(SiteMinder.OTA_HotelResNotifRS));
        }

        private void btnrq1_Click(object sender, EventArgs e)
        {
            var Request = new SiteMinder.OTA_HotelResNotifRQ();

            var ListHotel = new List<SiteMinder.HotelReservation>();

            var Hotel = new SiteMinder.HotelReservation();
            Hotel.POS = new SiteMinder.POS();
            Hotel.POS.Source = new SiteMinder.Source();
            Hotel.POS.Source.RequestorID = new SiteMinder.RequestorID();
            Hotel.POS.Source.RequestorID.ID = "PMSPUBLISHER";

            Hotel.UniqueID = new SiteMinder.UniqueID();
            Hotel.UniqueID.ID = 123456789;

            var ListRoomStay = new List<SiteMinder.RoomStay>();
            var RoomStay = new SiteMinder.RoomStay();
            RoomStay.TimeSpan = new SiteMinder.TimeSpan();
            RoomStay.TimeSpan.Start = new DateTime(2017, 9, 5);
            RoomStay.TimeSpan.End = new DateTime(2017, 9, 6);

            Hotel.RoomStays = ListRoomStay.ToArray();

            Hotel.ResGlobalInfo = new SiteMinder.ResGlobalInfo();
            Hotel.ResGlobalInfo.TimeSpan = new SiteMinder.TimeSpan();
            Hotel.ResGlobalInfo.TimeSpan.Start = new DateTime(2017, 9, 5);
            Hotel.ResGlobalInfo.TimeSpan.End = new DateTime(2017, 9, 6);
            Hotel.ResGlobalInfo.Total = new SiteMinder.Total();
            Hotel.ResGlobalInfo.Total.AmountAfterTax = 200.00;
            Hotel.ResGlobalInfo.BasicPropertyInfo = new SiteMinder.BasicPropertyInfo();
            Hotel.ResGlobalInfo.BasicPropertyInfo.HotelCode = "10107";

            ListHotel.Add(Hotel);
            Request.HotelReservations = ListHotel.ToArray();

            textBox2.Text = DevolverXml(XmlRequest, Request);

            var Response = Client.OTA_HotelResNotifRS(Request);
            textBox1.Text = DevolverXml(XmlResponse, Response);
        }

        private void btnrq2_Click(object sender, EventArgs e)
        {
            var Request = new SiteMinder.OTA_HotelResNotifRQ();

            var ListHotel = new List<SiteMinder.HotelReservation>();

            var Hotel = new SiteMinder.HotelReservation();
            Hotel.POS = new SiteMinder.POS();
            Hotel.POS.Source = new SiteMinder.Source();
            Hotel.POS.Source.RequestorID = new SiteMinder.RequestorID();
            Hotel.POS.Source.RequestorID.ID = "PMSPUBLISHER";

            Hotel.UniqueID = new SiteMinder.UniqueID();
            Hotel.UniqueID.ID = 123456789;

            Hotel.ResGlobalInfo = new SiteMinder.ResGlobalInfo();
            Hotel.ResGlobalInfo.BasicPropertyInfo = new SiteMinder.BasicPropertyInfo();
            Hotel.ResGlobalInfo.BasicPropertyInfo.HotelCode = "10107";

            ListHotel.Add(Hotel);
            Request.HotelReservations = ListHotel.ToArray();

            textBox2.Text = DevolverXml(XmlRequest, Request);

            var Response = Client.OTA_HotelResNotifRS(Request);
            textBox1.Text = DevolverXml(XmlResponse, Response);
        }

        private void btnrq3_Click(object sender, EventArgs e)
        {
            var Request = new SiteMinder.OTA_HotelResNotifRQ();
            textBox2.Text = DevolverXml(XmlRequest, Request);

            // Este no tiene nada, podes hacer pruebas aca

            var Response = Client.OTA_HotelResNotifRS(Request);
            textBox1.Text = DevolverXml(XmlResponse, Response);
        }

        private void btnrq4_Click(object sender, EventArgs e)
        {
            var Request = new SiteMinder.OTA_HotelResNotifRQ();
            textBox2.Text = DevolverXml(XmlRequest, Request);

            var Response = Client.OTA_HotelResNotifRSWarning(Request);
            textBox1.Text = DevolverXml(XmlResponse, Response);
        }

        private void btnrq5_Click(object sender, EventArgs e)
        {
            var Request = new SiteMinder.OTA_HotelResNotifRQ();
            textBox2.Text = DevolverXml(XmlRequest, Request);

            var Response = Client.OTA_HotelResNotifRSWarningAndError(Request);
            textBox1.Text = DevolverXml(XmlResponse, Response);
        }

        private void btnrq6_Click(object sender, EventArgs e)
        {
            var Request = new SiteMinder.OTA_HotelResNotifRQ();
            textBox2.Text = DevolverXml(XmlRequest, Request);

            var Response = Client.OTA_HotelResNotifRSError(Request);
            textBox1.Text = DevolverXml(XmlResponse, Response);
        }      

        private string DevolverXml(XmlSerializer xmlSubmit, object objSer)
        {
            string xml;

            using (var sww = new StringWriter())
            {
                Encoding utf8noBOM = new UTF8Encoding(false);
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.Encoding = utf8noBOM;
                using (XmlWriter writer = XmlWriter.Create(sww, settings))
                {
                    xmlSubmit.Serialize(writer, objSer);
                    xml = sww.ToString(); 
                }
            }
            return xml;
        }
              
    }
}
