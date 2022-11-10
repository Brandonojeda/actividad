using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace atividad_fiesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreUsuario;
            byte edadUsuario;
            string apellidousuario;
            string direccion;
            string numerotelefonico;
            string perfilfaceboock;
            string usuarioacceso;
            string contraseña;
            string confmacontraseña;
            string codigoacceso;

            //Que el suario ingrese por teclado los valores de las variabes
            Console.WriteLine("Ingresa tu nombre, despúes presiona ENTER");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad, despúes presiona ENTER");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            //if
            if (edadUsuario > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.WriteLine("Tu código de acceso es: 345678");
                Console.WriteLine("ingresa tu apellido");
                apellidousuario = Console.ReadLine();
                Console.WriteLine("ingresa tu direccion");
                direccion = Console.ReadLine();
                Console.WriteLine("ingresa tu numero de telefono");
                numerotelefonico = Console.ReadLine();
                Console.WriteLine("ingresa perfil de faceboock");
                perfilfaceboock = Console.ReadLine();
                Console.WriteLine("tu usuario acceso");
                usuarioacceso = Console.ReadLine();
                Console.WriteLine("ingresa tu contraseña");
                contraseña =Console.ReadLine();
                Console.WriteLine("confiarma tu contraseña");
                confmacontraseña = Console.ReadLine();


                //generar codigo de acceso
                if (contraseña ==confmacontraseña)
                {
                    //numero aleatoreo
                    Random aleatoreo = new Random();
                    aleatoreo.Next(1000, 9999);
                    codigoacceso = aleatoreo.ToString();

                    Console.ForegroundColor= ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();


                    Console.WriteLine("ingresa tu nombre y apellido");
                    nombreUsuario = Console.ReadLine();
                    Console.WriteLine("ingresa tu direccion");
                    direccion = Console.ReadLine();
                    Console.WriteLine("ingresa tu codigo acceso");
                    codigoacceso = Console.ReadLine();

                    else
                    {
                        Console.WriteLine("no podemos validadr tu acceso");
                        Thread.Sleep(800);
                        return;
                    }

                    //imprimer consola
                    Console.WriteLine("\n informacion de acceso ala fiesta");
                    Console.WriteLine("\nombre:.{0}.", " edad usuario: {1}.", " apellido:{2}.", " direccion:{4}.",
                        "numero telefono:{5}.",
                        "perfil de faceboock:{6}.", "codigo acceso:{7}.", nombreUsuario, edadUsuario, apellidousuario, direccion, numerotelefonico,
                        perfilfaceboock, codigoacceso);







                }







            }
            else
            {
                Console.WriteLine("No podemos validar tu acceso, debes ser mayor de edad");
            }



            Console.WriteLine("Saliendo del sistema.");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema..");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema...");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema....");
            Thread.Sleep(800);



            Console.ReadKey();
        }
    }
}
