using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace LiquidacionUI
{
    public partial class Principal : Form
    {
        LiquidacionCuotaModeradora liquidacionCuotaModeradora;
        LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            CrearObjeto();
        }
        private void CrearObjeto()
        {
            if (CmbTipoAfiliacion.SelectedItem.Equals("Subsidiado"))
            {
                liquidacionCuotaModeradora = new RegimenSubsidiado();
            }
            else
            {
                liquidacionCuotaModeradora = new RegimenContributivo();
            }
            liquidacionCuotaModeradora.NumeroLiquidacion = TxtNumeroLiquidacion.Text.Trim();
            liquidacionCuotaModeradora.IdentificacionPaciente = TxtIdentificacionPaciente.Text.Trim();
            liquidacionCuotaModeradora.NombrePaciente =TxtNombrePaciente.Text.Trim();
            liquidacionCuotaModeradora.TipoAfiliacion = CmbTipoAfiliacion.SelectedItem.ToString();
            liquidacionCuotaModeradora.SalarioDevengado = Convert.ToDouble(TxtSalarioDevengado.Text.Trim());
            liquidacionCuotaModeradora.ValorServicio = Convert.ToDouble(TxtValorServicio.Text.Trim());

            liquidacionCuotaModeradora.CalcularCuotaModeradora();
            TxtCuotaModeradora.Text = liquidacionCuotaModeradora.CuotaModeradora.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CrearObjeto();
                string mensaje = liquidacionCuotaModeradoraService.Guardar(liquidacionCuotaModeradora);
                MessageBox.Show(mensaje, "Mensaje Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception)
            {
                string mensaje = "Los datos son incongruentes";
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (TxtNumeroLiquidacion.Text == "")
            {
                new Consultar().Visible = true;
            }
            else
            {
                BusquedaPrincipal();
            }
        }

        private void BusquedaPrincipal()
        {
            LiquidacionCuotaModeradora lcm;
            if (liquidacionCuotaModeradoraService.BuscarPorLiquidacion(TxtNumeroLiquidacion.Text) != null)
            {
                string tipoLiquidacion = liquidacionCuotaModeradoraService.BuscarPorLiquidacion(TxtNumeroLiquidacion.Text).TipoAfiliacion;

                if (tipoLiquidacion.Equals("Subsidiado"))
                {
                    lcm = new RegimenSubsidiado();
                }
                else
                {
                    lcm = new RegimenContributivo();
                }
                lcm = liquidacionCuotaModeradoraService.BuscarPorLiquidacion(TxtNumeroLiquidacion.Text);
                TxtIdentificacionPaciente.Text = lcm.IdentificacionPaciente;
                TxtNombrePaciente.Text = lcm.NombrePaciente;
                CmbTipoAfiliacion.Text = lcm.TipoAfiliacion;
                TxtSalarioDevengado.Text = lcm.SalarioDevengado.ToString();
                TxtValorServicio.Text = lcm.ValorServicio.ToString();
                TxtCuotaModeradora.Text = lcm.CuotaModeradora.ToString();

                Desabilitar();
                BtnGuardar.Enabled = false;
            }
            else
            {
                string mensaje = "La liquidacion que busca no existe";
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = liquidacionCuotaModeradoraService.Eliminar(TxtNumeroLiquidacion.Text.Trim());
            MessageBox.Show(mensaje, "Mensaje Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Limpiar()
        {
            TxtNumeroLiquidacion.Text = "";
            TxtIdentificacionPaciente.Text = "";
            TxtNombrePaciente.Text = "";
            CmbTipoAfiliacion.Text = "";
            TxtSalarioDevengado.Text = "";
            TxtValorServicio.Text = "";
            TxtCuotaModeradora.Text = "";
        }
        private void Desabilitar()
        {
            TxtNumeroLiquidacion.Enabled = false;
            TxtIdentificacionPaciente.Enabled = false;
            TxtNombrePaciente.Enabled = false;
            CmbTipoAfiliacion.Enabled = false;
            TxtSalarioDevengado.Enabled = false;
        }
        private void Habilitar()
        {
            TxtNumeroLiquidacion.Enabled = true;
            TxtIdentificacionPaciente.Enabled = true;
            TxtNombrePaciente.Enabled = true;
            CmbTipoAfiliacion.Enabled = true;
            TxtSalarioDevengado.Enabled = true;
        }
        public void Modificar()
        {
            LiquidacionCuotaModeradora liquidacionCuota;
            if (CmbTipoAfiliacion.Text.Equals("Subsidiado"))
            {
                liquidacionCuota = new RegimenSubsidiado();
            }
            else
            {
                liquidacionCuota = new RegimenSubsidiado();
            }
            liquidacionCuota.NumeroLiquidacion = TxtNumeroLiquidacion.Text;
            liquidacionCuota.IdentificacionPaciente = TxtIdentificacionPaciente.Text;
            liquidacionCuota.NombrePaciente = TxtNumeroLiquidacion.Text;
            liquidacionCuota.TipoAfiliacion = CmbTipoAfiliacion.Text;
            liquidacionCuota.SalarioDevengado = Convert.ToDouble(TxtSalarioDevengado.Text);
            liquidacionCuota.ValorServicio = Convert.ToDouble(TxtValorServicio.Text);

            liquidacionCuota.CalcularCuotaModeradora();
            TxtCuotaModeradora.Text = liquidacionCuota.CuotaModeradora.ToString();

            string mensaje = liquidacionCuotaModeradoraService.Modificar(TxtNumeroLiquidacion.Text, liquidacionCuota);
            MessageBox.Show(mensaje, "Mensaje Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();
            Habilitar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}
