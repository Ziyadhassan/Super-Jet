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
    public partial class Finanicial : Form
    {
        DataSet1TableAdapters.AD_ContractTableAdapter ADAdapter;
        DataSet1TableAdapters.Rent_ContractTableAdapter RN_Adapter;
        DataSet1TableAdapters.EmployeeTableAdapter Emp_Adapter;
        DataSet1TableAdapters.BusDriverTableAdapter Bus_Adapter;
        public Finanicial()
        {
            InitializeComponent();
            ADAdapter=new DataSet1TableAdapters.AD_ContractTableAdapter ();
            RN_Adapter= new DataSet1TableAdapters.Rent_ContractTableAdapter ();
            Emp_Adapter=new DataSet1TableAdapters.EmployeeTableAdapter ();
            Bus_Adapter=new DataSet1TableAdapters.BusDriverTableAdapter ();
            ADAdapter.Fill(dataSet11.AD_Contract);
            RN_Adapter.Fill(dataSet11.Rent_Contract);
            Emp_Adapter.Fill(dataSet11.Employee);
            Bus_Adapter.Fill(dataSet11.BusDriver);
            this.CrystalReport41.SetDataSource(dataSet11);
            this.crystalReportViewer1.Refresh();
        }

        private void Finanicial_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            ADAdapter.FillBy(dataSet11.AD_Contract, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            RN_Adapter.FillBy(dataSet11.Rent_Contract, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

            this.crystalReportViewer1.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
