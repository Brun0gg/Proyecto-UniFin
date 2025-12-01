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
        private Dictionary<string, List<Gasto>> tablaHash = new Dictionary<string, List<Gasto>>();
        public FrmGastos(FrmPresupuesto frm)
        {
            InitializeComponent();
            frmPresupuesto = frm;
            CargarGastos();
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
            if (string.IsNullOrWhiteSpace(txtNombreGasto.Text) ||
                string.IsNullOrWhiteSpace(txtMonto.Text) ||
                string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            string nombre = txtNombreGasto.Text;
            string categoria = cmbCategoria.Text;
            decimal monto = decimal.Parse(txtMonto.Text);
            string fecha = dtpFecha.Value.ToShortDateString();

            dgvGastos.Rows.Add(nombre, monto, categoria, fecha);
            GuardarGastosEnJson();
            frmPresupuesto.AgregarGasto(categoria, monto);

            if (!tablaHash.ContainsKey(categoria))
                tablaHash[categoria] = new List<Gasto>();

            tablaHash[categoria].Add(new Gasto
            {
                Nombre = nombre,
                Monto = monto,
                Categoria = categoria,
                Fecha = fecha
            });

            txtNombreGasto.Clear();
            txtMonto.Clear();
        }

        private void GuardarGastosEnJson()
        {
            var lista = new List<Gasto>();

            foreach (DataGridViewRow row in dgvGastos.Rows)
            {
                if (!row.IsNewRow)
                {
                    lista.Add(new Gasto
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

            File.WriteAllText(ruta, JsonConvert.SerializeObject(lista));
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
            tablaHash.Clear();

            foreach (var g in lista)
            {
                dgvGastos.Rows.Add(g.Nombre, g.Monto, g.Categoria, g.Fecha);

                if (!tablaHash.ContainsKey(g.Categoria))
                    tablaHash[g.Categoria] = new List<Gasto>();

                tablaHash[g.Categoria].Add(g);
            }
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreGasto.Text.Trim();

            Gasto g = BuscarGastoPorNombre(nombre);

            if (g == null)
            {
                MessageBox.Show("Gasto no encontrado.");
                return;
            }

            foreach (DataGridViewRow row in dgvGastos.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value.ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    string categoria = row.Cells[2].Value.ToString();
                    dgvGastos.Rows.Remove(row);


                    if (tablaHash.ContainsKey(categoria))
                    {
                        tablaHash[categoria].RemoveAll(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
                    }

                    GuardarGastosEnJson();

                    MessageBox.Show($"Gasto '{nombre}' eliminado correctamente.");
                    return;
                }
            }
        }
    
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Gasto BuscarGastoPorNombre(string nombre)
        {
            List<Gasto> lista = new List<Gasto>();

            foreach (DataGridViewRow r in dgvGastos.Rows)
            {
                if (!r.IsNewRow)
                {
                    lista.Add(new Gasto
                    {
                        Nombre = r.Cells[0].Value.ToString(),
                        Monto = Convert.ToDecimal(r.Cells[1].Value),
                        Categoria = r.Cells[2].Value.ToString(),
                        Fecha = r.Cells[3].Value.ToString()
                    });
                }
            }

            lista = lista.OrderBy(g => g.Nombre).ToList();

            foreach (var g in lista)
            {
                if (g.Nombre.ToLower() == nombre.ToLower())
                    return g;
            }

            return null;
        }
        public List<Gasto> BuscarGastosPorCategoria(string categoria)
        {
            if (tablaHash.ContainsKey(categoria))
                return tablaHash[categoria];

            return new List<Gasto>();
        }

    }
}
