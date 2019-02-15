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
using System.Windows.Forms.DataVisualization.Charting;

namespace Service_plan_form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        List<Demand_blueprint> dm = new List<Demand_blueprint>();

        private void Form1_Load(object sender, EventArgs e)
        {
            var filePath = @"C:\Users\ATCHAPCYP\Downloads\demand_format\demand_format\demandTFtestXLSX_new.xlsx";
            //OpenFile();
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();                  
                                 
                    DataNamesMapper<Demand_blueprint> mapper = new DataNamesMapper<Demand_blueprint>();
                    dm = mapper.Map(result.Tables[0]).ToList();
                    dm.AddRange(mapper.Map(result.Tables[1]));
                    dm.AddRange(mapper.Map(result.Tables[2]));
                    dm.AddRange(mapper.Map(result.Tables[3]));
                    dm.AddRange(mapper.Map(result.Tables[4]));
                    List<Station> stations = new List<Station>();
                    for (int i = 0; i < 5; i++)
                    {
                        stations.Add(new Station(dm, i, 5));                       
                    }

                    Console.WriteLine(stations[4].station_name);
                   
                    //foreach (var demand in dm)
                    //{
                    //  Console.WriteLine("START : " + demand.StartTime + ", STOP: " + demand.EndTime+ ", ST1: " + demand.Station1 + ", ST2: " + demand.Station2 + ", ST3: " + demand.Station3+", ST4: " + demand.Station4 + ", ST5: " + demand.Station5);
                    //}

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            fillChart();
        }
        private void fillChart()
        {
            Station1.Series["Station1"].Points.AddXY("ST2", 30);
            Station1.Series["Station1"].Points.AddXY("ST3", 30);
            Station1.Series["Station1"].Points.AddXY("ST4", 30);
            Station1.Series["Station1"].Points.AddXY("ST5", 30);
            Station1.Titles.Add("STATION 1 to ALL");
           
        }

    }
}
