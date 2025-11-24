using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Aplicación_financiera_para_estudiantes
{
    public partial class FrmPresupuesto : Form
    {      

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

            CargarPresupuesto();
           
        }

        private void dgvPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPresupuestos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPresupuestos.Columns["Presupuesto"].Index || e.ColumnIndex == dgvPresupuestos.Columns["Gasto"].Index)
            {
                decimal presupuesto = 0, gasto = 0;

                decimal.TryParse(dgvPresupuestos.Rows[e.RowIndex].Cells["Presupuesto"].Value?.ToString(), out presupuesto);
                decimal.TryParse(dgvPresupuestos.Rows[e.RowIndex].Cells["Gasto"].Value?.ToString(), out gasto);

                dgvPresupuestos.Rows[e.RowIndex].Cells["Diferencia"].Value = presupuesto - gasto;
            } 

            CalcularTotales();
            GuardarPresupuesto();
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
                AjustarPresupuesto("mensual");
            }
        }

        private void rdoSemanal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSemanal.Checked)
            {
                AjustarPresupuesto("Semanal");
            }
        }

        private void AjustarPresupuesto(string tipo)
        {
            foreach (DataGridViewRow row in dgvPresupuestos.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal baseValue = Convert.ToDecimal(row.Cells["Presupuesto"].Value);

                    if (tipo == "mensual")
                        row.Cells["Presupuesto"].Value = baseValue * 4;
                    else
                        row.Cells["Presupuesto"].Value = baseValue / 4;
                }
            }
            CalcularTotales();

        }


        public class ItemPresupuesto
        {
            public string Categoria { get; set; }
            public decimal Presupuesto { get; set; }
            public decimal Gasto { get; set; }
            public decimal Diferencia { get; set; }
        }

        private List<ItemPresupuesto> ObtenerListaPresupuesto()
        {
            List<ItemPresupuesto> lista = new List<ItemPresupuesto>();

            foreach (DataGridViewRow row in dgvPresupuestos.Rows)
            {
                if (!row.IsNewRow)
                {
                    lista.Add(new ItemPresupuesto
                    {
                        Categoria = row.Cells["Categoria"].Value?.ToString(),
                        Presupuesto = Convert.ToDecimal(row.Cells["Presupuesto"].Value),
                        Gasto = Convert.ToDecimal(row.Cells["Gasto"].Value),
                        Diferencia = Convert.ToDecimal(row.Cells["Diferencia"].Value)
                    });
                }
            }

            return lista;
        }

        private void GuardarPresupuesto()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "presupuesto.json");

            var lista = ObtenerListaPresupuesto(); 
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);

            File.WriteAllText(ruta, json);
        }


        private void CargarPresupuesto()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "presupuesto.json");

            if (!File.Exists(ruta))
                return;

            var lista = JsonConvert.DeserializeObject<List<ItemPresupuesto>>(File.ReadAllText(ruta));
            dgvPresupuestos.Rows.Clear();

            foreach (var item in lista)
            {
                dgvPresupuestos.Rows.Add(item.Categoria, item.Presupuesto, item.Gasto, item.Diferencia);
            }

        }

        private void dgvPresupuestos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; 
                SendKeys.Send("{TAB}"); 
            }
        }
    }    
}

