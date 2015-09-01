using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesGenerales
{
    public static  class GeneradorRandom
    {
        private static Random  rand = new Random();

        public static  double    devolverRandom(double  media)
        {


            double  numero = Math.Log(rand.NextDouble());
            

            numero = -(media * numero) ;

            return  (numero);
            
        }
        
    }
}
