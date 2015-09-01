using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Partida: Evento 
    {
        private double media = 0.5;
        private double tiempoServicio;

        public Partida(double reloj)
        {
            this.TiempoDeServicio = reloj + base.devolverRandom(media);
          
        }


        public override double DevolverTiempoEvento
        {
            get
            {
                return Math.Round(TiempoDeServicio,3);
            }
            set
            {
                TiempoDeServicio = Math.Round(value,3);
            }
              
        }

        public double TiempoDeServicio { get { return Math.Round(tiempoServicio,3); } set { tiempoServicio = value; } }
        public void SetTiempoServicioInfinito() { TiempoDeServicio = double.PositiveInfinity; }
    }
}
