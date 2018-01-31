using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsultaPagoIVR.Data
{
    public class PagoIVRDAL
    {
        internal static sp_get_cta_UltimaTransaccionPagoOnline_Result ConsultaUltimoPagoIVR()
        {
            using(var context = new PagoIVR_Model_Entities())
            {
                return context.sp_get_cta_UltimaTransaccionPagoOnline().FirstOrDefault();
            }
        }
    }
}