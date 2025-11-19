using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_financiera_para_estudiantes
{
    public partial class FrmPresupuesto : Form
    {
        private string tipoPresupuesto;

        public FrmPresupuesto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvPresupuestos.Rows.Add("Alimentación");
            this.dgvPresupuestos.Rows.Add("Transporte");
            this.dgvPresupuestos.Rows.Add("Vivienda");
            this.dgvPresupuestos.Rows.Add("Educación");
            this.dgvPresupuestos.Rows.Add("Entretenimiento");
            this.dgvPresupuestos.Rows.Add("Salud");
            this.dgvPresupuestos.Rows.Add("Otros");
        }

        private void dgvPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void dgvPresupuestos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPresupuestos.Columns["Presupuesto"].Index || e.ColumnIndex == dgvPresupuestos.Columns["Gasto"].Index)
            {
                try
                {
                    decimal presupuesto = Convert.ToDecimal(dgvPresupuestos.Rows[e.RowIndex].Cells["Presupuesto"].Value);
                    decimal gasto = Convert.ToDecimal(dgvPresupuestos.Rows[e.RowIndex].Cells["Gasto"].Value);

                    dgvPresupuestos.Rows[e.RowIndex].Cells["Diferencia"].Value = presupuesto - gasto;
                }
                catch
                {
                    dgvPresupuestos.Rows[e.RowIndex].Cells["Diferencia"].Value = "0.00";
                }
            }

            CalcularTotales();
        }

        private void CalcularTotales()
        {
            decimal totalPresupuesto = 0;
            decimal totalGasto = 0;
            decimal totalDiferencia = 0;

            foreach (DataGridViewRow row in dgvPresupuestos.Rows)
            {
                if (!row.IsNewRow)
                {
                    totalPresupuesto += Convert.ToDecimal(row.Cells["Presupuesto"].Value);
                    totalGasto += Convert.ToDecimal(row.Cells["Gasto"].Value);
                    totalDiferencia += Convert.ToDecimal(row.Cells["Diferencia"].Value);
                }
            }

            txtTotalPresupuesto.Text = totalPresupuesto.ToString("0.00");
            txtTotalGasto.Text = totalGasto.ToString("0.00");
            txtTotalDiferencia.Text = totalDiferencia.ToString("0.00");
        }

        private void rdoMensual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMensual.Checked)
            {
                tipoPresupuesto = "Mensual";
                AjustarPresupuestoPorTipo();
            }
        }

        private void rdoSemanal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSemanal.Checked)
            {
                tipoPresupuesto = "Semanal";
                AjustarPresupuestoPorTipo();
            }
        }

        private void AjustarPresupuestoPorTipo()
        {
            foreach (DataGridViewRow row in dgvPresupuestos.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal valorBase = Convert.ToDecimal(row.Cells["Presupuesto"].Tag ?? 0);
                    row.Cells["Presupuesto"].Value = tipoPresupuesto == "Mensual" ? valorBase * 4 : valorBase;
                }
            }
            CalcularTotales();

        }
    }
        
}
