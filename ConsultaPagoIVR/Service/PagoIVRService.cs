using ConsultaPagoIVR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsultaPagoIVR.Service
{
    public class PagoIVRService
    {
        public static sp_get_cta_UltimaTransaccionPagoOnline_Result ConsultaUltimoPagoIVR()
        {
            return PagoIVRDAL.ConsultaUltimoPagoIVR();
        }
    }
}