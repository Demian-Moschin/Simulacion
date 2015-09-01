using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq ;

namespace Entidades
{
    public class Sistema
    {

        DataTable tableSimulacion;
        
        public DataTable tablaDeReporte { get { return tableSimulacion; } }
        public DataTable tablaClientesAtendidos{ get { return tableSimulacion; } }

        private double _reloj;
        public double reloj {get{return  _reloj;}}

        private double _TUE;
        public double TUE { get {return  _TUE; } set { _TUE = value; } }

        private Eventos.CatalogoDeEventos catEventos; 
        Cola cola;
        Servidor servidor;
        double _acumuladorDemoras;
        public double acumuladorDemoras { get { return Math.Round(_acumuladorDemoras, 3); } set { _acumuladorDemoras = value; } }

        private Evento eventoActual;
        private Cliente cliente= new Cliente();
        private List<Cliente> _clientesAtendidosEnSistema = new List<Cliente>();

        #region Propiedades
        public Cola Cola { get { return cola; } set { cola = value; } }
        public Servidor Servidor { get { return servidor; } set { servidor = value; } }
        public List<Cliente> clientesAtendidosEnSistema { get { return _clientesAtendidosEnSistema; } set { _clientesAtendidosEnSistema = value; } }
        #endregion


        #region Constructores
        public Sistema() 
        {
           this.catEventos = new Eventos.CatalogoDeEventos();

           tableSimulacion = new DataTable();
      


            DataColumn column;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "colReloj";
            column.ReadOnly = true;
            
            // Add the Column to the DataColumnCollection.
            tableSimulacion.Columns.Add(column);


            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "colTUE";
            column.ReadOnly = true;
           
            // Add the Column to the DataColumnCollection.
            tableSimulacion.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "colClientesEnCola";
            column.ReadOnly = true;
           
            // Add the Column to the DataColumnCollection.
            tableSimulacion.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "colTIOS";
            column.ReadOnly = true;
           
            // Add the Column to the DataColumnCollection.
            tableSimulacion.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "colAcumuladorDemoras";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.
            tableSimulacion.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "colClientesAtendidos";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.
            tableSimulacion.Columns.Add(column);
           
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "colTipoEvento";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.
            tableSimulacion.Columns.Add(column);

        }

        #endregion


        #region Metodos
        public void  principal()
        {

            inicializarSimulacion();

            while(this.clientesAtendidosEnSistema.Count   <  1000 )
            {
              
                ejecutarRutinaTiming();

                string eventoEnReporte = eventoActual.GetType().Name ;
                if (eventoActual is Arribo)
                { 
                    rutinaArribo(); 
                    
                }
                else
                { 
                    rutinaPartida();
                }

                //como cambia el TUE, gracias a la ejectutarRutinaTIming, 
                //informamos el valor de las variables de estado.(Antes de que este cambie)
                reportes(eventoEnReporte);
                //Luego de reportado, asignamos el nuevo TUE
                TUE = reloj; 
            }

           

        }

       
        private void rutinaPartida()
        {
            if (this.Cola.esVacia())
            {
                //sacamos al cliente del servidor,
                cliente = Servidor.ClienteEnServicio;
                //calculamos estadisticos, y borramos al cliente del servidor
                Servidor.producirPartida(reloj);
                //asigno el evento partida al cliente que sale del servidor. 
                cliente.partida = (Partida)eventoActual;
                //y finalmente, agregramos el cliente a nuestar lista final de clientes atendidos en sistema.
                this.clientesAtendidosEnSistema.Add(cliente );

                //vaciamos variables 
                cliente = null;
                eventoActual = null;

                //producimos partida tiempo de servicio infinito
                Partida partida = new Partida(reloj);
                partida.SetTiempoServicioInfinito();
                //agregamos la partida a nuestra lista de eventos
                this.catEventos.guardarEvento(partida);

            }
            else 
            {
                //primero sacamos al cliente del servidor.
                cliente = Servidor.ClienteEnServicio;
                //asigno el evento partida al cliente que sale del servidor. 
                cliente.partida = (Partida)eventoActual;
                //y finalmente, agregramos el cliente a nuestar lista final de clientes atendidos en sistema.
                this.clientesAtendidosEnSistema.Add(cliente);
                //vaciamos variables 
                cliente = null;
                eventoActual = null;

                /*ahora nos encargamos del cliente que sale de la cola e ingresa al servidor*/

                //calculamos el area de la cola antes de que se retire el cliente
                Cola.calcularArea(reloj, TUE);
                //sacamos al cliente de la cola
                this.cliente =  Cola.ProducirPartida();
                //calculamos el tiempo que estuvo el cliente esperando a ser atendido por el servidor.
                acumuladorDemoras = acumuladorDemoras + (reloj - cliente.TiempoArriboServidorOcupado);
                //entregamos el cliente que salio de la cola , al servidor
                this.Servidor.servirCliente(cliente);

                //generamos una partida para el cliente que entra al servidor, guardandola en lev
                Partida partida = new Partida(reloj);
                this.catEventos.guardarEvento(partida);


                
            }//fin si

           
 
        }//Fin rutina partida
        private void rutinaArribo()
        {
            //checkeamos que el servidor este desocupado.

            cliente = new Cliente();
            cliente.arribo = (Arribo)this.eventoActual;

            if(this.Servidor.estaOcupado() )
            {
                //al estar ocupado el servidor, se agrega el cliente a la cola.
                //establecemos el TA, para luego saber cuanto tarda el cliente en llegar+ser atendido
                this.cliente.setTiempoArriboPorServidorOcupado(reloj);
                Cola.calcularArea(reloj,TUE );
                Cola.AgregarCliente(cliente);
                cliente = null;

            }
            else 
                /*el servidor desocupado implica un retraso de cero para el cliente.*/
                /*ahora  incrementamos el nro de clientes retrazados, y hacemos el server ocupado*/
            {
                servidor.TiempoInicioOcupacionServidor = reloj;
                Servidor.servirCliente(cliente);
                cliente = null;
                
              //ahora creamos evento partida, con un tiempode servicio.
              //el constructor ya setea el tiempo de servicio
              Partida partida = new Partida(reloj );
              this.catEventos.guardarEvento(partida);
            }
         

            //generamos un nuevo arribo
            //el constructor ya setea el tiempo de arribo
            Arribo proximoArribo = new Arribo(reloj);
            this.catEventos.guardarEvento(proximoArribo);
           

            
        }
        private void inicializarSimulacion()
        {
            /*RELOJ DE LA SIMULACION*/
            _reloj = 0.0;

            /*VARIABLES DE ESTADO*/
            this.Servidor = new Servidor();
            this.Cola = new Cola();
            TUE = 0.0;
            this.clientesAtendidosEnSistema.Clear();
            this.catEventos.LEV.Clear();


            /*CONTADORES ESTADISTICOS*/
            this.acumuladorDemoras = 0;
            


            /*Generamos tiempo de arribo, y luego lo guardamos en la LEV*/
            Arribo  arribo = new Arribo(reloj);
            this.catEventos.LEV.Add(arribo);

            Partida partida = new Partida(reloj);
            partida.SetTiempoServicioInfinito();
            catEventos.LEV.Add(partida);

           
            



        }
        private void ejecutarRutinaTiming()
        {
            var sel =
                from n in catEventos.LEV
                orderby n.DevolverTiempoEvento ascending 
                select n  ;
            eventoActual  =  sel.First();
            catEventos.LEV.Remove(eventoActual );

          

           

            _reloj = eventoActual.DevolverTiempoEvento;

           
           
            
        }
        private  void  reportes(string tipoEvento)
        {
            try{
                DataRow dr = tableSimulacion.NewRow();
                dr["colReloj"] = this.reloj.ToString("####.000");
                dr["colTUE"] = this.TUE.ToString("####.000");
                dr["colClientesEnCola"] = this.cola.NroClientesEnCola().ToString("####.0000");
                dr["colTIOS"] = this.Servidor.TiempoInicioOcupacionServidor.ToString("####.0000");
                dr["colAcumuladorDemoras"] =  this.acumuladorDemoras.ToString("####.0000");
                dr["colClientesAtendidos"] = this.Servidor.ClientesAtendidos.ToString("####.0000");

                dr["colTipoEvento"] = tipoEvento;
               
               
                tableSimulacion.Rows.Add(dr);
            }
            catch (Exception ex) 
            { 
                throw  ex;
            }
        }

     
        #endregion

    }
}
