using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace LiquidacionUI
{
    public partial class Consultar : Form
    {
        List<LiquidacionCuotaModeradora> liquidacionCuotasModeradoras = new List<LiquidacionCuotaModeradora>();
        LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        public Consultar()
        {
            InitializeComponent();
            liquidacionCuotasModeradoras = liquidacionCuotaModeradoraService.Consultar();
            TotalizarRegimenes();
            SumarRegimenes();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
                

            TblVista.DataSource = liquidacionCuotaModeradoraService.FiltrarPorAfiliacion(CmbTipo.Text);
            if (CmbTipo.Text.Equals("Todos"))
            {
                TblVista.DataSource = null;
                TblVista.DataSource = liquidacionCuotasModeradoras;
            }

        }
        private void TotalizarRegimenes()
        {
            TxtTotal.Text = liquidacionCuotaModeradoraService.TotalizarAfiliacion().ToString();
            TxtContributivo.Text = liquidacionCuotaModeradoraService.TotalizarPorTipo("Contributivo").ToString();
            TxtSubsidiado.Text = liquidacionCuotaModeradoraService.TotalizarPorTipo("Subsidiado").ToString();
        }
        private void SumarRegimenes()
        {
            TxtValorTotal.Text = liquidacionCuotaModeradoraService.SumarLiquidaciones().ToString();
            TxtValorContributivo.Text = liquidacionCuotaModeradoraService.SumarPorTipo("Contributivo").ToString();
            TxtValorSubsidiado.Text = liquidacionCuotaModeradoraService.SumarPorTipo("Subsidiado").ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TblVista.DataSource = liquidacionCuotaModeradoraService.BuscarPorNombre(TxtConsultaNombre.Text.Trim());
        }
    }
}
