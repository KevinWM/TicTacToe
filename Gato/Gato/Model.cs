using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gato
{
    class Model
    {

        public String[] tablero = new String[9];
        private int cantidadTurnos;
        public Model()
        {
            this.cantidadTurnos = 0;
            for (int i = 0; i < 9; i++)
            {
                this.tablero[i] = i.ToString();
            }
        }

        public Boolean verificarSiElJuegoContinua()
        {
           if(empate() || alguienGano())
                return false;
            return true;
        }

        private Boolean empate()
        {
            if (this.cantidadTurnos == 9)
                return true;
            return false;
        }

        public Boolean alguienGano() 
        {
            if (isPosicionesEnElTableroIgual(0, 1, 2))
                return true;
            if (isPosicionesEnElTableroIgual(3, 4, 5))
                return true;
            if (isPosicionesEnElTableroIgual(6, 7, 8))
                return true;
            if (isPosicionesEnElTableroIgual(0, 3, 6))
                return true;
            if (isPosicionesEnElTableroIgual(1, 4, 7))
                return true;
            if (isPosicionesEnElTableroIgual(2, 5, 8))
                return true;
            if (isPosicionesEnElTableroIgual(0, 4, 8))
                return true;
            if (isPosicionesEnElTableroIgual(2, 4, 6))
                return true;

            return false;
        }

        private Boolean isPosicionesEnElTableroIgual(int posicion1, int posicion2, int posicion3)
        {
            if (this.tablero[posicion1].Equals(this.tablero[posicion2]) && this.tablero[posicion2].Equals(this.tablero[posicion3]))
                return true;
            return false;
        }

        public Boolean verificarSiIngresoPosicionValida(string Seleccion)
        {
            int posicion = Convert.ToInt32(Seleccion);
            if (isNumeroEntre0y9(posicion) || (yaExisteUnaX(posicion) || yaExisteUnaO(posicion)))
                return false;
            return true;
        }

        private Boolean isNumeroEntre0y9(int posicion)
        {
            if (posicion < 0 || posicion > 9)
                return true;
            return false;
        }

        private Boolean yaExisteUnaX(int posicion)
        {
            if (this.tablero[posicion].Equals("X"))
                return true;
            return false;
        }

        private Boolean yaExisteUnaO(int posicion)
        {
            if (this.tablero[posicion].Equals("O"))
                return true;
            return false;
        }

        public void agregarFiguraTablero(string figura, string posicion)
        {
            this.cantidadTurnos++;
            this.tablero[Convert.ToInt32(posicion)] = figura;
        }

    }
}
