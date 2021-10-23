using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_Report
{
    public partial class Trips_Statistics : Form
    {
        DataSet1TableAdapters.BusTripTableAdapter BTAdapter;
        DataSet1TableAdapters.PassengerTripTableAdapter PTAdapter;
        DataSet1TableAdapters.WeeklyTripsTableAdapter WTAdapter;

        public Trips_Statistics()
        {
            InitializeComponent();
            BTAdapter = new DataSet1TableAdapters.BusTripTableAdapter();
            PTAdapter = new DataSet1TableAdapters.PassengerTripTableAdapter();
            WTAdapter = new DataSet1TableAdapters.WeeklyTripsTableAdapter();
            BTAdapter.Fill(dataSet11.BusTrip);
            this.Cry1.SetDataSource(dataSet11);
            this.crystalReportViewer1.Refresh();
            PTAdapter.Fill(dataSet11.PassengerTrip);
            this.Cry1.SetDataSource(dataSet11);
            this.crystalReportViewer1.Refresh();
            WTAdapter.Fill(dataSet11.WeeklyTrips);
            this.Cry1.SetDataSource(dataSet11);
            this.crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BTAdapter.FillBy1(dataSet11.BusTrip, dateTimePicker1.Value.ToString(),dateTimePicker2.Value.ToString());
            this.crystalReportViewer1.RefreshReport();
        }

        private void Trips_Statistics_Load(object sender, EventArgs e)
        {

        }
    }
}
