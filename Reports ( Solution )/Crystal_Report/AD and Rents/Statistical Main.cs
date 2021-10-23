using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurCrystal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AD_btn_Click(object sender, EventArgs e)
        {
            AD aD = new AD();
            aD.Show();
        }

        private void Rent_btn_Click(object sender, EventArgs e)
        {
            Rents rents = new Rents();
            rents.Show();
        }
    }
}
