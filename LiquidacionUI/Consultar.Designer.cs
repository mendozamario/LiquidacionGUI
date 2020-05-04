namespace LiquidacionUI
{
    partial class Consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.TblVista = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblSubsidiado = new System.Windows.Forms.Label();
            this.LblContributivo = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtSubsidiado = new System.Windows.Forms.TextBox();
            this.TxtContributivo = new System.Windows.Forms.TextBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.TxtValorContributivo = new System.Windows.Forms.TextBox();
            this.TxtValorSubsidiado = new System.Windows.Forms.TextBox();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.LblValorContributivo = new System.Windows.Forms.Label();
            this.LblValorSubsidiado = new System.Windows.Forms.Label();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.TxtConsultaNombre = new System.Windows.Forms.TextBox();
            this.LblNombrePaciente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TblVista)).BeginInit();
            this.SuspendLayout();
            // 
            // TblVista
            // 
            this.TblVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblVista.Location = new System.Drawing.Point(12, 33);
            this.TblVista.Name = "TblVista";
            this.TblVista.Size = new System.Drawing.Size(1049, 177);
            this.TblVista.TabIndex = 0;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F);
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConsultar.Location = new System.Drawing.Point(818, 283);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(160, 59);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F);
            this.LblTotal.Location = new System.Drawing.Point(25, 236);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(55, 25);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "Total:";
            // 
            // LblSubsidiado
            // 
            this.LblSubsidiado.AutoSize = true;
            this.LblSubsidiado.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F);
            this.LblSubsidiado.Location = new System.Drawing.Point(155, 236);
            this.LblSubsidiado.Name = "LblSubsidiado";
            this.LblSubsidiado.Size = new System.Drawing.Size(106, 25);
            this.LblSubsidiado.TabIndex = 3;
            this.LblSubsidiado.Text = "Subsidiado:";
            // 
            // LblContributivo
            // 
            this.LblContributivo.AutoSize = true;
            this.LblContributivo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F);
            this.LblContributivo.Location = new System.Drawing.Point(352, 236);
            this.LblContributivo.Name = "LblContributivo";
            this.LblContributivo.Size = new System.Drawing.Size(116, 25);
            this.LblContributivo.TabIndex = 4;
            this.LblContributivo.Text = "Contributivo:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(86, 240);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(51, 20);
            this.TxtTotal.TabIndex = 5;
            // 
            // TxtSubsidiado
            // 
            this.TxtSubsidiado.Location = new System.Drawing.Point(267, 240);
            this.TxtSubsidiado.Name = "TxtSubsidiado";
            this.TxtSubsidiado.Size = new System.Drawing.Size(51, 20);
            this.TxtSubsidiado.TabIndex = 6;
            // 
            // TxtContributivo
            // 
            this.TxtContributivo.Location = new System.Drawing.Point(474, 240);
            this.TxtContributivo.Name = "TxtContributivo";
            this.TxtContributivo.Size = new System.Drawing.Size(51, 20);
            this.TxtContributivo.TabIndex = 7;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F);
            this.LblTipo.Location = new System.Drawing.Point(25, 367);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(50, 25);
            this.LblTipo.TabIndex = 8;
            this.LblTipo.Text = "Tipo:";
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Todos",
            "Subsidiado",
            "Contributivo"});
            this.CmbTipo.Location = new System.Drawing.Point(100, 367);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 21);
            this.CmbTipo.TabIndex = 9;
            // 
            // TxtValorContributivo
            // 
            this.TxtValorContributivo.Location = new System.Drawing.Point(696, 307);
            this.TxtValorContributivo.Name = "TxtValorContributivo";
            this.TxtValorContributivo.Size = new System.Drawing.Size(87, 20);
            this.TxtValorContributivo.TabIndex = 15;
            // 
            // TxtValorSubsidiado
            // 
            this.TxtValorSubsidiado.Location = new System.Drawing.Point(406, 307);
            this.TxtValorSubsidiado.Name = "TxtValorSubsidiado";
            this.TxtValorSubsidiado.Size = new System.Drawing.Size(87, 20);
            this.TxtValorSubsidiado.TabIndex = 14;
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Location = new System.Drawing.Point(131, 308);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(87, 20);
            this.TxtValorTotal.TabIndex = 13;
            // 
            // LblValorContributivo
            // 
            this.LblValorContributivo.AutoSize = true;
            this.LblValorContributivo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F);
            this.LblValorContributivo.Location = new System.Drawing.Point(529, 303);
            this.LblValorContributivo.Name = "LblValorContributivo";
            this.LblValorContributivo.Size = new System.Drawing.Size(161, 25);
            this.LblValorContributivo.TabIndex = 12;
            this.LblValorContributivo.Text = "Valor contributivo:";
            // 
            // LblValorSubsidiado
            // 
            this.LblValorSubsidiado.AutoSize = true;
            this.LblValorSubsidiado.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F);
            this.LblValorSubsidiado.Location = new System.Drawing.Point(249, 303);
            this.LblValorSubsidiado.Name = "LblValorSubsidiado";
            this.LblValorSubsidiado.Size = new System.Drawing.Size(151, 25);
            this.LblValorSubsidiado.TabIndex = 11;
            this.LblValorSubsidiado.Text = "Valor subsidiado:";
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F);
            this.LblValorTotal.Location = new System.Drawing.Point(25, 303);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(100, 25);
            this.LblValorTotal.TabIndex = 10;
            this.LblValorTotal.Text = "Valor total:";
            // 
            // TxtConsultaNombre
            // 
            this.TxtConsultaNombre.Location = new System.Drawing.Point(455, 374);
            this.TxtConsultaNombre.Name = "TxtConsultaNombre";
            this.TxtConsultaNombre.Size = new System.Drawing.Size(175, 20);
            this.TxtConsultaNombre.TabIndex = 16;
            this.TxtConsultaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // LblNombrePaciente
            // 
            this.LblNombrePaciente.AutoSize = true;
            this.LblNombrePaciente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F);
            this.LblNombrePaciente.Location = new System.Drawing.Point(262, 367);
            this.LblNombrePaciente.Name = "LblNombrePaciente";
            this.LblNombrePaciente.Size = new System.Drawing.Size(187, 25);
            this.LblNombrePaciente.TabIndex = 17;
            this.LblNombrePaciente.Text = "Nombre del paciente:";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.LblNombrePaciente);
            this.Controls.Add(this.TxtConsultaNombre);
            this.Controls.Add(this.TxtValorContributivo);
            this.Controls.Add(this.TxtValorSubsidiado);
            this.Controls.Add(this.TxtValorTotal);
            this.Controls.Add(this.LblValorContributivo);
            this.Controls.Add(this.LblValorSubsidiado);
            this.Controls.Add(this.LblValorTotal);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.TxtContributivo);
            this.Controls.Add(this.TxtSubsidiado);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblContributivo);
            this.Controls.Add(this.LblSubsidiado);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TblVista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.TblVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TblVista;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblSubsidiado;
        private System.Windows.Forms.Label LblContributivo;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtSubsidiado;
        private System.Windows.Forms.TextBox TxtContributivo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.TextBox TxtValorContributivo;
        private System.Windows.Forms.TextBox TxtValorSubsidiado;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label LblValorContributivo;
        private System.Windows.Forms.Label LblValorSubsidiado;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.TextBox TxtConsultaNombre;
        private System.Windows.Forms.Label LblNombrePaciente;
    }
}