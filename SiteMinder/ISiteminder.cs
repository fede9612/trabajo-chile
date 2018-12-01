using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SiteMinder
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISiteminder
    {
        [XmlSerializerFormat, OperationContract(Name = "OTA_HotelResNotifRS")]
        OTA_HotelResNotifRS Response(OTA_HotelResNotifRQ Request);


        // ------------ Estas de aca para abajo, se hicieorn para pruebas, solo deberia haber uno y ahi adentro hacer toda la logica. ------------
        [XmlSerializerFormat, OperationContract(Name = "OTA_HotelResNotifRSError")]
        OTA_HotelResNotifRS ResponseError(OTA_HotelResNotifRQ Request);

        [XmlSerializerFormat, OperationContract(Name = "OTA_HotelResNotifRSWarning")]
        OTA_HotelResNotifRS ResponseWarning(OTA_HotelResNotifRQ Request);

        [XmlSerializerFormat, OperationContract(Name = "OTA_HotelResNotifRSWarningAndError")]
        OTA_HotelResNotifRS ResponseErrorAndWarning(OTA_HotelResNotifRQ Request);

    }
   
}
