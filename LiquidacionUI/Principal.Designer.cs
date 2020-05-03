namespace LiquidacionUI
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.LblNumeroLiquidacion = new System.Windows.Forms.Label();
            this.LblIdentificacionPaciente = new System.Windows.Forms.Label();
            this.LblNombrePaciente = new System.Windows.Forms.Label();
            this.LblTipoAfiliacion = new System.Windows.Forms.Label();
            this.LblSalarioDevengado = new System.Windows.Forms.Label();
            this.LblValorServicio = new System.Windows.Forms.Label();
            this.LblCuotaModeradora = new System.Windows.Forms.Label();
            this.TxtNumeroLiquidacion = new System.Windows.Forms.TextBox();
            this.TxtValorServicio = new System.Windows.Forms.TextBox();
            this.TxtCuotaModeradora = new System.Windows.Forms.TextBox();
            this.TxtSalarioDevengado = new System.Windows.Forms.TextBox();
            this.TxtNombrePaciente = new System.Windows.Forms.TextBox();
            this.TxtIdentificacionPaciente = new System.Windows.Forms.TextBox();
            this.CmbTipoAfiliacion = new System.Windows.Forms.ComboBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNumeroLiquidacion
            // 
            this.LblNumeroLiquidacion.AutoSize = true;
            this.LblNumeroLiquidacion.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroLiquidacion.Location = new System.Drawing.Point(10, 9);
            this.LblNumeroLiquidacion.Name = "LblNumeroLiquidacion";
            this.LblNumeroLiquidacion.Size = new System.Drawing.Size(201, 25);
            this.LblNumeroLiquidacion.TabIndex = 0;
            this.LblNumeroLiquidacion.Text = "Numero de liquidacion:";
            // 
            // LblIdentificacionPaciente
            // 
            this.LblIdentificacionPaciente.AutoSize = true;
            this.LblIdentificacionPaciente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdentificacionPaciente.Location = new System.Drawing.Point(10, 45);
            this.LblIdentificacionPaciente.Name = "LblIdentificacionPaciente";
            this.LblIdentificacionPaciente.Size = new System.Drawing.Size(201, 25);
            this.LblIdentificacionPaciente.TabIndex = 1;
            this.LblIdentificacionPaciente.Text = "Identificación paciente:";
            // 
            // LblNombrePaciente
            // 
            this.LblNombrePaciente.AutoSize = true;
            this.LblNombrePaciente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePaciente.Location = new System.Drawing.Point(54, 81);
            this.LblNombrePaciente.Name = "LblNombrePaciente";
            this.LblNombrePaciente.Size = new System.Drawing.Size(157, 25);
            this.LblNombrePaciente.TabIndex = 2;
            this.LblNombrePaciente.Text = "Nombre paciente:";
            // 
            // LblTipoAfiliacion
            // 
            this.LblTipoAfiliacion.AutoSize = true;
            this.LblTipoAfiliacion.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoAfiliacion.Location = new System.Drawing.Point(56, 119);
            this.LblTipoAfiliacion.Name = "LblTipoAfiliacion";
            this.LblTipoAfiliacion.Size = new System.Drawing.Size(155, 25);
            this.LblTipoAfiliacion.TabIndex = 3;
            this.LblTipoAfiliacion.Text = "Tipo de afiliación:";
            // 
            // LblSalarioDevengado
            // 
            this.LblSalarioDevengado.AutoSize = true;
            this.LblSalarioDevengado.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalarioDevengado.Location = new System.Drawing.Point(42, 161);
            this.LblSalarioDevengado.Name = "LblSalarioDevengado";
            this.LblSalarioDevengado.Size = new System.Drawing.Size(169, 25);
            this.LblSalarioDevengado.TabIndex = 4;
            this.LblSalarioDevengado.Text = "Salario devengado:";
            // 
            // LblValorServicio
            // 
            this.LblValorServicio.AutoSize = true;
            this.LblValorServicio.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorServicio.Location = new System.Drawing.Point(53, 202);
            this.LblValorServicio.Name = "LblValorServicio";
            this.LblValorServicio.Size = new System.Drawing.Size(158, 25);
            this.LblValorServicio.TabIndex = 5;
            this.LblValorServicio.Text = "Valor del servicio:";
            // 
            // LblCuotaModeradora
            // 
            this.LblCuotaModeradora.AutoSize = true;
            this.LblCuotaModeradora.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuotaModeradora.Location = new System.Drawing.Point(41, 276);
            this.LblCuotaModeradora.Name = "LblCuotaModeradora";
            this.LblCuotaModeradora.Size = new System.Drawing.Size(170, 25);
            this.LblCuotaModeradora.TabIndex = 6;
            this.LblCuotaModeradora.Text = "Cuota moderadora:";
            // 
            // TxtNumeroLiquidacion
            // 
            this.TxtNumeroLiquidacion.Location = new System.Drawing.Point(217, 15);
            this.TxtNumeroLiquidacion.Name = "TxtNumeroLiquidacion";
            this.TxtNumeroLiquidacion.Size = new System.Drawing.Size(216, 20);
            this.TxtNumeroLiquidacion.TabIndex = 7;
            // 
            // TxtValorServicio
            // 
            this.TxtValorServicio.Location = new System.Drawing.Point(217, 207);
            this.TxtValorServicio.Name = "TxtValorServicio";
            this.TxtValorServicio.Size = new System.Drawing.Size(216, 20);
            this.TxtValorServicio.TabIndex = 8;
            // 
            // TxtCuotaModeradora
            // 
            this.TxtCuotaModeradora.Enabled = false;
            this.TxtCuotaModeradora.Location = new System.Drawing.Point(217, 281);
            this.TxtCuotaModeradora.Name = "TxtCuotaModeradora";
            this.TxtCuotaModeradora.Size = new System.Drawing.Size(128, 20);
            this.TxtCuotaModeradora.TabIndex = 9;
            // 
            // TxtSalarioDevengado
            // 
            this.TxtSalarioDevengado.Location = new System.Drawing.Point(217, 166);
            this.TxtSalarioDevengado.Name = "TxtSalarioDevengado";
            this.TxtSalarioDevengado.Size = new System.Drawing.Size(216, 20);
            this.TxtSalarioDevengado.TabIndex = 10;
            // 
            // TxtNombrePaciente
            // 
            this.TxtNombrePaciente.Location = new System.Drawing.Point(217, 86);
            this.TxtNombrePaciente.Name = "TxtNombrePaciente";
            this.TxtNombrePaciente.Size = new System.Drawing.Size(216, 20);
            this.TxtNombrePaciente.TabIndex = 11;
            // 
            // TxtIdentificacionPaciente
            // 
            this.TxtIdentificacionPaciente.Location = new System.Drawing.Point(217, 50);
            this.TxtIdentificacionPaciente.Name = "TxtIdentificacionPaciente";
            this.TxtIdentificacionPaciente.Size = new System.Drawing.Size(216, 20);
            this.TxtIdentificacionPaciente.TabIndex = 12;
            // 
            // CmbTipoAfiliacion
            // 
            this.CmbTipoAfiliacion.FormattingEnabled = true;
            this.CmbTipoAfiliacion.Items.AddRange(new object[] {
            "Subsidiado",
            "Contributivo"});
            this.CmbTipoAfiliacion.Location = new System.Drawing.Point(217, 123);
            this.CmbTipoAfiliacion.Name = "CmbTipoAfiliacion";
            this.CmbTipoAfiliacion.Size = new System.Drawing.Size(216, 21);
            this.CmbTipoAfiliacion.TabIndex = 13;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.FlatAppearance.BorderSize = 0;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.Image")));
            this.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCalcular.Location = new System.Drawing.Point(351, 260);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(90, 64);
            this.BtnCalcular.TabIndex = 14;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(35, 323);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 63);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConsultar.Location = new System.Drawing.Point(126, 323);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(85, 63);
            this.BtnConsultar.TabIndex = 16;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(217, 323);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 63);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 398);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.CmbTipoAfiliacion);
            this.Controls.Add(this.TxtIdentificacionPaciente);
            this.Controls.Add(this.TxtNombrePaciente);
            this.Controls.Add(this.TxtSalarioDevengado);
            this.Controls.Add(this.TxtCuotaModeradora);
            this.Controls.Add(this.TxtValorServicio);
            this.Controls.Add(this.TxtNumeroLiquidacion);
            this.Controls.Add(this.LblCuotaModeradora);
            this.Controls.Add(this.LblValorServicio);
            this.Controls.Add(this.LblSalarioDevengado);
            this.Controls.Add(this.LblTipoAfiliacion);
            this.Controls.Add(this.LblNombrePaciente);
            this.Controls.Add(this.LblIdentificacionPaciente);
            this.Controls.Add(this.LblNumeroLiquidacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumeroLiquidacion;
        private System.Windows.Forms.Label LblIdentificacionPaciente;
        private System.Windows.Forms.Label LblNombrePaciente;
        private System.Windows.Forms.Label LblTipoAfiliacion;
        private System.Windows.Forms.Label LblSalarioDevengado;
        private System.Windows.Forms.Label LblValorServicio;
        private System.Windows.Forms.Label LblCuotaModeradora;
        private System.Windows.Forms.TextBox TxtNumeroLiquidacion;
        private System.Windows.Forms.TextBox TxtValorServicio;
        private System.Windows.Forms.TextBox TxtCuotaModeradora;
        private System.Windows.Forms.TextBox TxtSalarioDevengado;
        private System.Windows.Forms.TextBox TxtNombrePaciente;
        private System.Windows.Forms.TextBox TxtIdentificacionPaciente;
        private System.Windows.Forms.ComboBox CmbTipoAfiliacion;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}

