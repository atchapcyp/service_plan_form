using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Service_plan_form.Demands;
using Service_plan_form.DataSets;
using Service_plan_form.Mapping;

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
            var filePath = @"C:\Users\ATCHAPCYP\Downloads\demand_format\demand_format\demandTFtestXLSX_new.xlsx";
            //OpenFile();
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    
                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    /*do
                    {
                        while (reader.Read())
                        {
                            
                        }
                    } while (reader.NextResult());*/

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                     
                    
                    Console.WriteLine(result.GetXml());

                    DataNamesMapper<Demand> mapper = new DataNamesMapper<Demand>();
                    List<Demand> dm = mapper.Map(result.Tables[0]).ToList();
                    dm.AddRange(mapper.Map(result.Tables[1]));
                    dm.AddRange(mapper.Map(result.Tables[2]));
                   
                    foreach (var demand in dm)
                    {
                        Console.WriteLine("START : " + demand.StartTime + ", STOP: " + demand.EndTime+ ", ST1: " + demand.Station1 + ", ST2: " + demand.Station2 + ", ST3: " + demand.Station3);
                    }
                    Console.WriteLine("DEBUG ... : " + dm[0].Station2);
                    // The result of each spreadsheet is in result.Tables
                } 
            }
        }

        public void OpenFile()
        {
            Excel excel = new Excel(@"C:\Users\ATCHAPCYP\Downloads\demand_format\demand_format\demandTFtestXLSX.xlsx", 1);
            MessageBox.Show(excel.ReadCell(0, 1));
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
