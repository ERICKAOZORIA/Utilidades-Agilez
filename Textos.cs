using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal {
    internal class Textos {
        // |----------------------------------|
        // |        MENU PRINCIPAL PROGRAM    |
        // |        MENU PRINCIPAL PROGRAM    |
        // |        MENU PRINCIPAL PROGRAM    |
        // |----------------------------------|
        public void menuPrincipal() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"

                                    ███╗   ███╗███████╗███╗   ██╗██╗   ██╗              
                                    ████╗ ████║██╔════╝████╗  ██║██║   ██║              
                                    ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║              
                                    ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║              
                                    ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝              
                                    ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝               
                                                                
                        ██████╗ ██████╗ ██╗███╗   ██╗ ██████╗██╗██████╗  █████╗ ██╗     
                        ██╔══██╗██╔══██╗██║████╗  ██║██╔════╝██║██╔══██╗██╔══██╗██║     
                        ██████╔╝██████╔╝██║██╔██╗ ██║██║     ██║██████╔╝███████║██║     
                        ██╔═══╝ ██╔══██╗██║██║╚██╗██║██║     ██║██╔═══╝ ██╔══██║██║     
                        ██║     ██║  ██║██║██║ ╚████║╚██████╗██║██║     ██║  ██║███████╗
                        ╚═╝     ╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝ ╚═════╝╚═╝╚═╝     ╚═╝  ╚═╝╚══════╝

                                 |------------------------------------------|            
                                 |-                  MENU                  -|            
                                 |-         SELECCIONE UNA OPCION          -|            
                                 |-                                        -|            
                                 |-   1. CONTACTOS                         -|            
                                 |-   2. EVENTOS                           -|            
                                 |-   3. CONVERSOR                         -|
                                 |-   4. CALCULADORA                       -|
                                 |-   5. SALIR                             -|            
                                 |-                                        -|            
                                 |------------------------------------------| 



                                                     ");
            Console.ResetColor();
        }

        // |----------------------------------|
        // |        TEXTOS DE CONVERSOR       |
        // |        TEXTOS DE CONVERSOR       |
        // |        TEXTOS DE CONVERSOR       |
        // |----------------------------------|

        public void conversorTextoMain() {
            Console.Write(@"
            |------------------------------|
            |    ¿QUE DESEAS CONVERTIR     |
            |------------------------------|

                           [1]
                -- CONVERSOR DE GRADOS --
                           
                           [2]
                -- CONVERSOR DE MONEDA --
           
                           [3]
                       -- SALIR --

                        ");
        }

        public void conversorGrados() {
            Console.Write(@"
                    |---------------------------|    
                    | ¿DE QUE DESEAS CONVERTIR? |
                    |---------------------------|    
        
                    [1] = Fahrenheit a Celcius
                    [2] = Celcius a Fahrenheit
                    [3] = Fahrenheit a Kelvin
                    [4] = Kelvin a Fahrenheit    
                    [5] = Kelvin a Celcius    
                    [6] = Celcius a Kelvin
                    [7] = Salir

                    ");
        }
        public void conversorMoneda() {
            Console.Write(@"
                    |-----------------------------|    
                    |        TASAS DE CAMBIO      |
                    |        DOLAR : 55.50        |
                    |        EURO  : 55.50        |
                    |-----------------------------|  


                    |-----------------------------|    
                    | ¿QUE MONEDA DESEAS CAMBIAR? |
                    |-----------------------------|    
        
                          [1] = Euro  a  Peso
                          [2] = Dolar a  Peso
                          [3] = Peso  a  Euro
                          [4] = Peso  a  Dolar
                          [5] = Dolar a  Euro
                          [6] = Euro  a  Dolar
                          [7] = Salir

                    ");
        }

        // |----------------------------------|
        // |        TEXTOS DE EVENTOS         |
        // |        TEXTOS DE EVENTOS         |
        // |        TEXTOS DE EVENTOS         |
        // |----------------------------------|

        // |----------------|
        // |  VER  EVENTOS  |
        // |----------------|
        public void eventosDisponibles() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗╔═╗  ╔╦╗╦╔═╗╔═╗╔═╗╔╗╔╦╔╗ ╦  ╔═╗╔═╗
║╣ ╚╗╔╝║╣ ║║║ ║ ║ ║╚═╗   ║║║╚═╗╠═╝║ ║║║║║╠╩╗║  ║╣ ╚═╗
╚═╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝╚═╝  ═╩╝╩╚═╝╩  ╚═╝╝╚╝╩╚═╝╩═╝╚═╝╚═╝
");
            Console.ResetColor();

        }
        public void seleccionaUnEvento() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
|----------------------------------|
| SELECCIONA UNO PARA VER DETALLES |
|----------------------------------|
");
            Console.ResetColor();
        }
        public void detallesDelEvento(List<string> nombre, List<string> fecha, List<string> hora, List<string> lugar, int option) {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
___________________________________________________________________________
.__ .___.___..__..   .   .___ __.  .__ .___.     .___.  ..___.  ..___..__.
|  \[__   |  [__]|   |   [__ (__   |  \[__ |     [__ \  /[__ |\ |  |  |  |
|__/[___  |  |  ||___|___[___.__)  |__/[___|___  [___ \/ [___| \|  |  |__|
___________________________________________________________________________
");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"             
                   |  NOMBRE = ");
            Console.ResetColor(); Console.Write(nombre[option]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"             
                   |  FECHA  = ");
            Console.ResetColor(); Console.Write(fecha[option]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"             
                   |  HORA   = ");
            Console.ResetColor(); Console.Write(hora[option]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"             
                   |  LUGAR  = "); Console.ResetColor(); Console.Write(lugar[option]);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"
                    |-----------------------|
                    | [1] = VER OTRO EVENTO |
                    | [2] = SALIR           |
                    |-----------------------|
                    
                    ");
            Console.ResetColor();
        }


        // |--------------------|
        // |  AGREGAR  EVENTOS  |
        // |--------------------|
        public void datosDelEventos() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
______________________________________________________________________________________________________
       ___  __   __   __        __   ___          __   __      __   ___ ___                 ___  __        
| |\ |  |  |__) /  \ |  \ |  | /  ` |__     |    /  \ /__`    |  \ |__   |   /\  |    |    |__  /__`     
| | \|  |  |  \ \__/ |__/ \__/ \__, |___    |___ \__/ .__/    |__/ |___  |  /~~\ |___ |___ |___ .__/    

                             __   ___          ___       ___      ___  __  
                            |  \ |__  |       |__  \  / |__  |\ |  |  /  \ 
                            |__/ |___ |___    |___  \/  |___ | \|  |  \__/ 
______________________________________________________________________________________________________
");
            Console.ResetColor();
        }

        public void detallesDelEvento(string option) {

            if (option == "nombre") {
                Console.WriteLine("|-----------------------------------------------|");
                Console.Write("| INTRODUCE EL NOMBRE: ");
            }
            if (option == "fecha") {
                Console.Write("| INTRODUCE LA FECHA : ");
            }

            if (option == "hora") {
                Console.Write("| INTRODUCE LA HORA  : ");
            }

            if (option == "lugar") {
                Console.Write("| INTRODUCE EL LUGAR : ");
            }

        }

        public void eventoGuardado() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Guardando evento.");
            Thread.Sleep(1000);
            Console.WriteLine("Guardando evento..");
            Thread.Sleep(1000);
            Console.WriteLine("Guardando evento...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(@"

 _____ _     ____  ____  ____  ____  ____  ____ 
/  __// \ /\/  _ \/  __\/  _ \/  _ \/  _ \/  _ \
| |  _| | ||| / \||  \/|| | \|| / \|| | \|| / \|
| |_//| \_/|| |-|||    /| |_/|| |-||| |_/|| \_/|
\____\\____/\_/ \|\_/\_\\____/\_/ \|\____/\____/
                                                
                                                                                                                                                                                                                                   
                                            
 ____  ____  _     
/   _\/  _ \/ \  /|
|  /  | / \|| |\ ||
|  \__| \_/|| | \||
\____/\____/\_/  \|
                                                                                                           
 ________  _ _  _____  ____ 
/  __/\  \/// \/__ __\/  _ \
|  \   \  / | |  / \  | / \|
|  /_  /  \ | |  | |  | \_/|
\____\/__/\\\_/  \_/  \____/
                            
                                                                                                                      
");
            Console.ResetColor();
            Thread.Sleep(2500);
        }

        // |--------------------|
        // |  EDITAR   EVENTOS  |
        // |--------------------|

        public void seleccionaEditar() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
______________________________________________________________________
             __..___.   .___ __  __ ._..__..  ..__.                  
            (__ [__ |   [__ /  `/  ` | |  ||\ |[__]                  
            .__)[___|___[___\__.\__._|_|__|| \||  |                  
                                                                     
.___.     .___.  ..___.  ..___..__.  .__.    .___.__ ._..___..__..__ 
[__ |     [__ \  /[__ |\ |  |  |  |  [__]    [__ |  \ |   |  [__][__)
[___|___  [___ \/ [___| \|  |  |__|  |  |    [___|__/_|_  |  |  ||  \   
______________________________________________________________________
");
            Console.ResetColor();
        }

        public void seleccionaNuevaInformacion(string dato) {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            if (dato == "nombre") {
                Console.Write("| SELECCIONA EL NUEVO NOMBRE: ");
            }
            if (dato == "fecha") {
                Console.Write("| SELECCIONA LA NUEVA FECHA: ");
            }
            if (dato == "hora") {
                Console.Write("| SELECCIONA LA NUEVA HORA: ");
            }
            if (dato == "lugar") {
                Console.Write("| SELECCIONA EL NUEVO LUGAR: ");
            }
            Console.ResetColor();

        }
        public void eventoSeleccionado(List<string> nombre, List<string> fecha, List<string> hora, List<string> lugar, int option) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("|-------------------------------------------------->");
            Console.WriteLine($"| EVENTO SELECCIONADO: {nombre[option]}");
            Console.WriteLine($"|");
            Console.WriteLine($"| DETALLES DEL EVENTO:");
            Console.Write($"| NOMBRE: "); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(nombre[option]); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"| FECHA : "); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(fecha[option]); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"| HORA  : "); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(hora[option]); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"| LUGAR : "); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(lugar[option]); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|-------------------------------------------------->");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"
|--------------------------------|
| ¿QUE DESEAS EDITAR DEL EVENTO? |
|       [1] = EL NOMBRE          |
|       [2] = LA FECHA           |
|       [3] = LA HORA            |
|       [4] = EL LUGAR           |
|       [5] = VOLVER ATRAS       |
|--------------------------------|
");
            Console.ResetColor();

        }
        public void eventoCambiado(List<string> nombre, List<string> fecha, List<string> hora, List<string> lugar, int option) {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("|        EVENTO ACTUALIZADO CON EXITO        |");
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("|");
            Console.Write($"| NOMBRE: "); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(nombre[option]); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"| FECHA : "); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(fecha[option]); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"| HORA  : "); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(hora[option]); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"| LUGAR : "); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(lugar[option]); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"|
|--------------------------------------------|
|    PRESIONA CUALQUIER TECLA PARA VOLVER    |
|--------------------------------------------|
");
            Console.ResetColor();
            Console.ReadKey();

        }

        // |--------------------|
        // |  BUSCAR   EVENTOS  |
        // |--------------------|

        public void buscarEvento() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@"
                                |-----------------------------|
                                | -SELECCIONA LA OPCION PARA- |
                                |     -BUSCAR EL EVENTO-      |
                                |                             |
                                |                             |
                                |    BUSCAR EL EVENTO POR:    |
                                |                             |
                                |      [1] = NOMBRE           |
                                |      [2] = FECHA            |
                                |      [3] = HORA             |
                                |      [4] = LUGAR            |
                                |      [5] = SALIR            |
                                |-----------------------------|
                              

                                ");
            Console.ResetColor();
        }


        public void eventoEncontrado(string buscado, List<string> nombre, List<string> fecha, List<string> hora, List<string> lugar, int i, string dato) {
            Console.Clear();
            if (dato == "nombre") {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(@$"
                                  ╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗     
                                  ║╣ ╚╗╔╝║╣ ║║║ ║ ║ ║     
                                  ╚═╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝     
                            ╔═╗╔╗╔╔═╗╔═╗╔╗╔╔╦╗╦═╗╔═╗╔╦╗╔═╗
                            ║╣ ║║║║  ║ ║║║║ ║ ╠╦╝╠═╣ ║║║ ║
                            ╚═╝╝╚╝╚═╝╚═╝╝╚╝ ╩ ╩╚═╩ ╩═╩╝╚═╝
"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(@$" 
                            -> NOMBRE BUSCADO: {buscado}

                            |----------------------------|
                            |     DETALLES DEL EVENTO    |
                            |----------------------------|


                            NOMBRE -> {buscado}
                            FECHA  -> {fecha[i]}
                            HORA   -> {hora[i]}
                            LUGAR  -> {lugar[i]}
");

            }
            Console.ResetColor();
            if (dato == "fecha") {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"
                                  ╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗     
                                  ║╣ ╚╗╔╝║╣ ║║║ ║ ║ ║     
                                  ╚═╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝     
                            ╔═╗╔╗╔╔═╗╔═╗╔╗╔╔╦╗╦═╗╔═╗╔╦╗╔═╗
                            ║╣ ║║║║  ║ ║║║║ ║ ╠╦╝╠═╣ ║║║ ║
                            ╚═╝╝╚╝╚═╝╚═╝╝╚╝ ╩ ╩╚═╩ ╩═╩╝╚═╝
"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(@$" 
                            -> FECHA BUSCADA: {buscado}

                            |----------------------------|
                            |     DETALLES DEL EVENTO    |
                            |----------------------------|


                            NOMBRE -> {nombre[i]}
                            FECHA  -> {buscado}
                            HORA   -> {hora[i]}
                            LUGAR  -> {lugar[i]}
");
                Console.ResetColor();
            }
            if (dato == "hora") {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"
                                  ╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗     
                                  ║╣ ╚╗╔╝║╣ ║║║ ║ ║ ║     
                                  ╚═╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝     
                            ╔═╗╔╗╔╔═╗╔═╗╔╗╔╔╦╗╦═╗╔═╗╔╦╗╔═╗
                            ║╣ ║║║║  ║ ║║║║ ║ ╠╦╝╠═╣ ║║║ ║
                            ╚═╝╝╚╝╚═╝╚═╝╝╚╝ ╩ ╩╚═╩ ╩═╩╝╚═╝
"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(@$" 
                            -> HORA ENCONTRADA: {buscado}

                            |----------------------------|
                            |     DETALLES DEL EVENTO    |
                            |----------------------------|


                            NOMBRE -> {nombre[i]}
                            FECHA  -> {fecha[i]}
                            HORA   -> {buscado}
                            LUGAR  -> {lugar[i]}
");
                Console.ResetColor();
            }
            if (dato == "lugar") {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"
                                  ╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗     
                                  ║╣ ╚╗╔╝║╣ ║║║ ║ ║ ║     
                                  ╚═╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝     
                            ╔═╗╔╗╔╔═╗╔═╗╔╗╔╔╦╗╦═╗╔═╗╔╦╗╔═╗
                            ║╣ ║║║║  ║ ║║║║ ║ ╠╦╝╠═╣ ║║║ ║
                            ╚═╝╝╚╝╚═╝╚═╝╝╚╝ ╩ ╩╚═╩ ╩═╩╝╚═╝
"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(@$" 
                            -> LUGAR ENCONTRADO: {buscado}

                            |----------------------------|
                            |     DETALLES DEL EVENTO    |
                            |----------------------------|


                            NOMBRE -> {nombre[i]}
                            FECHA  -> {fecha[i]}
                            HORA   -> {hora[i]}
                            LUGAR  -> {buscado}
");
                Console.ResetColor();
            }
            Console.WriteLine(@"
               --- PRESIONE CUALQUIER TECLA PARA BUSCAR OTRO EVENTO ---
");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        public void eventoNoEncontrado() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"


 _____ _     _____ _      _____  ____ 
/  __// \ |\/  __// \  /|/__ __\/  _ \
|  \  | | //|  \  | |\ ||  / \  | / \|
|  /_ | \// |  /_ | | \||  | |  | \_/|
\____\\__/  \____\\_/  \|  \_/  \____/
                                      
                                 
                                                                                                              

 _      ____    _____ _      ____  ____  _      _____  ____  ____  ____  ____ 
/ \  /|/  _ \  /  __// \  /|/   _\/  _ \/ \  /|/__ __\/  __\/  _ \/  _ \/  _ \
| |\ ||| / \|  |  \  | |\ |||  /  | / \|| |\ ||  / \  |  \/|| / \|| | \|| / \|
| | \||| \_/|  |  /_ | | \|||  \__| \_/|| | \||  | |  |    /| |-||| |_/|| \_/|
\_/  \|\____/  \____\\_/  \|\____/\____/\_/  \|  \_/  \_/\_\\_/ \|\____/\____/
                                                                              

                        

                        --- PRESIONE CUALQUIER TECLA E INTENTELO DE NUEVO ---
");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }


        // |--------------------|
        // |  BORRAR   EVENTOS  |
        // |--------------------|
        public void detallesEventoABorrar(List<string> nombre, List<string> fecha, List<string> hora, List<string> lugar, int i) {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@$"
                            |----------------------------|
                            |     DETALLES DEL EVENTO    |
                            |----------------------------|


                            NOMBRE -> {nombre[i]}
                            FECHA  -> {fecha[i]}
                            HORA   -> {hora[i]}
                            LUGAR  -> {lugar[i]}

                            ¿SEGURO QUE QUIERES BORRARLO?
                            
                            [SI]
                            [NO]

                            ");
            Console.ResetColor();

        }

        public void borrarEventos(int i, List<string> nombre) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($@"
        |---------------------------------------------|
            _     _     _     _     _     _       _  
           / \   / \   / \   / \   / \   / \     / \ 
"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@$"          ( E ) ( V ) ( E ) ( N ) ( T ) ( O )   ( {i} )");
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(@$"           \_/   \_/   \_/   \_/   \_/   \_/     \_/ 
          

                      NOMBRE -> {nombre[i]}
        |---------------------------------------------|");
            Console.ResetColor();
        }

        public void miniTextosBorrar(string texto) {
            if (texto == "elige") {
                Console.WriteLine(@"
               -- SELECCIONA EL EVENTO A BORRAR --
");
            }
            if (texto == "borrado") {
                Console.WriteLine(@"
                            |----------------------------|
                            |  EVENTO BORRADO CON EXITO  |
                            |----------------------------|
");
                Console.ReadKey();
            }
            if (texto == "no existe") {
                Console.WriteLine(@"
                  -- NO EXISTE ESE EVENTO --
        -- PULSA CUALQUIER TECLA E INTENTELO DE NUEVO--
");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // |-------------|
        // |  GENERALES  |
        // |-------------|

        public void menuEvento() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(@"

                                                            ─────█─▄▀█──█▀▄─█─────
                                                            ────▐▌──────────▐▌────
                                                             ────█▌▀▄──▄▄──▄▀▐█────
                                                             ───▐██──▀▀──▀▀──██▌───
                                                             ──▄████▄──▐▌──▄████▄──
                                                              ___________________
                                                             |      EVENTOS      |
                                                             |                   |
                                                             |      OPCIONES     |
                                                             |___________________|
");
            Console.ResetColor();
            Console.Write(@"
                                                              [1] = VER EVENTOS

                                                              [2] = AGREGAR EVENTO

                                                              [3] = EDITAR EVENTO

                                                              [4] = BUSCAR EVENTO

                                                              [5] = BORRAR EVENTO

                                                              [6] = SALIR
                    
                                                              ");

        }

        public void opcionNoDisponible(int i) {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"
|-----------------------------------------------|
|        LA OPCION [{i}] NO ESTA DIPONIBLE        |
|    PRESIONA UNA TECLA E INTENTALO DE NUEVO    |
|-----------------------------------------------|
");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public void noHayEventos() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
   | |                                                                            | |
   | |  ╔╗╔╔═╗  ╦ ╦╔═╗╦ ╦  ╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗╔═╗  ╔╦╗╦╔═╗╔═╗╔═╗╔╗╔╦╔╗ ╦  ╔═╗╔═╗  | |
   | |  ║║║║ ║  ╠═╣╠═╣╚╦╝  ║╣ ╚╗╔╝║╣ ║║║ ║ ║ ║╚═╗   ║║║╚═╗╠═╝║ ║║║║║╠╩╗║  ║╣ ╚═╗  | |
   | |  ╝╚╝╚═╝  ╩ ╩╩ ╩ ╩   ╚═╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝╚═╝  ═╩╝╩╚═╝╩  ╚═╝╝╚╝╩╚═╝╩═╝╚═╝╚═╝  | |
   | |                --PRESIONA CUALQUIER TECLA PARA SALIR--                     | |
 
");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
