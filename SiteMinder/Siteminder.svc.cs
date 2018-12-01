using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services.Description;

namespace SiteMinder
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Siteminder : ISiteminder
    {
        Siteminder()
        {
            System.ServiceModel.OperationContext.Current.IncomingMessageHeaders.Clear();
            System.ServiceModel.OperationContext.Current.OutgoingMessageHeaders.Clear();
        }

        
        // Solo dberias usar este, no los demas
        OTA_HotelResNotifRS ISiteminder.Response(OTA_HotelResNotifRQ Request)
        {

            OTA_HotelResNotifRS objResponse = new OTA_HotelResNotifRS("879791900");
            objResponse.Success = new Success();
            objResponse.Success.Value = true;

            if (objResponse.HotelReservations == null) objResponse.HotelReservations = new List<HotelReservation>();

            foreach (var item in Request.HotelReservations)
            {
                var Hotel = new HotelReservation();
                Hotel.UniqueID = new UniqueID(item.UniqueID.ID, item.UniqueID.Type);
                Hotel.ResGlobalInfo = new ResGlobalInfo();

                // Esto debe ir con una lista ver "OTA Code List"
                Hotel.ResGlobalInfo.HotelReservationIDs = new HotelReservationIDs(18, "82329987"); //Ver como funciona estos constructores, los realice de esta manera porque Siteminder los pide como obligatorio 

                objResponse.HotelReservations.Add(Hotel);
            }            

            return objResponse;
        }

        // -------------------------  De aca para abajo solo para pruebas --------------------------
        OTA_HotelResNotifRS ISiteminder.ResponseWarning(OTA_HotelResNotifRQ Request)
        {

            OTA_HotelResNotifRS objResponse = new OTA_HotelResNotifRS("879791900");
            if (objResponse.Warnings == null)
            {
                objResponse.Warnings = new List<Warning>();

                Warning objWar = new Warning(6);
                objWar.Code = "151";
                objWar.Message = "Hay datos incompletos";
                objResponse.Warnings.Add(objWar);

            }
            return objResponse;
        }

        OTA_HotelResNotifRS ISiteminder.ResponseErrorAndWarning(OTA_HotelResNotifRQ Request)
        {

            OTA_HotelResNotifRS objResponse = new OTA_HotelResNotifRS("879791900");

            if (objResponse.Warnings == null)
            {
                objResponse.Warnings = new List<Warning>();

                Warning objWar = new Warning(6);
                objWar.Code = "151";
                objWar.Message = "Hay datos incompletos";
                objResponse.Warnings.Add(objWar);

            }

            if (objResponse.Errors == null)
            {
                objResponse.Errors = new List<Error>();

                Error objErr = new Error(6);
                objErr.Code = "392";
                objErr.Message = "Invalid hotel code: ABC";
                objResponse.Errors.Add(objErr);

            }

            return objResponse;
        }

        OTA_HotelResNotifRS ISiteminder.ResponseError(OTA_HotelResNotifRQ Request)
        {

            OTA_HotelResNotifRS objResponse = new OTA_HotelResNotifRS("879791900");
            if (objResponse.Errors == null)
            {
                objResponse.Errors = new List<Error>();

                Error objErr = new Error(6);
                objErr.Code = "392";
                objErr.Message = "Invalid hotel code: ABC";
                objResponse.Errors.Add(objErr);

            }
            return objResponse;
        }

    }
}
