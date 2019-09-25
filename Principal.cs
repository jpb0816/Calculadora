using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Principal
    {
        Operaciones op = new Operaciones();
        Valores v = new Valores();
        public void Getsuma()
        {
            Console.WriteLine("Ingrese numero 1:");
            v.Valora= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            v.Valorb = Convert.ToDouble(Console.ReadLine());


            op.Sumar(v);
            double suma = op.Sumar(v);
            Console.WriteLine(suma);
        }

        public void Getresta()
        {
            Console.WriteLine("Ingrese numero 1:");
            v.Valora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            v.Valorb = Convert.ToDouble(Console.ReadLine());
            op.Restar(v);
            double resta = op.Restar(v);
            Console.WriteLine(resta);

        }

        public void GetMult()
        {
            Console.WriteLine("Ingrese numero 1:");
            v.Valora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            v.Valorb = Convert.ToDouble(Console.ReadLine());
            op.Multiplicar(v);
            double multi = op.Multiplicar(v);
            Console.WriteLine(multi);

        }

        public void Getdivision()
        {
            Console.WriteLine("Ingrese numero 1:");
            v.Valora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            v.Valorb = Convert.ToDouble(Console.ReadLine());

            op.Dividir(v);
            double division = op.Dividir(v);
            Console.WriteLine(division);

        }


        public void Bienvenido()
        {
            Console.WriteLine("Bienvenido al programa");

            Console.WriteLine("-------------------------------------------------");

            Menu();

        }

        public void Menu()
        {
           

            
            int opc = 0;
            

           

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Inserte la operacion que desee realizar");
            
            Console.WriteLine("\n1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicacion");
            Console.WriteLine("4.Division");

            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Getsuma();
                    
                    break;

                case 2:
                    Getresta();
                    
                    break;

                case 3:
                    GetMult();
                    
                    
                    break;

                case 4:
                    Getdivision();
                    
                    break;
            }


        }
    }
}
