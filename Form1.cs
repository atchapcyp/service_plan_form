using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_plan_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFile();
        }

        public void OpenFile()
        {
            Excel excel = new Excel(@"C:\Users\ATCHAPCYP\Downloads\demand_format\demand_format\demandTFtestXLSX.xlsx", 1);
            MessageBox.Show(excel.ReadCell(0, 1));
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
