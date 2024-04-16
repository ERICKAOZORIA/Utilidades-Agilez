using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
     

namespace ProyectoFinal {
    internal class Calculadora {
        public void calculadoraMain() {
            double basicOperations(int num1, int num2, int op) {
                switch (op) {
                    case 1:
                        return num1 + num2;
                    case 2:
                        return num1 - num2;
                    case 3:
                        return num1 * num2;
                    case 4:
                        return num1 / num2;
                }

                return 0;
            }

            double specialOperations(double num1, int op) {
                switch (op) {
                    case 1:
                        return Math.Sqrt(num1);
                    case 2:
                        return num1 * num1 * num1;
                    case 3:
                        return (num1 * num1) / 100;
                    case 4:
                        return Math.Pow(num1, 2);
                    case 5:
                        return Math.Pow(num1, 3);
                }

                return 0;
            }

            do {
                Console.Clear();
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("ELIJA EL TIPO DE OPERACION QUE QUIERE REALIZAR: ");
                Console.WriteLine();
                Console.WriteLine("1. OPERACIONES BASICAS.");
                Console.WriteLine("2. OPERACIONES CIENTIFICAS.");
                Console.WriteLine("3. SALIR.");
                Console.WriteLine();
                Console.Write("-> ");
                var op = Console.ReadLine();

                int type = op == null ? 0 : int.Parse(op);

                if (type == 1) {
                    Console.Clear();
                    Console.WriteLine("CALCULADORA");
                    Console.WriteLine("ELIJA EL TIPO DE OPERACION QUE QUIERE REALIZAR: ");
                    Console.WriteLine();
                    Console.WriteLine("1. SUMA.");
                    Console.WriteLine("2. RESTA.");
                    Console.WriteLine("3. MULTIPLICACION.");
                    Console.WriteLine("4. DIVISION.");
                    Console.WriteLine();
                    Console.Write("-> ");
                    op = Console.ReadLine();

                    type = op == null ? 0 : int.Parse(op);
                    Console.Write("INGRESE EL PRIMER NUMERO: ");
                    var res = Console.ReadLine();
                    Console.Write("INGRESE EL SEGUNDO NUMERO: ");
                    var res2 = Console.ReadLine();

                    if (res == null || res2 == null) {
                        Console.WriteLine("¡NO PUEDES DEJAR NINGUN CAMPO VACIO!");
                    } else {
                        int num1 = int.Parse(res);
                        int num2 = int.Parse(res2);

                        Console.WriteLine();
                        Console.Write("RESULTADOS: " + basicOperations(num1, num2, type));
                        Console.ReadKey();
                    }
                } else if (type == 2) {
                    Console.Clear();
                    Console.WriteLine("CALCULADORA");
                    Console.WriteLine("ELIJA EL TIPO DE OPERACION QUE QUIERE REALIZAR: ");
                    Console.WriteLine();
                    Console.WriteLine("1. RAIZ CUADRADA.");
                    Console.WriteLine("2. RAIZ CUBICA.");
                    Console.WriteLine("3. PORCENTAJE.");
                    Console.WriteLine("4. ELEVAR AL CUADRADO.");
                    Console.WriteLine("5. ELEVAR AL CUBO.");
                    Console.WriteLine();
                    Console.Write("-> ");
                    op = Console.ReadLine();

                    type = op == null ? 0 : int.Parse(op);
                    Console.Write("INGRESE UN NUMERO: ");
                    var res = Console.ReadLine();
                    if (res == null) {
                        Console.WriteLine("¡NO PUEDES DEJAR NINGUN CAMPO VACIO!");
                    } else {
                        int num1 = int.Parse(res);

                        Console.WriteLine();
                        Console.Write("RESULTADOS: " + specialOperations(num1, type));
                        Console.ReadKey();
                    }
                } else {
                    break;
                }

                Console.Clear();
                Console.WriteLine("¿DESEAS CONTINUAR? s/n");
                var tryAgain = Console.ReadLine();

                if (tryAgain == null) {
                    Console.WriteLine("¡NO PUEDES DEJAR NINGUN CAMPO VACIOS!");
                } else {
                    if (tryAgain.ToLower() == "s") {

                    } else {
                        break;
                    }
                }
            } while (true);
        }
    }
}
