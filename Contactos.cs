// contactos 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ProyectoFinal
{
    internal class Contactos
    {
        public static string nombre;
        public static string Apellido;
        public static string telefono;
        public static dynamic direccion;
        public static dynamic email;
        public static dynamic buscar;
        public static string res = "si";
        public static string re1;

        public static void contactosMain()
        {
            do
            {
                Console.Clear();
                string re1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine(@"

                                               
                                            ____  ____  _      _____  ____  ____  _____  ____  ____ 
                                           /   _\/  _ \/ \  /|/__ __\/  _ \/   _\/__ __\/  _ \/ ___\
                                          |  /  | / \|| |\ ||  / \  | / \||  /    / \  | / \||    \
                                          |  \__| \_/|| | \||  | |  | |-|||  \_   | |  | \_/|\___ |
                                           \____/\____/\_/  \|  \_/  \_/ \|\____/  \_/  \____/\____/
                                                         
    ");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(@"

                                                                              [1] Crear contacto.

                                                                              [2] Buscar Contacto.
 
                                                                              [3] Todos los contactos.

                                                                              [4] Editar contacto.

                                                                              [5] Eliminar contacto

                                                                              [6] Salir

");
                re1 = Console.ReadLine()!;



                switch (re1)
                {

                    case "1": registro1(); break;
                    case "2": Buscar(); break;
                    case "3": todos(); break;
                    case "4": Editar(); break;
                    case "5": eliminar(); break;
                    case "6": break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep();
                        Console.WriteLine(@"

                                              _____ ____  ____  ____  ____    _  _ 
                                             /  __//  __\/  __\/  _ \/  __\  / \/ \
                                            |  \  |  \/||  \/|| / \||  \/|  | || |
                                            |  /_ |    /|    /| \_/||    /  \_/\_/
                                             \____\\_/\_\\_/\_\\____/\_/\_\  (_)(_)
                                      
");
                        Thread.Sleep(1000);
                        break;



                }



            } while (re1 == "6");




        }

        static void registro1()
        {




            Console.Clear();
            Console.Write("Nombre: ");
            nombre = Console.ReadLine()!;



            Console.Write("Apellido: ");
            Apellido = Console.ReadLine()!;



            Console.Write("Telefono: ");
            telefono = Console.ReadLine()!;



            Console.Write("Direccion: ");
            direccion = Console.ReadLine()!;



            Console.Write("Email: ");
            email = Console.ReadLine()!;


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"

 _____ _     ____  ____  ____  ____  ____  ____ 
/  __// \ /\/  _ \/  __\/  _ \/  _ \/  _ \/  _ \
| |  _| | ||| / \||  \/|| | \|| / \|| | \|| / \|
| |_//| \_/|| |-|||    /| |_/|| |-||| |_/|| \_/|
\____\\____/\_/ \|\_/\_\\____/\_/ \|\____/\____/
                                                
 ");
            Thread.Sleep(1000);

            Console.Clear();



            StreamWriter guardar = new StreamWriter("Final.txt", append: true);
            guardar.WriteLine(nombre + "," + Apellido + "," + telefono + "," + direccion + "," + email);
            guardar.Close();

            contactosMain();





        }
        static void todos()
        {
            Console.WriteLine();
            Console.Clear();
            string cadena;
            string[] campos = new string[5];
            StreamReader Alchivo = File.OpenText("Final.txt");

            while ((cadena = Alchivo.ReadLine()!) != null)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                campos = cadena.Split(",");
                Console.WriteLine("|--------------------------------------");
                Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();

            }

            Alchivo.Close();
            Console.WriteLine();
            Console.WriteLine("VOLVER [ENTER]");
            Console.ReadKey();
            contactosMain();

        }



        static void Buscar()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            StreamReader Alchivo = File.OpenText("Final.txt");

            string cadena;
            bool encontrado = false;
            string[] campos = new string[5];

            Console.Write("BUSCAR:");
            buscar = Console.ReadLine()!;

            while ((cadena = Alchivo.ReadLine()!) != null)
            {

                campos = cadena.Split(',');

                if (campos[0].Trim().Equals(buscar))
                {
                    Console.WriteLine("|--------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                    encontrado = true;
                    Console.WriteLine("PRESIONE [ENTER] PARA VOLVER");
                    Console.ReadKey();
                }
                else if (campos[1].Trim().Equals(buscar))
                {
                    Console.WriteLine("|--------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                    encontrado = true;
                    Console.WriteLine("PRECIONE [ENTER] PARA VOLVER");
                    Console.ReadKey();
                }
                else if (campos[2].Trim().Equals(buscar))
                {
                    Console.WriteLine("|--------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                    encontrado = true;
                    Console.WriteLine("PRECIONE [ENTER] PARA VOLVER");
                    Console.ReadKey();
                }
                else if (campos[3].Trim().Equals(buscar))
                {
                    Console.WriteLine("|--------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                    encontrado = true;
                    Console.WriteLine("PRECIONE [ENTER] PARA VOLVER");
                    Console.ReadKey();
                }
                else if (campos[4].Trim().Equals(buscar))
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                    encontrado = true;
                    Console.WriteLine("PRECIONE [ENTER] PARA VOLVER");
                    Console.ReadKey();
                }


            }

            Alchivo.Close();

            contactosMain();

        }


        static void Editar()
        {

            Console.Clear();
            StreamWriter temporal = File.CreateText("temporal.txt");
            StreamReader Alchivo = File.OpenText("Final.txt");


            string newnombre, newapellido, newtelefono, newdireccion, newemail;

            bool encontrado = false;
            string cadena, linea;
            string[] campos = new string[5];
            string respuesta = string.Empty;

            Console.Write(" INGRESE EL CONTACTO A EDITAR: ");
            string edit = Console.ReadLine()!;


            while ((cadena = Alchivo.ReadLine()!) != null)
            {
                campos = cadena.Split(',');
                Console.WriteLine();
                if (campos[0].Trim().Equals(edit))
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("|---------------------------------------");
                    Console.WriteLine();
                    encontrado = true;
                }

            ir:
                if (encontrado == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(@"
  
 _____ ____  _  ____  ____  _  ____  _     
/  __//  _ \/ \/   _\/   _\/ \/  _ \/ \  /|
|  \  | | \|| ||  /  |  /  | || / \|| |\ ||
|  /_ | |_/|| ||  \__|  \__| || \_/|| | \||
\____\\____/\_/\____/\____/\_/\____/\_/  \|
                                           
");

                    Console.WriteLine(@"     
                    [1] Nombre 
                    [2] Apellido 
                    [3] Telefono 
                    [4] Direccion 
                    [5] Email ");

                    string opcion = Console.ReadLine()!;


                    switch (opcion)
                    {
                        case "1":
                            Console.WriteLine("INGRESE EL NUEVO NOMBRE");
                            newnombre = Console.ReadLine()!;

                            temporal.WriteLine(newnombre + "," + campos[1] + "," + campos[2] + "," + campos[3] + "," + campos[4]);

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(@"

                                           +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+
                                           |C|A|M|B|I|O| |G|U|A|R|D|A|D|O|
                                           +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+ 
                                           ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                            cadena = Alchivo.ReadLine()!;


                            Alchivo.Close();
                            temporal.Close();
                            File.Delete("Final.txt");
                            File.Move("temporal.txt", "Final.txt");
                            Console.WriteLine();
                            Console.WriteLine("[ENTER] PARA VOLVER");
                            Console.ReadKey();
                            contactosMain();

                            break;

                        case "2":
                            Console.WriteLine("INGRESE EL NUEVO APELLIDO");
                            newapellido = Console.ReadLine()!;

                            temporal.WriteLine(campos[0] + "," + newapellido + "," + campos[2] + "," + campos[3] + "," + campos[4]);

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(@"

                                           +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+
                                           |C|A|M|B|I|O| |G|U|A|R|D|A|D|O|
                                           +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+ 
                                           ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            cadena = Alchivo.ReadLine()!;


                            Alchivo.Close();
                            temporal.Close();
                            File.Delete("Final.txt");
                            File.Move("temporal.txt", "Final.txt");
                            Console.WriteLine();
                            Console.WriteLine("[ENTER] PARA VOLVER");
                            Console.ReadKey();
                            contactosMain();


                            break;

                        case "3":
                            Console.WriteLine("INGRESE EL NUEVO TELEFONO");
                            newtelefono = Console.ReadLine()!;

                            temporal.WriteLine(campos[0] + "," + campos[1] + "," + newtelefono + "," + campos[3] + "," + campos[4]);

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(@"
                            
                            
                            
                                           +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+
                                           |C|A|M|B|I|O| |G|U|A|R|D|A|D|O|
                                           +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+

                            
                            
                            ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            cadena = Alchivo.ReadLine()!;


                            Alchivo.Close();
                            temporal.Close();
                            File.Delete("Final.txt");
                            File.Move("temporal.txt", "Final.txt");
                            Console.WriteLine();
                            Console.WriteLine("[ENTER] PARA VOLVER");
                            Console.ReadKey();
                            contactosMain();

                            break;

                        case "4":
                            Console.WriteLine("INGRESE LA NUEVA DIRECCION ");
                            newdireccion = Console.ReadLine()!;

                            temporal.WriteLine(campos[0] + "," + campos[1] + "," + campos[2] + "," + newdireccion + "," + campos[4]);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"

                                          +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+
                                          |C|A|M|B|I|O| |G|U|A|R|D|A|D|O|
                                          +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+
");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            cadena = Alchivo.ReadLine()!;


                            Alchivo.Close();
                            temporal.Close();
                            File.Delete("Final.txt");
                            File.Move("temporal.txt", "Final.txt");
                            Console.WriteLine();
                            Console.WriteLine("[ENTER] PARA VOLVER");
                            Console.ReadKey();
                            contactosMain();

                            break;

                        case "5":
                            Console.WriteLine("INGRESE LA NUEVA DIRECCION ");
                            newemail = Console.ReadLine()!;

                            temporal.WriteLine(campos[0] + "," + campos[1] + "," + campos[2] + "," + campos[3] + "," + newemail);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"

                                               +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+
                                               |C|A|M|B|I|O| |G|U|A|R|D|A|D|O|
                                               +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+
 ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            cadena = Alchivo.ReadLine()!;


                            Alchivo.Close();
                            temporal.Close();
                            File.Delete("Final.txt");
                            File.Move("temporal.txt", "Final.txt");
                            Console.WriteLine();
                            Console.WriteLine("[ENTER] PARA VOLVER");
                            Console.ReadKey();
                            contactosMain();
                            break;

                        default:
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(@"
                            
                              ___    ___    ___    _____  ___     _ 
                              (  _`\ |  _`\ |  _`\ (  _  )|  _`\ ( )
                              | (_(_)| (_) )| (_) )| ( ) || (_) )| |
                              |  _)_ | ,  / | ,  / | | | || ,  / | |
                              | (_( )| |\ \ | |\ \ | (_) || |\ \ | |
                              (____/'(_) (_)(_) (_)(_____)(_) (_)(_)
                                                                 (_)
                                                                 
                                      
");
                            Thread.Sleep(1000);


                            goto ir;



                    }
                }
                else
                {
                    Console.Write(" EL CONTACTO ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(edit);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(" NO EXISTE !!");
                    temporal.WriteLine(cadena);
                }
            }
            cadena = Alchivo.ReadLine()!;


            Alchivo.Close();
            temporal.Close();
            File.Delete("Final.txt");
            File.Move("temporal.txt", "Final.txt");
            Console.WriteLine();
            Console.WriteLine("[ENTER] PARA VOLVER");
            Console.ReadKey();
            contactosMain();
        }


        static void eliminar()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            StreamWriter temporal = File.CreateText("temporal.txt");
            StreamReader Alchivo = File.OpenText("Final.txt");

            string cadena;
            bool encontrado = false;
            string[] campos = new string[5];

            Console.WriteLine("INGRESE EL CONTACTO A ELIMINAR");
            string eliminar = Console.ReadLine()!;

            while ((cadena = Alchivo.ReadLine()!) != null && encontrado == false)
            {
                campos = cadena.Split(',');

                if (campos[0].Trim().Equals(eliminar))
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                }
                else if (campos[1].Trim().Equals(eliminar))
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                }
                else if (campos[2].Trim().Equals(eliminar))
                {
                    Console.Clear();
                    Console.WriteLine("|--------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                }
                else if (campos[3].Trim().Equals(eliminar))
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                }
                else if (campos[4].Trim().Equals(eliminar))
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("| Nombre: " + campos[0].Trim() + "     ");
                    Console.WriteLine("| Apellido: " + campos[1].Trim() + "   ");
                    Console.WriteLine("| telefono: " + campos[2].Trim() + "   ");
                    Console.WriteLine("| direccion: " + campos[3].Trim() + "  ");
                    Console.WriteLine("| email: " + campos[4].Trim() + "      ");
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    temporal.WriteLine(cadena);
                }
            }

            Console.WriteLine("ESTA SEGURO DE QUE QUIERE ELIMINAR EL CONTACTO ?");
            Console.WriteLine("[Si]");
            Console.WriteLine("[No]");
            res = Console.ReadLine()!.ToUpper();

            if (res == "SI")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                Console.WriteLine(@"

 _____ _     _  _      _  _      ____  ____  ____ 
/  __// \   / \/ \__/|/ \/ \  /|/  _ \/  _ \/  _ \
|  \  | |   | || |\/||| || |\ ||| / \|| | \|| / \|
|  /_ | |_/\| || |  ||| || | \||| |-||| |_/|| \_/|
\____\\____/\_/\_/  \|\_/\_/  \|\_/ \|\____/\____/
                                                  
");
                Alchivo.Close();
                temporal.Close();
                File.Delete("Final.txt");
                File.Move("temporal.txt", "Final.txt");
                Thread.Sleep(1000);
                contactosMain();
            }
            else if (res == "NO")
            {
                contactosMain();
            }
        }



    }


}
