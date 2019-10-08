using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    class Principal
    {
        Unidad R = new Unidad(); //Instanciando Globalmente la clase Valores.

        Operacion P = new Operacion(); //Instanciando Globalmente la clase Operacion.

        public void Menu()
        {
            double Res;

            //Menu para las conversiones 
            Console.WriteLine("¡Bienvenido al Menu!");
            Console.WriteLine(" ");
            Console.WriteLine("Seleccione una Opcion...");
            Console.WriteLine(" ");
            Console.WriteLine("(1) Centimetros a Metros");
            Console.WriteLine("(2) Metros a Pulgadas");
            Console.WriteLine("(3) Litros a Milimetros");
            Console.WriteLine(" ");
            Console.WriteLine("(4) Salir...");
            Console.WriteLine(" ");

            int V;

            V = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (V) //Switch para la seleccion de opciones en el Menu
            {
                case 1:
                    Console.WriteLine("Ingrese los Centimetros...");
                    Console.WriteLine(" ");
                    R.cm = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" ");

                    Res = P.Centimetros(R); //Asigno y mando a llamar el metodo en el resultado

                    Console.WriteLine("Metros: "+Res); //Imprimir resultado
                    Console.WriteLine(" ");

                    Console.WriteLine("Presiona cualquier tecla para regresar al menu...");
                    Console.ReadKey();

                    Console.Clear();
                    Menu(); //Regresamos al menu
                    break;

                case 2:
                    Console.WriteLine("Ingrese los Metros...");
                    Console.WriteLine(" ");
                    R.m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" ");

                    Res = P.Metros(R); //Asigno y mando a llamar el metodo en el resultado

                    Console.WriteLine("Pulgadas: " + Res); //Imprimir resultado
                    Console.WriteLine(" ");

                    Console.WriteLine("Presiona cualquier tecla para regresar al menu...");
                    Console.ReadKey();

                    Console.Clear();
                    Menu(); //Regresamos al menu
                    break;

                case 3:
                    Console.WriteLine("Ingrese los Litros...");
                    Console.WriteLine(" ");
                    R.l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" ");

                    Res = P.Litros(R); //Asigno y mando a llamar el metodo en el resultado

                    Console.WriteLine("Mililitros: " + Res); //Imprimir resultado
                    Console.WriteLine(" ");

                    Console.WriteLine("Presiona cualquier tecla para regresar al menu...");
                    Console.ReadKey();

                    Console.Clear();
                    Menu(); //Regresamos al menu
                    break;

                case 4:
                    System.Environment.Exit(-1); //Codigo para Salir del Programa
                    break;
            }
        }
    }
}
