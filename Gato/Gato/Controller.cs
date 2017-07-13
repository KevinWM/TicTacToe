using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gato
{
    class Controller
    {
        View view;
        Model model;

        public Controller(Model model, View view)
        {
            
            this.model = model;
            this.view = view;
        }

        public void mensajeInicialConsola()
        {
            this.view.ImprimirMensajeInicial();
        }

        public Boolean verificarSiElJuegoContinua()
        {
            return this.model.verificarSiElJuegoContinua();
        }

        public void jugarUnTurno() 
        {
            while (true)
            {
                this.view.dibujarTablero(this.model.tablero, "X");
                int selection = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
