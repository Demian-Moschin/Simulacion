using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Eventos
{
    public class CatalogoDeEventos
    {
        IList<Evento > _LEV = new List< Evento>();
        public IList<Evento> LEV { get { return _LEV; } set { _LEV = value; } }


        public void guardarEvento(Evento  proximoEvento)
        {
            //Como se producen partidas con tiempo infinito, vamos a mantener solamente Una partida con tiempo
            //infinito. Si se intenta guardar otra, la descartamos. 

            if (proximoEvento is Partida && proximoEvento.DevolverTiempoEvento == double.PositiveInfinity  )
            {
                var tipoPartida = LEV.OfType<Partida>();
                var sel =
                    from e in tipoPartida
                    where e.DevolverTiempoEvento  == double.PositiveInfinity
                    select e;

                //si no hay partidas con tiempo infinito, agregamos el evento. 
                //sino, no hacemos nada (void)
                if (sel.Count() == 0)
                {
                    LEV.Add(proximoEvento);
                }


            }
            else 
            {
                //si es arribo, no hay que validar que existan varias partidas con tiempo infinito.
                LEV.Add(proximoEvento); 
            }
                
            
            



        }

    }
}
