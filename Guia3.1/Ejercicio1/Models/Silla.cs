using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Silla : Producto
    {
        public Silla(string descripcion, double precioBase, int tipoMaterial) : base(descripcion, precioBase, tipoMaterial) {        
        }

        public override double CalcularPrecio()
        {
            return precioBase * (1 + (tipoMaterial * 0.25));
        }

        public override string VerDetalle()
        {
            return $"{getDescripcion()}     {materiales[this.tipoMaterial]}     ${this.precioBase}      No tiene largo         ${CalcularPrecio():f2}";
        }
    }
}
