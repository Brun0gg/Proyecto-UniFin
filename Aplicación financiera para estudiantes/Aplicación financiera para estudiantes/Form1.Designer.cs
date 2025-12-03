namespace Aplicación_financiera_para_estudiantes
{
    partial class FrmPresupuesto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresupuesto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPresupuestos = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalPresupuesto = new System.Windows.Forms.TextBox();
            this.txtTotalDiferencia = new System.Windows.Forms.TextBox();
            this.txtTotalGasto = new System.Windows.Forms.TextBox();
            this.btnAbrirGastos = new System.Windows.Forms.Button();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblPresupuesto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 66);
            this.panel1.TabIndex = 4;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPresupuesto.Location = new System.Drawing.Point(34, 20);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(241, 25);
            this.lblPresupuesto.TabIndex = 4;
            this.lblPresupuesto.Text = "Gestión de presupuesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(498, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo restante / Exceso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total gastado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total presupuesto";
            // 
            // dgvPresupuestos
            // 
            this.dgvPresupuestos.AllowUserToAddRows = false;
            this.dgvPresupuestos.AllowUserToDeleteRows = false;
            this.dgvPresupuestos.AllowUserToResizeColumns = false;
            this.dgvPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresupuestos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPresupuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.Presupuesto,
            this.Gasto,
            this.Diferencia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPresupuestos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPresupuestos.EnableHeadersVisualStyles = false;
            this.dgvPresupuestos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.dgvPresupuestos.Location = new System.Drawing.Point(51, 273);
            this.dgvPresupuestos.Name = "dgvPresupuestos";
            this.dgvPresupuestos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPresupuestos.RowHeadersVisible = false;
            this.dgvPresupuestos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.dgvPresupuestos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPresupuestos.RowTemplate.Height = 35;
            this.dgvPresupuestos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPresupuestos.Size = new System.Drawing.Size(687, 266);
            this.dgvPresupuestos.TabIndex = 8;
            this.dgvPresupuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresupuestos_CellContentClick);
            this.dgvPresupuestos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresupuestos_CellEndEdit);
            this.dgvPresupuestos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPresupuestos_KeyDown);
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Presupuesto
            // 
            this.Presupuesto.HeaderText = "Presupuesto";
            this.Presupuesto.Name = "Presupuesto";
            // 
            // Gasto
            // 
            this.Gasto.HeaderText = "Gasto";
            this.Gasto.Name = "Gasto";
            // 
            // Diferencia
            // 
            this.Diferencia.HeaderText = "Diferencia";
            this.Diferencia.Name = "Diferencia";
            this.Diferencia.ReadOnly = true;
            // 
            // txtTotalPresupuesto
            // 
            this.txtTotalPresupuesto.Enabled = false;
            this.txtTotalPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPresupuesto.Location = new System.Drawing.Point(32, 106);
            this.txtTotalPresupuesto.Name = "txtTotalPresupuesto";
            this.txtTotalPresupuesto.Size = new System.Drawing.Size(161, 29);
            this.txtTotalPresupuesto.TabIndex = 10;
            // 
            // txtTotalDiferencia
            // 
            this.txtTotalDiferencia.Enabled = false;
            this.txtTotalDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDiferencia.Location = new System.Drawing.Point(555, 106);
            this.txtTotalDiferencia.Name = "txtTotalDiferencia";
            this.txtTotalDiferencia.Size = new System.Drawing.Size(161, 29);
            this.txtTotalDiferencia.TabIndex = 11;
            // 
            // txtTotalGasto
            // 
            this.txtTotalGasto.Enabled = false;
            this.txtTotalGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGasto.Location = new System.Drawing.Point(308, 106);
            this.txtTotalGasto.Name = "txtTotalGasto";
            this.txtTotalGasto.Size = new System.Drawing.Size(161, 29);
            this.txtTotalGasto.TabIndex = 12;
            // 
            // btnAbrirGastos
            // 
            this.btnAbrirGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnAbrirGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirGastos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAbrirGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAbrirGastos.Location = new System.Drawing.Point(384, 561);
            this.btnAbrirGastos.Name = "btnAbrirGastos";
            this.btnAbrirGastos.Size = new System.Drawing.Size(153, 37);
            this.btnAbrirGastos.TabIndex = 14;
            this.btnAbrirGastos.Text = "Gastos";
            this.btnAbrirGastos.UseVisualStyleBackColor = false;
            this.btnAbrirGastos.Click += new System.EventHandler(this.btnAbrirGastos_Click);
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalirMenu.ForeColor = System.Drawing.Color.Red;
            this.btnSalirMenu.Location = new System.Drawing.Point(585, 562);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(153, 36);
            this.btnSalirMenu.TabIndex = 15;
            this.btnSalirMenu.Text = "Cerrar";
            this.btnSalirMenu.UseVisualStyleBackColor = false;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // FrmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.btnSalirMenu);
            this.Controls.Add(this.btnAbrirGastos);
            this.Controls.Add(this.txtTotalGasto);
            this.Controls.Add(this.txtTotalDiferencia);
            this.Controls.Add(this.txtTotalPresupuesto);
            this.Controls.Add(this.dgvPresupuestos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPresupuesto";
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPresupuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferencia;
        private System.Windows.Forms.TextBox txtTotalPresupuesto;
        private System.Windows.Forms.TextBox txtTotalDiferencia;
        private System.Windows.Forms.TextBox txtTotalGasto;
        private System.Windows.Forms.Button btnAbrirGastos;
        private System.Windows.Forms.Button btnSalirMenu;
    }
}

