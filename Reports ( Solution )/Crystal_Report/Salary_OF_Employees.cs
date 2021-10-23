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
    public partial class Salary_OF_Employees : Form
    {
        DataSet1TableAdapters.EmployeeTableAdapter EmpAdapter;
        public Salary_OF_Employees()
        {
            InitializeComponent();
            EmpAdapter = new DataSet1TableAdapters.EmployeeTableAdapter();
            EmpAdapter.Fill(dataSet11.Employee);
            this.CrystalReport21.SetDataSource(dataSet11);
            this.crystalReportViewer1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
