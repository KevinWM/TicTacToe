using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gato
{
    class View
    {
        Model model;

        public View(Model model)
        {
            this.model = model;
        }

        public void ImprimirMensajeInicial()
        {
            Console.Title = ("Tic Tac Toe Version 2");
            Console.WriteLine("Welcome to Tic Tac Toe.\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public void dibujarTablero(String[] tablero,String jugador)
        {
            Console.Clear();
            Console.WriteLine("Jugador: " + jugador);
            Console.WriteLine("Seleccione el numero de la posicion donde desea poner la ficha");
            for (int i = 0; i < 7; i += 3)
            {
                Console.WriteLine(tablero[i] + "|" + tablero[i + 1] + "|" + tablero[i + 2]);
            }
        
        }

    }
}
