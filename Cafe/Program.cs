using System;

namespace Cafe
{
    internal class Program
    {
        public static Cafetera cafetera;
        public static Vaso vasosPequeno;
        public static Vaso vasosMediano;
        public static Vaso vasosGrande;
        public static Azucarero azucarero;
        public static MaquinaDeCafe maquina;

        static void Main(string[] args)
        {
            int salir = 0;

            cafetera = new Cafetera(50);
            vasosPequeno = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azucarero = new Azucarero(20);

            maquina = new MaquinaDeCafe();

            maquina.setCafetera(cafetera);
            maquina.setVasosPequeno(vasosPequeno);
            maquina.setVasosMediano(vasosMediano);
            maquina.setVasosGrande(vasosGrande);
            maquina.setAzucarero(azucarero);


            while (salir != 99)
            {
                Console.Clear();
                Console.WriteLine("      )  (       ");
                Console.WriteLine("     (   ) )     ");
                Console.WriteLine("      ) ( (      ");
                Console.WriteLine("    _______)_    ");
                Console.WriteLine(" .-'---------|   "); 
                Console.WriteLine("( C|/\\/\\/\\/\\/|   ");
                Console.WriteLine(" '-./\\/\\/\\/\\/|   ");
                Console.WriteLine("   '_________'    ");
                Console.WriteLine("    '-------'    ");


                Console.WriteLine("Hola prro, quieres cafe?");
                Console.WriteLine();
                Console.Write("Escribe el tamaño de el/los vaso/s que vas a utilizar:");
                Vaso vaso = maquina.getTipoDeVaso(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Escribe la cantidad de vasos que vas a pedir:");
                int cantidadVasos = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Escribe la cantidad de cucharadas de azucar que vas a pedir:");
                int cantidadAzucar = Int32.Parse(Console.ReadLine());

                Console.WriteLine(maquina.getVasoDeCafe(vaso, cantidadVasos, cantidadAzucar));

                Console.WriteLine();
                Console.Write("Escriba 99 para salir -->");
                salir = Int32.Parse(Console.ReadLine());

            }

            Console.WriteLine("   . - . - . - . - . - . - . - . - . - . - .");
            Console.WriteLine("  :                             _-_,,       :");
            Console.WriteLine("  :    Realizado por:          (  //        :");
            Console.WriteLine("  :  Jaime Hndz. 2020-10613      _||        :");
            Console.WriteLine("  :  Jaime25112002@gmail.com     _||        :");
            Console.WriteLine("  :  829-284-7781/809-335-8760    ||        :");
            Console.WriteLine("  :                            -__-,        :");
            Console.WriteLine("   . - . - . - . - . - . - . - . - . - . - .");


        }
    }
}
