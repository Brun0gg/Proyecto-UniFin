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
    public partial class FrmReporte : Form
    {
        // Diccionarios para almacenar gastos y presupuestos por mes
        private Dictionary<string, List<FrmGastos.Gasto>> gastosPorMes;
        private Dictionary<string, List<FrmPresupuesto.ItemPresupuesto>> presupuestoPorMes;

        public FrmReporte()
        {
            InitializeComponent();

            gastosPorMes = new Dictionary<string, List<FrmGastos.Gasto>>();
            presupuestoPorMes = new Dictionary<string, List<FrmPresupuesto.ItemPresupuesto>>();

            CargarMeses();
            CargarGastos();
            CargarPresupuestos();
        }

        private void CargarMeses()
        {
            cmbMes.Items.Clear();
            for (int año = 2023; año <= DateTime.Now.Year; año++)
            {
                for (int mes = 1; mes <= 12; mes++)
                {
                    cmbMes.Items.Add($"{año}-{mes:00}");
                }
            }
        }

        private void CargarGastos()
        {
            string rutaG = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "gastos.json");

            if (!File.Exists(rutaG)) return;

            var listaGastos = JsonConvert.DeserializeObject<List<FrmGastos.Gasto>>(File.ReadAllText(rutaG));

           
            foreach (var g in listaGastos)
            {
                DateTime fecha;
                if (DateTime.TryParse(g.Fecha, out fecha))
                {
                    string mes = $"{fecha.Year}-{fecha.Month:00}";
                    if (!gastosPorMes.ContainsKey(mes))
                        gastosPorMes[mes] = new List<FrmGastos.Gasto>();
                    gastosPorMes[mes].Add(g);
                }
            }
        }

        private void CargarPresupuestos()
        {
            string rutaP = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "presupuesto.json");

            if (!File.Exists(rutaP)) return;

            var listaPresupuesto = JsonConvert.DeserializeObject<List<FrmPresupuesto.ItemPresupuesto>>(File.ReadAllText(rutaP));

          
            string mesActual = DateTime.Now.ToString("yyyy-MM");

            if (!presupuestoPorMes.ContainsKey(mesActual))
                presupuestoPorMes[mesActual] = new List<FrmPresupuesto.ItemPresupuesto>();

            foreach (var p in listaPresupuesto)
            {
                presupuestoPorMes[mesActual].Add(p);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbMes.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un mes.");
                return;
            }

            string mesSeleccionado = cmbMes.SelectedItem.ToString();

            // Búsqueda secuencial de gastos
            List<FrmGastos.Gasto> gastosMes = null;
            if (gastosPorMes.ContainsKey(mesSeleccionado))
                gastosMes = gastosPorMes[mesSeleccionado];
            else
                gastosMes = new List<FrmGastos.Gasto>();

            dgvReporte.Rows.Clear();

            foreach (var g in gastosMes)
            {
                dgvReporte.Rows.Add(g.Nombre, g.Categoria, g.Monto, g.Fecha);
            }

            decimal totalGasto = 0;
            foreach (var g in gastosMes) totalGasto += g.Monto;

            lblTotalGasto.Text = $"Total gastado: {totalGasto:0.00}";

            // Búsqueda secuencial de presupuesto
            decimal totalPresupuesto = 0;
            if (presupuestoPorMes.ContainsKey(mesSeleccionado))
            {
                foreach (var p in presupuestoPorMes[mesSeleccionado])
                    totalPresupuesto += p.Presupuesto;
            }

            lblTotalPresupuesto.Text = $"Presupuesto del mes: {totalPresupuesto:0.00}";

            decimal diferencia = totalPresupuesto - totalGasto;
            lblDiferencia.Text = $"Diferencia: {diferencia:0.00}";

            // Categoría con más gasto
            if (gastosMes.Count > 0)
            {
                var categoriaMayor = gastosMes
                    .GroupBy(x => x.Categoria)
                    .OrderByDescending(g => g.Sum(x => x.Monto))
                    .FirstOrDefault();

                if (categoriaMayor != null)
                    lblCategoriaMayorGasto.Text = $"Categoría con más gasto: {categoriaMayor.Key}";
            }

            if (totalPresupuesto > 0)
            {
                decimal porc = (totalGasto / totalPresupuesto) * 100;
                lblPorcentajeUsado.Text = $"Porcentaje usado: {porc:0.00}%";
            }
        }

        private void lblTotalPresupuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
