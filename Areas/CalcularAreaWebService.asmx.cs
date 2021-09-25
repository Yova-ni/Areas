using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Areas
{
    /// <summary>
    /// Descripción breve de CalcularAreaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularAreaWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal areacuadrado(decimal LADO)
        {
            Area c = new Area();
            return c.areacuadrado(LADO);
        }

        [WebMethod]
        public decimal areatriangulo(decimal BASE, decimal ALTURA)
        {
            Area c = new Area();
            return c.areatriangulo(BASE, ALTURA);
        }

        [WebMethod]
        public decimal areacirculo(decimal RADIO)
        {
            Area c = new Area();
            return c.areacirculo(RADIO);
        }
    }
}
