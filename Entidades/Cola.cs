using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cola
    {
    
        private Queue<Cliente> clientes;
     
        public Queue<Cliente> ClientesEnCola { get { return clientes; } set { clientes = value; } }

        private double area_in_queue;
        public double AreaEnCola { get { return area_in_queue; } set { area_in_queue = value; } }


        public Cola() 
        {
            /*arrancamos en cero clientes en cola*/
            ClientesEnCola = new Queue<Cliente>();
            ClientesEnCola.Clear();
          
            /*control estadistico*/
            AreaEnCola = 0.0;
        }


        public int NroClientesEnCola()
        { return ClientesEnCola.Count; }




        internal void UpdateArea(double tue)
        {
            AreaEnCola += this.ClientesEnCola.Count  * tue;

        }

     

        public  Cliente  ProducirPartida()
        {
            return this.ClientesEnCola.Dequeue();
        }
        public void AgregarCliente(Cliente cli )
        {
           
            //agregamos cliente a cola
            ClientesEnCola.Enqueue(cli);
           
        }
        public bool esVacia() { if (this.ClientesEnCola.Count < 1) { return true; } else { return false; } }

        public  void calcularArea(double rel, double tue)
        {
            this.AreaEnCola= AreaEnCola + (rel-tue) * this.ClientesEnCola.Count ;
        }
    }
}
