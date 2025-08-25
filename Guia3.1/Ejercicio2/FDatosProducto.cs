using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FDatosProducto : Form
    {
        public FDatosProducto()
        {
            InitializeComponent();
        }

        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoProducto.SelectedIndex)
            {
                case 0:
                    tbLargo.Enabled = true;
                    break;

                case 1:
                    lbLargo.Enabled = false;
                    tbLargo.Enabled = false;
                    break;
            }
                
        }
    }
}
