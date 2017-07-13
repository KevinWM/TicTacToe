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
            if(empate() && alguienGano())
                return false;
            return true;
        }

        private Boolean empate()
        {
            if (this.cantidadTurnos == 9)
                return true;
            return false;
        }

        private Boolean alguienGano() 
        {
            if (this.tablero[0].Equals(this.tablero[1]) && this.tablero[1].Equals(this.tablero[2]))
                return true;
            if (this.tablero[3].Equals(this.tablero[4]) && this.tablero[4].Equals(this.tablero[5]))
                return true;
            if (this.tablero[6].Equals(this.tablero[7]) && this.tablero[7].Equals(this.tablero[8]))
                return true;
            if (this.tablero[0].Equals(this.tablero[3]) && this.tablero[3].Equals(this.tablero[6]))
                return true;
            if (this.tablero[1].Equals(this.tablero[4]) && this.tablero[4].Equals(this.tablero[7]))
                return true;
            if (this.tablero[2].Equals(this.tablero[5]) && this.tablero[5].Equals(this.tablero[8]))
                return true;
            if (this.tablero[0].Equals(this.tablero[4]) && this.tablero[4].Equals(this.tablero[8]))
                return true;
            if (this.tablero[2].Equals(this.tablero[4]) && this.tablero[4].Equals(this.tablero[6]))
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

    }
}
