using ConsultaPagoIVR.Data;
using ConsultaPagoIVR.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ConsultaPagoIVR.Controllers
{
    [RoutePrefix("api/PagoIVR")]
    public class PagoIVRController : ApiController
    {
        [Route("ConsultaUltimoPagoIVR")]
        [AllowAnonymous]
        [HttpGet]
        public sp_get_cta_UltimaTransaccionPagoOnline_Result ConsultaUltimoPagoIVR()
        {
            return PagoIVRService.ConsultaUltimoPagoIVR();
        }
    }
}