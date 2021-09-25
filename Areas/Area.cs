using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Areas
{
    public class Area
    {
        public decimal basE{ get; set; }
        public decimal altura { get; set; }
        public decimal radio { get; set; }

        public decimal areacuadrado( decimal basE)
        {
            return  basE * basE;
        }

        public decimal areatriangulo( decimal basE, decimal altura)
        {
            var resultado = (basE * altura) / 2;
            return resultado;
        }

        public decimal areacirculo(decimal radio)
        {
            var resultado = Math.PI * Math.Pow(Convert.ToDouble(radio), 2);
            return Convert.ToDecimal(resultado);
        }
    }
}