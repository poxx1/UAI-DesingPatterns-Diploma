﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder
{
    public class Pizza
    {
        Masa _masa;
        Salsa _salsa;
        Agregado _agregado;
        string _tipo;

        public override string ToString()
        {
            return $"{_tipo}, Masa {_masa.Descripcion}, Salsa: {_salsa.Descripcion}, Agregado {_agregado.Descripcion}";
        }

        public Pizza(Masa masa, Salsa salsa, Agregado agregado, string tipo)
        {
            _masa = masa;
            _agregado = agregado;
            _tipo = tipo;
            _salsa = salsa;
        }
    }
}
