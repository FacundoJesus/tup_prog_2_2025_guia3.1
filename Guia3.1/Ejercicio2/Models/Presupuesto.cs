using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Presupuesto
    {
        public int CantidadProductos { get; private set; } = 0;
        public double CostoTotal { get; private set; } = 0;
        public string Cliente;
        public string Direccion;

        List <Producto> presupuestados = new List<Producto>();

        public Presupuesto(string direccion, string cliente)
        {
            this.Cliente = cliente;
            this.Direccion = direccion;
        }

        public void AgregarProducto(Producto producto)
        {
            presupuestados.Add(producto);
            CantidadProductos++;
            CostoTotal += producto.CalcularPrecio();
        }

        public Producto VerProducto(int idx)
        {
            Producto producto = null;
            if (idx >= 0 &&  idx < presupuestados.Count)
            {
                producto = presupuestados[idx];
            }
            return producto;
        }
    }
}
