using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq ;

namespace Simulacion
{
    public partial class Form1 : Form
    {

        Entidades.Sistema s = new Entidades.Sistema();
        BindingSource oBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnReiniciar.PerformClick();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            s = new Entidades.Sistema();
            s.principal();
            oBinding.DataSource = s.tablaDeReporte;
            this.dataGridView1.DataSource = oBinding.DataSource ;
            this.updateLabels();
            s = null;
        }

        private void updateLabels()
        {
            this.lblTamañoPromedioCola.Text=  (s.Cola.AreaEnCola / s.reloj).ToString("G3");
            this.lblUtilizacionServidor.Text = (s.Servidor.AreaStatusServidor / s.reloj).ToString("G3");
            lblDemoraPromedio.Text = (s.acumuladorDemoras / s.clientesAtendidosEnSistema.Count()).ToString("G3");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            s = null;
            oBinding = null;
            this.dataGridView1.DataSource = null;
        }

        private void relojVsClientesEnCloaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartClientesVsReloj();
        }

        private void chartClientesVsReloj()
        {
            Charts frmCharts = new Charts();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                frmCharts.xData.Add(Convert.ToDouble(row.Cells["colReloj"].Value));
                frmCharts.yData.Add(Convert.ToDouble(row.Cells["colClientesEnCola"].Value));
            }
            frmCharts.cargarFormulario();
            frmCharts.Show();

        }

        private void relojVsDemorasDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Charts frmCharts = new Charts();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                frmCharts.xData.Add(Convert.ToDouble(row.Cells["colReloj"].Value));
                frmCharts.yData.Add(Convert.ToDouble(row.Cells["colAcumuladorDemoras"].Value));


            }
            frmCharts.cargarFormulario();
            frmCharts.Show();

        }

     


    }
}
