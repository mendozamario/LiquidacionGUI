using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public string NumeroLiquidacion { get; set; }
        public string IdentificacionPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string TipoAfiliacion { get; set; }
        public double SalarioDevengado { get; set; }
        public double ValorServicio { get; set; }
        public double CuotaModeradora { get; set; }
        public double CuotaModeradoraReal { get; set; }
        public double Tarifa { get; set; }
        public double TopeMaximo { get; set; }
        public DateTime FechaAlmacenamiento { get; set; }
        public const double SalarioMinimo = 980657;

        public void CalcularCuotaModeradora()
        {
            CalcularTarifa();
            CuotaModeradora = ValorServicio * Tarifa;
            VerificarTope();
        }
        public void VerificarTope()
        {
            CalcularTopeMaximo();
            if (CuotaModeradora > TopeMaximo)
            {
                CuotaModeradoraReal = CuotaModeradora;
                CuotaModeradora = TopeMaximo;
            }
            else
            {
                CuotaModeradoraReal = CuotaModeradora;
            }
        }
        public abstract void CalcularTarifa();
        public abstract void CalcularTopeMaximo();

    }
}
