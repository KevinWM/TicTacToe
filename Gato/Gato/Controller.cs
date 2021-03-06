﻿using System;
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
        
        public void jugarUnTurno(string jugador) 
        {
            while (true)
            {
                this.view.dibujarTablero(this.model.tablero, jugador);
                string seleccion = Console.ReadLine();
                Boolean esPosicionValida = this.model.verificarSiIngresoPosicionValida(seleccion);
                if (esPosicionValida)
                {
                    this.model.agregarFiguraTablero(jugador, seleccion);
                    break;
                }
            }
        }

        public void verificarFindeJuego() 
        {
            bool siGanoAlguien = this.model.alguienGano();
            if (siGanoAlguien == false)
            {
                this.view.dibujarTableroFinal(this.model.tablero);
                this.view.empato();

            }
            else
            {
                this.view.dibujarTableroFinal(this.model.tablero);
                this.view.gano();
            }
        }

    }
}
