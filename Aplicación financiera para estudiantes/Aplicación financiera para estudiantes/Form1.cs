using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "presupuesto.json");

            if (File.Exists(ruta))
            {
                CargarPresupuesto();
            }
            else
            {
                string[] categorias = { "Alimentación", "Transporte", "Vivienda", "Educación", "Entretenimiento", "Salud", "Otros" };
                dgvPresupuestos.Rows.Clear();

                foreach (string cat in categorias)
                    dgvPresupuestos.Rows.Add(cat, 0, 0, 0);

                GuardarPresupuesto();
            }
        }

        private void dgvPresupuestos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPresupuestos.Columns["Gasto"].Index ||
                e.ColumnIndex == dgvPresupuestos.Columns["Presupuesto"].Index)
            {
                decimal.TryParse(dgvPresupuestos.Rows[e.RowIndex].Cells["Presupuesto"].Value?.ToString(), out decimal presupuesto);
                decimal.TryParse(dgvPresupuestos.Rows[e.RowIndex].Cells["Gasto"].Value?.ToString(), out decimal gasto);

                dgvPresupuestos.Rows[e.RowIndex].Cells["Diferencia"].Value = presupuesto - gasto;
            }

            CalcularTotales();
            GuardarPresupuesto();
        }

        private void CalcularTotales()
        {
            decimal totalPresupuesto = 0, totalGasto = 0, totalDiferencia = 0;

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

        public class ItemPresupuesto
        {
            public string Categoria { get; set; }
            public decimal Presupuesto { get; set; }
            public decimal Gasto { get; set; }
            public decimal Diferencia { get; set; }
            public string Mes { get; set; }
        
        }

        private List<ItemPresupuesto> ObtenerListaPresupuesto()
        {
            var lista = new List<ItemPresupuesto>();
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
            string json = JsonConvert.SerializeObject(ObtenerListaPresupuesto(), Formatting.Indented);
            File.WriteAllText(ruta, json);
        }

        private void CargarPresupuesto()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "presupuesto.json");
            if (!File.Exists(ruta)) return;

            var lista = JsonConvert.DeserializeObject<List<ItemPresupuesto>>(File.ReadAllText(ruta));
            dgvPresupuestos.Rows.Clear();

            foreach (var item in lista)
                dgvPresupuestos.Rows.Add(item.Categoria, item.Presupuesto, item.Gasto, item.Diferencia);
        }

        public void AgregarGasto(string categoria, decimal monto)
        {
            foreach (DataGridViewRow row in dgvPresupuestos.Rows)
            {
                if (row.Cells["Categoria"].Value.ToString() == categoria)
                {
                    decimal gastoActual = Convert.ToDecimal(row.Cells["Gasto"].Value);
                    row.Cells["Gasto"].Value = gastoActual + monto;

                    decimal presupuesto = Convert.ToDecimal(row.Cells["Presupuesto"].Value);
                    row.Cells["Diferencia"].Value = presupuesto - (gastoActual + monto);

                    CalcularTotales();
                    GuardarPresupuesto();
                    return;
                }
            }
        }

        private void btnAbrirGastos_Click(object sender, EventArgs e)
        {
            FrmGastos frm = new FrmGastos(this);
            frm.ShowDialog();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPresupuestos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dgvPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
