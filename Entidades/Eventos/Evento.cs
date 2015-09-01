using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract    class Evento
    {

        protected double devolverRandom(double media)
        {
            return EntidadesGenerales.GeneradorRandom.devolverRandom(media);
        }

        public abstract double DevolverTiempoEvento { get; set; }
     
    }
}
