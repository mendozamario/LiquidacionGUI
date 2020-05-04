using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuotaModeradoraRepository liquidacionCuotaModeradoraRepository;
        public LiquidacionCuotaModeradoraService()
        {
            liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
        }
        public string Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                liquidacionCuotaModeradoraRepository.Guardar(liquidacionCuotaModeradora);
                return "Se ha guardado satisfactoriamente";
            }
            catch (Exception)
            {
                return "Hubo un error, verifique e intente nuevamente";
            }
        }
        public List<LiquidacionCuotaModeradora> Consultar()
        {
            return liquidacionCuotaModeradoraRepository.Consultar();
        }
        public List<LiquidacionCuotaModeradora> FiltrarPorAfiliacion (string tipo)
        {
            return liquidacionCuotaModeradoraRepository.FiltrarPorAfiliacion(tipo);
        }
        public int TotalizarPorTipo(string tipoAfiliacion)
        {
            return liquidacionCuotaModeradoraRepository.TotalizarPorTipo(tipoAfiliacion);
        }
        public int TotalizarAfiliacion()
        {
            return liquidacionCuotaModeradoraRepository.TotalizarAfiliacion();
        }
        public double SumarLiquidaciones()
        {
            return liquidacionCuotaModeradoraRepository.SumarLiquidaciones();
        }
        public double SumarPorTipo(string tipoAfiliacion)
        {
            return liquidacionCuotaModeradoraRepository.SumarPorTipo(tipoAfiliacion);
        }
        public void Eliminar(string numeroLiquidacion)
        {
            liquidacionCuotaModeradoraRepository.Eliminar(numeroLiquidacion);
        }
        public List<LiquidacionCuotaModeradora> BuscarPorLiquidacion(string numeroLiquidacion)
        {
            return liquidacionCuotaModeradoraRepository.BuscarPorLiquidacion(numeroLiquidacion);
        }
    }
}
