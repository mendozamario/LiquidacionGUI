using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        string nombreArchivo = "Liquidacion.txt";
        List<LiquidacionCuotaModeradora> liquidacionCuotasModeradoras;
        public LiquidacionCuotaModeradoraRepository()
        {
            liquidacionCuotasModeradoras = new List<LiquidacionCuotaModeradora>();
        }
        public void Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                FileStream file = new FileStream(nombreArchivo, FileMode.Append);
                StreamWriter escritor = new StreamWriter(file);
                escritor.WriteLine($"{liquidacionCuotaModeradora.NumeroLiquidacion};{liquidacionCuotaModeradora.IdentificacionPaciente};{liquidacionCuotaModeradora.NombrePaciente};" +
                    $"{liquidacionCuotaModeradora.TipoAfiliacion};{liquidacionCuotaModeradora.SalarioDevengado};" +
                    $"{liquidacionCuotaModeradora.ValorServicio};{liquidacionCuotaModeradora.CuotaModeradora};{liquidacionCuotaModeradora.CuotaModeradoraReal};" +
                    $"{liquidacionCuotaModeradora.Tarifa};{liquidacionCuotaModeradora.TopeMaximo}");
                escritor.Close();
                file.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<LiquidacionCuotaModeradora> Consultar()
        {
            string linea;

            FileStream SourceStream = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader Reader = new StreamReader(SourceStream);

            while ((linea = Reader.ReadLine()) != null)
            {
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = Mapear(linea);

                liquidacionCuotasModeradoras.Add(liquidacionCuotaModeradora);
            }
            Reader.Close();
            SourceStream.Close();
            return liquidacionCuotasModeradoras;
        }

        private static LiquidacionCuotaModeradora Mapear(string linea)
        {
            LiquidacionCuotaModeradora liquidacionCuotaModeradora;
            string[] arrayLiquidacionCuotaModeradora = linea.Split(';');
            string tipoLiquidacion = arrayLiquidacionCuotaModeradora[3];
            if (tipoLiquidacion.Equals("Subsidiado"))
            {
                liquidacionCuotaModeradora = new RegimenSubsidiado();
            }
            else
            {
                liquidacionCuotaModeradora = new RegimenContributivo();
            }
            liquidacionCuotaModeradora.NumeroLiquidacion = arrayLiquidacionCuotaModeradora[0];
            liquidacionCuotaModeradora.IdentificacionPaciente = arrayLiquidacionCuotaModeradora[1];
            liquidacionCuotaModeradora.NombrePaciente = arrayLiquidacionCuotaModeradora[2];
            liquidacionCuotaModeradora.TipoAfiliacion = arrayLiquidacionCuotaModeradora[3];
            liquidacionCuotaModeradora.SalarioDevengado = Convert.ToDouble(arrayLiquidacionCuotaModeradora[4]);
            liquidacionCuotaModeradora.ValorServicio = Convert.ToDouble(arrayLiquidacionCuotaModeradora[5]);
            liquidacionCuotaModeradora.CuotaModeradora = Convert.ToDouble(arrayLiquidacionCuotaModeradora[6]);
            liquidacionCuotaModeradora.CuotaModeradoraReal = Convert.ToDouble(arrayLiquidacionCuotaModeradora[7]);
            liquidacionCuotaModeradora.Tarifa = Convert.ToDouble(arrayLiquidacionCuotaModeradora[8]);
            liquidacionCuotaModeradora.TopeMaximo = Convert.ToDouble(arrayLiquidacionCuotaModeradora[9]);
            return liquidacionCuotaModeradora;
        }
        public List<LiquidacionCuotaModeradora> FiltrarPorAfiliacion(string tipoAfiliacion)
        {
            return liquidacionCuotasModeradoras.Where(l => l.TipoAfiliacion.Equals(tipoAfiliacion)).ToList();
        }
        public int TotalizarPorTipo(string tipoAfiliacion)
        {
            return liquidacionCuotasModeradoras.Count(l => l.TipoAfiliacion.Equals(tipoAfiliacion));
        }
        public int TotalizarAfiliacion()
        {
            return liquidacionCuotasModeradoras.Count();
        }
        public double SumarLiquidaciones()
        {
            return liquidacionCuotasModeradoras.Sum(l => l.CuotaModeradora);
        }
        public double SumarPorTipo(string tipoAfiliacion)
        {
            return liquidacionCuotasModeradoras.Where(l => l.TipoAfiliacion.Equals(tipoAfiliacion)).Sum(l => l.CuotaModeradora);
        }
        public bool Eliminar(string numeroLiquidacion)
        {
            bool var = false;
            Consultar();
            FileStream file = new FileStream(nombreArchivo, FileMode.Create);
            file.Close();
            foreach (LiquidacionCuotaModeradora lcm in liquidacionCuotasModeradoras)
            {
                if (!(lcm.NumeroLiquidacion.Equals(numeroLiquidacion)))
                {
                    Guardar(lcm);
                    var = false;
                }
                else
                {
                    var = true;
                }
            }
            return var;
        }
        public LiquidacionCuotaModeradora BuscarPorLiquidacion(string numeroLiquidacion)
        {
            Consultar();
            return liquidacionCuotasModeradoras.Find(liquidacionCuotasModeradoras => liquidacionCuotasModeradoras.NumeroLiquidacion.Equals(numeroLiquidacion));
        }
        public List<LiquidacionCuotaModeradora> BuscarPorNombre(string nombre)
        {
            return liquidacionCuotasModeradoras.Where(l => l.NombrePaciente.Contains(nombre)).ToList();
        }
        public bool Modificar(string numeroLiquidacion, LiquidacionCuotaModeradora liquidacionCuotaMoeradora)
        {
            bool var;
            var = Eliminar(numeroLiquidacion);
            Guardar(liquidacionCuotaMoeradora);
            return var;
        }
    }
}