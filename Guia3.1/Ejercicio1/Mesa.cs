﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Mesa:Producto
    {

        private double largo;

        public Mesa(string descripcion, double precioBase, int tipoMaterial, double largo) :base(descripcion, precioBase, tipoMaterial)
        {

            this.largo = largo;
        }

        public override double CalcularPrecio() 
        {

            return (precioBase * largo) * (1 + tipoMaterial * 0.33);
        
        }

        public override string VerDetalle()
        {
            return $"Mesa";
        }

    }
}
