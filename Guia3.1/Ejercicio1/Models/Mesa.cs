using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Mesa : Producto
    {
        private double largo;

        public Mesa(string descripcion, double precioBase, int tipoMaterial, double largo) : base(descripcion,precioBase,tipoMaterial)
        {
            this.largo = largo;
        }

        public override double CalcularPrecio()
        {
            return (this.precioBase * this.largo) * (1 + (this.tipoMaterial * 0.33));
            
        }

        public override string VerDetalle()
        {
            return $"{getDescripcion()}     {materiales[this.tipoMaterial]}     ${this.precioBase}      {this.largo}          ${CalcularPrecio():f2}";
        }
    }
}
