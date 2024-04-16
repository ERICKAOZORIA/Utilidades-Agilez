   namespace ProyectoFinal {
    internal class Program {
        static void Main(string[] args) {
            string option;
            Textos texto = new Textos();
            Eventos eventos = new Eventos();
            Conversor conversor = new Conversor();
            Calculadora calculadora = new Calculadora();
            do {
                Console.Clear();
                texto.menuPrincipal();
                option = Console.ReadLine()!;
                switch (option) {
                    case "1": Contactos.contactosMain(); break;
                    case "2": eventos.eventosMain(); break;
                    case "3": conversor.conversorMain(); break;
                    case "4": calculadora.calculadoraMain();break;
                    case "5": break;
                    default:Console.WriteLine("NO ESTA DISPONIBLE");break;
                }
            } while (option != "5");
        }
    }
}