namespace Aplicación_financiera_para_estudiantes
{
    partial class FrmMenuPrincipal
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
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Location = new System.Drawing.Point(185, 102);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(132, 36);
            this.btnPresupuesto.TabIndex = 0;
            this.btnPresupuesto.Text = "Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Location = new System.Drawing.Point(185, 184);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(132, 36);
            this.btnGastos.TabIndex = 1;
            this.btnGastos.Text = "Gasto";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGastos);
            this.Controls.Add(this.btnPresupuesto);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btnGastos;
    }
}