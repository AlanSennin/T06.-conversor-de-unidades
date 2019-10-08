using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    public class Operacion
    {
        Unidad R = new Unidad(); //Instanciando Globalmente la clase Valores

        double Res; //Declarando como double la variable Res para los Resultados

        public Double Centimetros(Unidad R)
        {
            Res = R.cm * 0.01; //Convertir Centimetros a Metros
            return Res;
        }

        public Double Metros(Unidad R)
        {
            Res = R.m * 39.3701; //Convertir Metros a Pulgadas
            return Res;
        }

        public Double Litros(Unidad R)
        {
            Res = R.l * 1000; //Convertir Litros a Milimetros
            return Res;
        }
    }
}
