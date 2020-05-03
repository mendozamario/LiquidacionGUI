using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenSubsidiado : LiquidacionCuotaModeradora
    {
        public override void CalcularTarifa()
        {
            Tarifa = 0.05;
        }

        public override void CalcularTopeMaximo()
        {
            TopeMaximo = 200000;
        }
    }
}
