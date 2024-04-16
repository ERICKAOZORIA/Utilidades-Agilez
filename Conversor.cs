using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProyectoFinal {
    internal class Conversor {
        Textos textos = new Textos();
        public void conversorMain() {
            string opcion;
            do {
                Console.Clear();
                textos.conversorTextoMain();
                opcion = Console.ReadLine()!;
                switch (opcion) {
                    case "1":
                        Console.Clear();
                        Menu_Temperaturas();
                        break;

                    case "2":
                        Console.Clear();
                        Menu_Monedas();
                        break;
                    case "3": break;
                    default:
                        Console.WriteLine("OPCION NO DISPONIBLE");
                        Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            } while (opcion != "3");
        }

        public void Menu_Temperaturas() {

            int opciones = 0;

            do {
                textos.conversorGrados();
                opciones = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opciones) {

                    case 1:
                        FahrenheitCelsius();


                        break;


                    case 2:
                        CelsiusFahrenheit();


                        break;


                    case 3:
                        FahrenheitKelvin();


                        break;

                    case 4:
                        KelvinFahrenheit();

                        break;

                    case 5:
                        KelvinCelsius();

                        break;


                    case 6:
                        CelsiusKelvin();

                        break;


                    case 7:
                        break;


                    default:
                        Console.WriteLine("OPCION INVALIDA");
                        Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        break;






                }


            } while (opciones != 7);

        }
        public void FahrenheitCelsius() {
            float celsius;
            Console.WriteLine("INGRESAR GRADO FAHRENHEIT ");
            float fahrenheit = float.Parse(Console.ReadLine()!);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"ESTE GRADO CELSIUS ES : {celsius}");

        }
        public void CelsiusFahrenheit() {
            double fahrenheit, celsius;

            Console.WriteLine("INGRESAR GRADO CELSIUS");
            celsius = double.Parse(Console.ReadLine()!);
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"ESTE GRADO EN FAHRENHEIT ES: {fahrenheit}");
        }
        public void KelvinFahrenheit() {
            double fahrenheit, kelvin;

            Console.WriteLine("INGRESAR GRADO KELVIN");
            kelvin = double.Parse(Console.ReadLine()!);
            fahrenheit = (kelvin - 273.15) * 9 / 5 + 32; ;
            Console.WriteLine($"ESTE GRADO EN FAHRENHEIT ES: {fahrenheit}");


        }
        public void KelvinCelsius() {
            double kelvin, celsius;

            Console.WriteLine("INGRESAR GRADO KELVIN");
            kelvin = double.Parse(Console.ReadLine()!);
            celsius = (kelvin - 273.1);
            Console.WriteLine($"ESTE GRADO EN CELSIUS: {celsius}");

        }
        public void FahrenheitKelvin() {
            double fahrenheit, kelvin;

            Console.WriteLine("INGRESAR EL GRADO FAHRENHEIT");
            fahrenheit = float.Parse(Console.ReadLine()!);
            kelvin = ((fahrenheit - 32) * 5 / 9 + 273.15);
            Console.WriteLine($"ESTE GRADO EN KELVIN ES: {kelvin}");

        }
        public void CelsiusKelvin() {
            double celsius, kelvin;

            Console.WriteLine("INGRESAR GRADO CELSIUS");
            celsius = double.Parse(Console.ReadLine()!);
            kelvin = (celsius + 273.15);
            Console.WriteLine($"ESTE GRADO EN KELVIN ES: {kelvin}");

        }

        public void Menu_Monedas() {

            int opciones = 0;

            do {
                textos.conversorMoneda();
                opciones = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opciones) {

                    case 1:
                        Euro_Peso();


                        break;


                    case 2:
                        Dolar_Peso();


                        break;


                    case 3:
                        Peso_Euro();


                        break;

                    case 4:
                        Peso_Dolar();

                        break;

                    case 5:
                        Dolar_Euro();

                        break;


                    case 6:
                        Euro_Dolar();

                        break;


                    case 7:
                        break;

                    default:
                        Console.WriteLine("OPCION INVALIDA");
                        Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
                        Console.ReadKey();
                        Console.Clear();
                        break;



                }

            } while (opciones != 7);

        }
        public double ingresa_Moneda(double Moneda = 0) {

            Console.WriteLine("INGRESE LA CANTIDAD DE DINERO QUE QUIERES CONVERTIR");

            Moneda = Convert.ToInt32(Console.ReadLine());

            return Moneda;
        }

        public void Euro_Peso() {

            double resultado = 0;
            double Moneda = 0;

            Moneda = ingresa_Moneda(Moneda: 0);


            resultado = Moneda * (56.50);

            Console.WriteLine(+Moneda + " Euros a Pesos = " + resultado);


            Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        public void Dolar_Peso() {

            double resultado = 0;
            double Moneda = 0;

            Moneda = ingresa_Moneda(Moneda: 0);


            resultado = Moneda * (56.50);

            Console.WriteLine(+Moneda + " Dolares a Pesos = " + resultado);


            Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        public void Peso_Euro() {

            double resultado = 0;
            double Moneda = 0;

            Moneda = ingresa_Moneda(Moneda: 0);


            resultado = Moneda * (0.019);

            Console.WriteLine(+Moneda + " Pesos a Euros = " + resultado);


            Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        public void Peso_Dolar() {

            double resultado = 0;
            double Moneda = 0;

            Moneda = ingresa_Moneda(Moneda: 0);

            resultado = Moneda * (0.019);

            Console.WriteLine(+Moneda + " Pesos a Dolar = " + resultado);


            Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        public void Dolar_Euro() {

            double resultado = 0;
            double Moneda = 0;

            Moneda = ingresa_Moneda(Moneda: 0);

            resultado = Moneda * (1.01);

            Console.WriteLine(+Moneda + " Dolar a Euros = " + resultado);


            Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        public void Euro_Dolar() {

            double resultado = 0;
            double Moneda = 0;

            Moneda = ingresa_Moneda(Moneda: 0);

            resultado = Moneda * (0.99);

            Console.WriteLine(+Moneda + " Euros a Dolar = " + resultado);


            Console.WriteLine("PULSE CUALQUIER TECLA PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }


    }
}

