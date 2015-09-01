using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private double   tiempoArribo;
        public double TiempoArriboServidorOcupado { get { return tiempoArribo; } set { tiempoArribo = value; } }

        private Arribo  _arribo;
        public Arribo arribo { get { return _arribo; } set { _arribo = value; } }
        private Partida _partida;
        public Partida partida { get { return _partida; } set { _partida = value; } }

        public Cliente() 
        {
            TiempoArriboServidorOcupado = 0.0;
            arribo= new Arribo(0);
        }


        internal void setTiempoArriboPorServidorOcupado(double ta )
        {
            TiempoArriboServidorOcupado = ta;
        }
    }
}
