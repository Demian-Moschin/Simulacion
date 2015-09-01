using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public  class Arribo: Evento
    {
        //probemos una tasa de arribos de 2 clientes por minuto
        //implica tiempo entre arribos -> 0.505 por minuto
        private double media = 1;
        
        private double tiempoArribo;

        public Arribo(double  reloj)
        {
            this.tiempoArribo = reloj + base.devolverRandom(media);
          
        }
        public override double DevolverTiempoEvento
        {
            get
            {
                return Math.Round(tiempoArribo,3);
            }
            set
            {
                tiempoArribo = Math.Round(value,3);
            }
        }

    
       
    
    }
}
