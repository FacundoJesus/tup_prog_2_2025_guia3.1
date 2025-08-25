using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public abstract class Producto
    {
        private string descripcion;
        protected double precioBase;
        protected int tipoMaterial;

        protected string[] materiales = { "Pino", "Algarrobo", "Caoba" };

        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            this.descripcion = descripcion;
            this.precioBase = precioBase;
            this.tipoMaterial = tipoMaterial;
        }

        public abstract double CalcularPrecio();
        public abstract string VerDetalle();

        public string GetDescripcion()
        {
            return descripcion;
        }
    }
}
