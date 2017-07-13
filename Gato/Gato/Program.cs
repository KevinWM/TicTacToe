using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gato
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            View view = new View(model);
            Controller controller = new Controller(model, view);

            controller.mensajeInicialConsola();
            while (controller.verificarSiElJuegoContinua())
            {
                controller.jugarUnTurno();
                controller.jugarUnTurno("X");
                if (controller.verificarSiElJuegoContinua() == false)
                    break;
                controller.jugarUnTurno("O");
            }

            Console.ReadLine();

        }
    }
}
