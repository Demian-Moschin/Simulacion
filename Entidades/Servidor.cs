using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Servidor
    {
        private double _tiempoOcupacionServidor;
        public double TiempoInicioOcupacionServidor { get { return Math.Round(_tiempoOcupacionServidor,3); } set { _tiempoOcupacionServidor = value; } }

        private int  clientesAtendido;
        public int ClientesAtendidos { get { return clientesAtendido; } set { clientesAtendido = value; } }

        private double area_status_servidor;
        public double AreaStatusServidor { get { return Math.Round(area_status_servidor,3); } set { area_status_servidor = value; } }

        private Cliente _cliente;
        public Cliente ClienteEnServicio { get { return _cliente; } set { _cliente = value; } }
        
        public Servidor()
        {

            ClienteEnServicio = null;
            this.ClientesAtendidos =0;

            /*control estadistico*/
            AreaStatusServidor = 0.0;
            TiempoInicioOcupacionServidor = 0.0;
        }

        internal void CalcularArea(double tiempoDesdeUltimoEvento)
        {
            AreaStatusServidor = AreaStatusServidor +  tiempoDesdeUltimoEvento; 
        }




        internal bool estaOcupado()
        {
            if (this.ClienteEnServicio != null)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public void servirCliente(Cliente cliente)
        {
            
            this.ClienteEnServicio  = cliente ;
            ClientesAtendidos = ClientesAtendidos + 1;
          

        }

        public void   producirPartida(double reloj)
        {
            AreaStatusServidor = AreaStatusServidor + (reloj - this.TiempoInicioOcupacionServidor);
            ClienteEnServicio = null;
        }
    }
}
