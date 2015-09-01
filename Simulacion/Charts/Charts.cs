using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulacion
{
    public partial class Charts : Form
    {
        private List<double> _xData = new List<double>();
        private List<double> _yData = new List<double>();


        public List<double> xData { get { return _xData; } set { _xData = value; } }
        public List<double> yData { get { return _yData; } set { _yData = value; } }

        public Charts()
        {
            InitializeComponent();

        }

        public  void cargarFormulario()
        {
            

          
            //Vertical bar chart
            //create another area and add it to the chart
            ChartArea area1 = new ChartArea("Area1");
            chart1.ChartAreas.Add(area1);
            //Create the series using just the y data
            Series barSeries = new Series();
            barSeries.Points.DataBindXY(xData, yData);
            
            //Set the chart type, column; vertical bars
            barSeries.ChartType = SeriesChartType.Column ;
            barSeries.ChartArea = "Area1";
            //Add the series to the chart
            chart1.Series.Add(barSeries);
            chart1.ChartAreas["Area1"].AxisX.MajorGrid.Enabled = true ;
            chart1.ChartAreas["Area1"].AxisY.MajorGrid.Enabled = true ;
        }
    }
}
