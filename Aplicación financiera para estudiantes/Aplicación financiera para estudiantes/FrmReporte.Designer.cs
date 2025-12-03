namespace Aplicación_financiera_para_estudiantes
{
    partial class FrmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbSemana = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.Gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalPresupuesto = new System.Windows.Forms.Label();
            this.lblTotalGasto = new System.Windows.Forms.Label();
            this.lblCategoriaMayorGasto = new System.Windows.Forms.Label();
            this.lblPorcentajeUsado = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(32, 79);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 1;
            // 
            // cmbSemana
            // 
            this.cmbSemana.FormattingEnabled = true;
            this.cmbSemana.Items.AddRange(new object[] {
            "Semana 1",
            "Semana 2",
            "Semana 3",
            "Semana 4"});
            this.cmbSemana.Location = new System.Drawing.Point(199, 79);
            this.cmbSemana.Name = "cmbSemana";
            this.cmbSemana.Size = new System.Drawing.Size(121, 21);
            this.cmbSemana.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerar.Location = new System.Drawing.Point(115, 177);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(109, 52);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gasto,
            this.Categoria,
            this.Monto,
            this.Fecha});
            this.dgvReporte.Location = new System.Drawing.Point(358, 58);
            this.dgvReporte.MultiSelect = false;
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.Size = new System.Drawing.Size(443, 338);
            this.dgvReporte.TabIndex = 4;
            // 
            // Gasto
            // 
            this.Gasto.HeaderText = "Gasto";
            this.Gasto.Name = "Gasto";
            this.Gasto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // lblTotalPresupuesto
            // 
            this.lblTotalPresupuesto.AutoSize = true;
            this.lblTotalPresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPresupuesto.ForeColor = System.Drawing.Color.White;
            this.lblTotalPresupuesto.Location = new System.Drawing.Point(28, 299);
            this.lblTotalPresupuesto.Name = "lblTotalPresupuesto";
            this.lblTotalPresupuesto.Size = new System.Drawing.Size(154, 20);
            this.lblTotalPresupuesto.TabIndex = 5;
            this.lblTotalPresupuesto.Text = "Total presupuesto";
            this.lblTotalPresupuesto.Click += new System.EventHandler(this.lblTotalPresupuesto_Click);
            // 
            // lblTotalGasto
            // 
            this.lblTotalGasto.AutoSize = true;
            this.lblTotalGasto.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGasto.ForeColor = System.Drawing.Color.White;
            this.lblTotalGasto.Location = new System.Drawing.Point(28, 270);
            this.lblTotalGasto.Name = "lblTotalGasto";
            this.lblTotalGasto.Size = new System.Drawing.Size(99, 20);
            this.lblTotalGasto.TabIndex = 6;
            this.lblTotalGasto.Text = "Total gasto";
            // 
            // lblCategoriaMayorGasto
            // 
            this.lblCategoriaMayorGasto.AutoSize = true;
            this.lblCategoriaMayorGasto.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaMayorGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaMayorGasto.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaMayorGasto.Location = new System.Drawing.Point(28, 361);
            this.lblCategoriaMayorGasto.Name = "lblCategoriaMayorGasto";
            this.lblCategoriaMayorGasto.Size = new System.Drawing.Size(107, 20);
            this.lblCategoriaMayorGasto.TabIndex = 7;
            this.lblCategoriaMayorGasto.Text = "Mayor gasto";
            // 
            // lblPorcentajeUsado
            // 
            this.lblPorcentajeUsado.AutoSize = true;
            this.lblPorcentajeUsado.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentajeUsado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeUsado.ForeColor = System.Drawing.Color.White;
            this.lblPorcentajeUsado.Location = new System.Drawing.Point(28, 390);
            this.lblPorcentajeUsado.Name = "lblPorcentajeUsado";
            this.lblPorcentajeUsado.Size = new System.Drawing.Size(149, 20);
            this.lblPorcentajeUsado.TabIndex = 8;
            this.lblPorcentajeUsado.Text = "Porcentaje usado";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.BackColor = System.Drawing.Color.Transparent;
            this.lblDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.ForeColor = System.Drawing.Color.White;
            this.lblDiferencia.Location = new System.Drawing.Point(28, 332);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(91, 20);
            this.lblDiferencia.TabIndex = 9;
            this.lblDiferencia.Text = "Diferencia";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPresupuesto.Location = new System.Drawing.Point(36, 20);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(188, 25);
            this.lblPresupuesto.TabIndex = 14;
            this.lblPresupuesto.Text = "Reporte de gastos";
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.lblDiferencia);
            this.Controls.Add(this.lblPorcentajeUsado);
            this.Controls.Add(this.lblCategoriaMayorGasto);
            this.Controls.Add(this.lblTotalGasto);
            this.Controls.Add(this.lblTotalPresupuesto);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbSemana);
            this.Controls.Add(this.cmbMes);
            this.Name = "FrmReporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbSemana;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Label lblTotalPresupuesto;
        private System.Windows.Forms.Label lblTotalGasto;
        private System.Windows.Forms.Label lblCategoriaMayorGasto;
        private System.Windows.Forms.Label lblPorcentajeUsado;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label lblPresupuesto;
    }
}