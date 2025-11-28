using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_financiera_para_estudiantes
{
    public partial class FrmGastos : Form
    {
        private FrmPresupuesto frmPresupuesto;
        public FrmGastos(FrmPresupuesto frm)
        {
            InitializeComponent();
            frmPresupuesto = frm;
        }

        public class Gasto
        {
            public string Nombre { get; set; }
            public decimal Monto { get; set; }
            public string Categoria { get; set; }
            public string Fecha { get; set; }
        }


        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.Text;
            decimal monto = decimal.Parse(txtMonto.Text);

          
            frmPresupuesto.AgregarGasto(categoria, monto);

            dgvGastos.Rows.Add(txtNombreGasto.Text, monto, categoria, dtpFecha.Value.ToShortDateString());


            txtNombreGasto.Clear();
            txtMonto.Clear();
        }

        private void GuardarGastosEnJson()
        {
            var gastos = new List<Gasto>();

            foreach (DataGridViewRow row in dgvGastos.Rows)
            {
                if (!row.IsNewRow)
                {
                    gastos.Add(new Gasto
                    {
                        Nombre = row.Cells[0].Value.ToString(),
                        Monto = Convert.ToDecimal(row.Cells[1].Value),
                        Categoria = row.Cells[2].Value.ToString(),
                        Fecha = row.Cells[3].Value.ToString()
                    });
                }
            }

            string ruta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "gastos.json"
            );

            File.WriteAllText(ruta, JsonConvert.SerializeObject(gastos));
        }

        private void CargarGastos()
        {
            string ruta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "gastos.json"
            );

            if (!File.Exists(ruta))
                return;

            var lista = JsonConvert.DeserializeObject<List<Gasto>>(File.ReadAllText(ruta));

            dgvGastos.Rows.Clear();

            foreach (var g in lista)
            {
                dgvGastos.Rows.Add(g.Nombre, g.Monto, g.Categoria, g.Fecha);
            }
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {
                dgvGastos.Rows.RemoveAt(dgvGastos.SelectedRows[0].Index);
                GuardarGastosEnJson(); 
            }
            else
            {
                MessageBox.Show("Selecciona un gasto para eliminar.");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
