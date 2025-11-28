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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            FrmPresupuesto frm = new FrmPresupuesto();
            frm.ShowDialog();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            FrmPresupuesto frmPres = new FrmPresupuesto();
            frmPres.Show(); // mostramos el formulario de presupuesto

            // Abrimos FrmGastos y le pasamos la referencia
            FrmGastos frmG = new FrmGastos(frmPres);
            frmG.ShowDialog();
        }
    }
}
