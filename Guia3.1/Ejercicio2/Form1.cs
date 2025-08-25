using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVerPresupuesto.Enabled = false;
            btnAgregarProducto.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Instancio objeto de la clase Presupuesto
        Presupuesto presupuesto;

        private void btnIniciarPresupuesto_Click(object sender, EventArgs e)
        {
            FDatosCliente fDatosCliente = new FDatosCliente();

            
            if (fDatosCliente.ShowDialog() == DialogResult.OK)
            {
                string nombre = fDatosCliente.tbNombre.Text;
                string direccion = fDatosCliente.tbDireccion.Text;

                presupuesto = new Presupuesto(direccion, nombre);
                

                lbNombre.Text = presupuesto.Cliente;
                lbDireccion.Text = presupuesto.Direccion;
                btnAgregarProducto.Enabled = true;
                MessageBox.Show("DATOS DEL CLIENTE CARGADOS!");
            }
            else
            {
                MessageBox.Show("CLIENTE NO CARGADO!");
            }
            fDatosCliente.Dispose();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FDatosProducto fDatosProducto = new FDatosProducto();

            if (fDatosProducto.ShowDialog() == DialogResult.OK)
            {
                int tipoProducto = fDatosProducto.cmbTipoProducto.SelectedIndex;
                string descripcion = fDatosProducto.tbDescripcion.Text;
                double precio = Convert.ToDouble(fDatosProducto.tbPrecio.Text);
                int tipoMaterial = fDatosProducto.cmbTipoMaterial.SelectedIndex;

                if (tipoProducto == 0) //Mesa
                {
                    double largo = Convert.ToDouble(fDatosProducto.tbLargo.Text);

                    Producto mesa = new Mesa(descripcion, precio, tipoMaterial, largo);
                    presupuesto.AgregarProducto(mesa);
                }
                else //Silla
                {          
                    Producto silla = new Silla(descripcion, precio, tipoMaterial);
                    presupuesto.AgregarProducto(silla);
                }
                MessageBox.Show("PRODUCTO AGREGADO!");
                btnVerPresupuesto.Enabled = true;
            }
            else
            {
                MessageBox.Show("DATOS DEL PRODUCTO NO CARGADO!");
            }
            fDatosProducto.Dispose();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            FVerPresupuesto fVerPresupuesto = new FVerPresupuesto();

            for (int i = 0; i < presupuesto.CantidadProductos; i++) {
                fVerPresupuesto.tbResultado.Text += $"{presupuesto.VerProducto(i).VerDetalle()}\r\n" +
                    $"Nombre: {presupuesto.Cliente}\r\n" +
                    $"Dirección: {presupuesto.Direccion}\r\n" +
                    $"Costo Total: ${presupuesto.CostoTotal:f2}\r\n" +
                    $"----------------------------------------------\r\n";
            }
            fVerPresupuesto.ShowDialog();
            fVerPresupuesto.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
