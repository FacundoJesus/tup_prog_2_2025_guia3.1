using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            tbMuestra.Clear();
            Producto mesa1 = new Mesa("Mesa Comedor", 10.1, 1, 1);
            Producto silla1 = new Silla("Silla", 10.2, 2);

            tbMuestra.Text += $"{mesa1.VerDetalle()}\r\n{silla1.VerDetalle()}";

        }
    }
}
