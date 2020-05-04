﻿using System;
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
            }
            catch (Exception)
            {
                string mensaje = "Los datos son incongruentes";
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            string numeroLiquidacion = TxtNumeroLiquidacion.Text;
            lcm = liquidacionCuotaModeradoraService.BuscarPorLiquidacion(numeroLiquidacion);
            liquidacionCuotaModeradoraService.BuscarPorLiquidacion(numeroLiquidacion).
            TxtNombrePaciente.Text = lcm.NombrePaciente;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string numeroLiquidacion;
            numeroLiquidacion = TxtNumeroLiquidacion.Text;

            liquidacionCuotaModeradoraService.Eliminar(numeroLiquidacion);
        }
    }
}
