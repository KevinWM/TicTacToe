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
            Console.Clear();
            Console.Title = ("Tic Tac Toe Prueba Pernix");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();
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

        public void gano()
        {
            Console.WriteLine("Has ganado");
        }

        public void empato()
        {
            Console.WriteLine("Empate");
        }

        public void dibujarTableroFinal(string[] tablero)
        {
            Console.Clear();
            for (int i = 0; i < 7; i += 3)
            {
                Console.WriteLine(tablero[i] + "|" + tablero[i + 1] + "|" + tablero[i + 2]);
            }
        }

    }
}
