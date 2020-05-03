using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenContributivo : LiquidacionCuotaModeradora
    {
        public override void CalcularTarifa()
        {
            if (SalarioDevengado < SalarioMinimo * 2)
            {
                Tarifa = 0.15;
            }else if(SalarioDevengado >= SalarioMinimo * 2 && SalarioDevengado <= SalarioMinimo * 5)
            {
                Tarifa = 0.20;
            }
            else
            {
                Tarifa = 0.25;
            }
        }

        public override void CalcularTopeMaximo()
        {
            if (SalarioDevengado < SalarioMinimo * 2)
            {
                TopeMaximo = 250000;
            }
            else if (SalarioDevengado >= SalarioMinimo * 2 && SalarioDevengado <= SalarioMinimo * 5)
            {
                TopeMaximo = 900000;
            }
            else
            {
                TopeMaximo = 1500000;
            }
        }
    }
}
