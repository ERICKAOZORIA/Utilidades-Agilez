using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoFinal {
    internal class Eventos {
        Textos textos = new Textos();
        private List<string> nombre = new List<string>(0);
        private List<string> fecha = new List<string>(0);
        private List<string> hora = new List<string>(0);
        private List<string> lugar = new List<string>(0);

        // MENU PRINCIPAL
        public void eventosMain() {
            int option;
            do {
                textos.menuEvento();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option) {
                    case 1: verEventos(); break;
                    case 2: agregarEvento(); break;
                    case 3: editarEvento(); break;
                    case 4: buscarEvento(); break;
                    case 5: borrarEvento(); break;
                    case 6: break;
                    default: textos.opcionNoDisponible(option); break;
                }
            } while (option != 6);
        }

        // OPCION PARA VER EVENTOS
        public void verEventos() {
            if (nombre.Count > 0) {
                int option;
                int i;
                do {
                    i = 0;
                    textos.eventosDisponibles();
                    foreach (string evento in nombre) {
                        Console.WriteLine($"[{i}] = {evento}");
                        i++;
                    }
                    Console.WriteLine($"[{i}] = Salir");
                    textos.seleccionaUnEvento();

                    option = Convert.ToInt32(Console.ReadLine());
                    if (option < nombre.Count && option > -1) {
                        int option2;
                        do {
                            textos.detallesDelEvento(nombre, fecha, hora, lugar, option);
                            option2 = Convert.ToInt32(Console.ReadLine());
                            if (option2 == 2) {
                                i = option;
                            } else if (option2 == 1) {
                                option = 0;
                            } else {
                                textos.opcionNoDisponible(option2);
                            }
                        } while (option2 != 1 && option2 != 2);
                    } else if (option == i) { } else {
                        textos.opcionNoDisponible(option);
                        option = 0;
                    }
                } while (option != i);
            } else {
                textos.noHayEventos();
            }
        }

        // OPCION PARA AGREGAR EVENTOS
        public void agregarEvento() {
            textos.datosDelEventos();
            nombreEvento();
            fechaEvento();
            horaEvento();
            lugarEvento();
            textos.eventoGuardado();
        }


        // OPCION PARA VER EDITAR EVENTOS
        public void editarEvento() {
            int option;
            int i;
            if (nombre.Count > 0) {
                do {
                    Console.Clear();
                    textos.seleccionaEditar();
                    i = 0;
                    foreach (string evento in nombre) {
                        Console.WriteLine($"[{i}] = {evento}");
                        i++;
                    }
                    Console.WriteLine($"[{i}] = Salir");
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option < nombre.Count && option > -1) {
                        int option2;
                        bool optionCorrecta;
                        do {
                            textos.eventoSeleccionado(nombre, fecha, hora, lugar, option);
                            option2 = Convert.ToInt32(Console.ReadLine());
                            switch (option2) {
                                case 1:
                                    textos.seleccionaNuevaInformacion("nombre");
                                    string nuevoNombre = Console.ReadLine()!;
                                    nombre[option] = nuevoNombre;
                                    optionCorrecta = true;
                                    break;
                                case 2:
                                    textos.seleccionaNuevaInformacion("fecha");
                                    string nuevaFecha = Console.ReadLine()!;
                                    fecha[option] = nuevaFecha;
                                    optionCorrecta = true;
                                    break;
                                case 3:
                                    textos.seleccionaNuevaInformacion("hora");
                                    string nuevaHora = Console.ReadLine()!;
                                    hora[option] = nuevaHora;
                                    optionCorrecta = true;
                                    break;
                                case 4:
                                    textos.seleccionaNuevaInformacion("lugar");
                                    string nuevoLugar = Console.ReadLine()!;
                                    lugar[option] = nuevoLugar;
                                    optionCorrecta = true;
                                    break;
                                case 5: optionCorrecta = true; break;
                                default: optionCorrecta = false;
                                    textos.opcionNoDisponible(option2);
                                    break;
                            }
                        } while (optionCorrecta == false);
                        if (option2 != 5) {
                            textos.eventoCambiado(nombre, fecha, hora, lugar, option);
                        }

                    } else {
                        if (option != nombre.Count) {
                            textos.opcionNoDisponible(option);
                        }
                    }
                } while (option != nombre.Count);
            } else {
                textos.noHayEventos();
            }

        }

        // OPCION PARA BUSCAR EVENTOS
        public void buscarEvento() {
            if (nombre.Count > 0) {
                int option;
                do {
                    textos.buscarEvento();
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option) {
                        case 1:
                            bool encontrarNombre = false;
                            Console.Clear();
                            Console.Write("| INTRODUCE EL NOMBRE DEL EVENTO: ");
                            string nombreBuscar = Console.ReadLine()!;
                            int i = 0;
                            foreach (string nombre in nombre) {
                                if (nombreBuscar.Equals(nombre, StringComparison.InvariantCultureIgnoreCase)) {
                                    textos.eventoEncontrado(nombre, this.nombre, fecha, hora, lugar, i, "nombre");
                                    encontrarNombre = true;
                                }
                                i++;
                            }

                            if (encontrarNombre == false) {
                                textos.eventoNoEncontrado();
                            }
                            break;
                        case 2:
                            bool encontrarFecha = false;
                            Console.Clear();
                            Console.Write("| INTRODUCE LA FECHA DEL EVENTO: ");
                            string fechaBuscar = Console.ReadLine()!;
                            i = 0;
                            foreach (string fecha in fecha) {
                                if (fechaBuscar.Equals(fecha, StringComparison.InvariantCultureIgnoreCase)) {
                                    textos.eventoEncontrado(fecha, nombre, this.fecha, hora, lugar, i, "fecha");
                                    encontrarFecha = true;
                                }
                                i++;
                            }
                            if (encontrarFecha == false) {
                                textos.eventoNoEncontrado();
                            }
                            break;
                        case 3:
                            bool encontrarHora = false;
                            Console.Clear();
                            Console.Write("| INTRODUCE LA HORA DEL EVENTO: ");
                            string horaBuscar = Console.ReadLine()!;
                            i = 0;
                            foreach (string hora in hora) {
                                if (horaBuscar.Equals(hora, StringComparison.InvariantCultureIgnoreCase)) {
                                    textos.eventoEncontrado(hora, nombre, fecha, this.hora, lugar, i, "hora");
                                    encontrarHora = true;

                                }
                                i++;
                            }
                            if (encontrarHora == false) { textos.eventoNoEncontrado(); }
                            break;
                        case 4:
                            bool encontrarLugar = false;
                            Console.Clear();
                            Console.Write("| INTRODUCE EL LUGAR DEL EVENTO: ");
                            string lugarBuscar = Console.ReadLine()!;
                            i = 0;
                            foreach (string lugar in lugar) {
                                if (lugarBuscar.Equals(lugar, StringComparison.InvariantCultureIgnoreCase)) {
                                    textos.eventoEncontrado(lugar, nombre, fecha, hora, this.lugar, i, "lugar");
                                    encontrarLugar = true;

                                }
                                i++;
                            }
                            if (encontrarLugar == false) {
                                textos.eventoNoEncontrado();
                            }
                            break;
                        case 5: break;
                        default: textos.opcionNoDisponible(option); break;
                    }
                } while (option != 5);
            } else {
                textos.noHayEventos();
            }
        }

        // OPCION PARA BORRAR EVENTOS
        public void borrarEvento() {
            int option;
            int salir;
            salir = 0;
            if (nombre.Count > 0) {
                do {
                    if (nombre.Count == 0) {
                        Console.Clear();
                        textos.noHayEventos();
                        option = salir;
                    } else {
                        Console.Clear();
                        salir = 0;
                        textos.miniTextosBorrar("elige");
                        for (int i = 0; i < nombre.Count; i++) {
                            textos.borrarEventos(i, nombre);
                            salir++;
                        }

                        Console.WriteLine($"                      [{salir}] SALIR ");
                        Console.Write($"                      ");
                        option = Convert.ToInt32(Console.ReadLine());
                        if (option < nombre.Count && option > -1) {
                            textos.detallesEventoABorrar(nombre, fecha, hora, lugar, option);
                            string option2 = Console.ReadLine()!;
                            if (option2.Equals("si", StringComparison.InvariantCultureIgnoreCase)) {
                                nombre.Remove(nombre[option]);
                                fecha.Remove(fecha[option]);
                                hora.Remove(hora[option]);
                                lugar.Remove(lugar[option]);
                                textos.miniTextosBorrar("borrado");
                            }
                        } else {
                            if (option != salir) {
                                textos.miniTextosBorrar("no existe");
                            }
                        }
                    }
                } while (option != salir);
            } else {
                textos.noHayEventos();
            }
        }


        // OPCION PARA AGREGAR LA NOMBRE DE UN EVENTO
        private List<string> nombreEvento() {

            textos.detallesDelEvento("nombre");
            string nombreEvento = Console.ReadLine()!;
            this.nombre.Add(nombreEvento);
            return this.nombre;
        }

        // OPCION PARA AGREGAR LA FECHA DE UN EVENTO
        private List<string> fechaEvento() {
            textos.detallesDelEvento("fecha");
            string fechaEvento = Console.ReadLine()!;
            this.fecha.Add(fechaEvento);
            return this.fecha;
        }

        // OPCION PARA AGREGAR LA HORA DE UN EVENTO
        private List<string> horaEvento() {
            textos.detallesDelEvento("hora");
            string horaEvento = Console.ReadLine()!;
            this.hora.Add(horaEvento);
            return this.hora;
        }

        // OPCION PARA AGREGAR EL LUGAR DE UN EVENTO
        private List<string> lugarEvento() {
            textos.detallesDelEvento("lugar");
            string lugarEvento = Console.ReadLine()!;
            Console.WriteLine("|-----------------------------------------------|");
            this.lugar.Add(lugarEvento);
            return this.lugar;
        }

    }
}
