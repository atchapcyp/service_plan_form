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
        DataNamesMapper<Demand_blueprint> mapper = new DataNamesMapper<Demand_blueprint>();
        List<Station> stations = new List<Station>();
        DataSet result;
        private void Form1_Load(object sender, EventArgs e)
        {
            var filePath = @"C:\Users\ATCHAPCYP\Downloads\demand_format\demand_format\demandTFtestXLSX_new.xlsx";
           
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    result = reader.AsDataSet();
                    for (int i = 0; i < result.Tables.Count; i++) {
                        dm.AddRange(mapper.Map(result.Tables[i]));
                        
                    }
                    
                    for (int i = 0; i < result.Tables.Count; i++)
                    { 
                        stations.Add(new Station(dm, i, result.Tables.Count));
                    }
                    Console.WriteLine(stations[4].station_name);
                    Console.WriteLine(stations[4].demand_station[0][0]);
                    foreach (var demand in dm)
                    {
                      Console.WriteLine("START : " + demand.StartTime.ToShortTimeString() + ", STOP: " + demand.EndTime.ToShortTimeString()+ ", ST1: " + demand.Station1 + ", ST2: " + demand.Station2 + ", ST3: " + demand.Station3+", ST4: " + demand.Station4 + ", ST5: " + demand.Station5);
                    }

                    // The result of each spreadsheet is in result.Tables
                } 
            }
            // for (int i=0; i < 50; i++)
            //  {
            //    CheckBox chb = new CheckBox();
            //    chb.Text = i.ToString();
            //    chb.Location = new Point(10, panel3.Controls.Count * 20);
            //    panel3.Controls.Add(chb);
            //  }
            
            from_demand_box.Items.Add("ALL station");
            to_demand_box.Items.Add("ALL station");
           
            foreach (Station _S in stations)
            {
                from_demand_box.Items.Add(_S.station_name);
                to_demand_box.Items.Add(_S.station_name);
               
            }
            from_demand_box.SelectedIndex = 0;
            to_demand_box.SelectedIndex = 0;
            

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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (from_demand_box.SelectedIndex < 0 || to_demand_box.SelectedIndex < 0)
            {
                MessageBox.Show("please select station");
                return;
            }

            if (from_demand_box.SelectedIndex != 0 && from_demand_box.SelectedIndex == to_demand_box.SelectedIndex)
            {
                MessageBox.Show("invalid station : same station");
                return;
            }


            output_panel_graph.Controls.Clear();
            output_panel_graph.AutoScroll = false;

            List<int> _origin = new List<int>();
            List<int> _destination = new List<int>();

            if (from_demand_box.SelectedIndex == 0)
            {
                _origin = new int[] { 0, 1, 2, 3, 4 }.ToList();
            }
            else
            {
                _origin.Add(from_demand_box.SelectedIndex - 1);
            }
            if (to_demand_box.SelectedIndex == 0)
            {   // add index form station count
                _destination = new int[] { 0, 1, 2, 3, 4 }.ToList();
            }
            else
            {
                _destination.Add(to_demand_box.SelectedIndex - 1);
            }

            int chart_cnt = 0;
            int _x_size = output_panel.Size.Width - 33;

            foreach (int _o in _origin)
            {
                foreach (int _d in _destination)
                {

                    if (_o != _d)
                    {
                        Chart _chart = new Chart();

                        output_panel_graph.Controls.Add(_chart);
                        _chart.Location = new Point(3, 10 + 160 * chart_cnt);
                        _chart.Size = new Size(_x_size, 150);
                        _chart.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                        _chart.BackColor = SystemColors.WindowFrame;
                        _chart.ChartAreas.Add("area");
                        _chart.ChartAreas[0].BackColor = Color.DimGray;
                        _chart.ChartAreas[0].AxisX.LineColor = Color.White;
                        _chart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:00";
                        _chart.ChartAreas[0].AxisX.MajorGrid.LineColor = SystemColors.ControlDark;
                        _chart.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.White;
                        _chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                        _chart.ChartAreas[0].AxisX.Interval = 1;
                        _chart.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                        _chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
                        _chart.ChartAreas[0].AxisY.LineColor = Color.White;
                        _chart.ChartAreas[0].AxisY.MajorGrid.LineColor = SystemColors.ControlDark;
                        _chart.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.White;
                        _chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

                        _chart.Series.Add("demand");
                        _chart.Series[0].ChartType = SeriesChartType.Column;

                        for (int i=0; i<6;i++)
                        {
                            _chart.Series[0].Points.AddXY(stations[_o].start_time[i], stations[_o].demand_station[i][2]);
                        }

                        //_chart.Series.Add("supply");
                        //_chart.Series[1].ChartType = SeriesChartType.BoxPlot;
                       // _chart.Series[1].IsValueShownAsLabel = true;
                       // _chart.Series[1].LabelForeColor = Color.Orange;

                        //foreach (passenger_data _p in passenger_supply[_o, _d])
                       // {
                       //     _chart.Series[1].Points.AddXY(_p.time, _p.count);
                      //  }

                       // _chart.Series.Add("remaining demand");
                       // _chart.Series[2].ChartType = SeriesChartType.SplineArea;

                     //   foreach (passenger_data _p in cal_pass_demand[_o, _d])
                      //  {
                      //      _chart.Series[2].Points.AddXY(_p.time, _p.count);
                      //  }

                        _chart.Titles.Add("name");
                        _chart.Titles[0].ForeColor = Color.White;
                     //   _chart.Titles[0].Text = planning_sch[_o].station_name + " -> " + planning_sch[_d].station_name;
                        _chart.Titles[0].Alignment = ContentAlignment.TopLeft;
                        _chart.Legends.Add("legend");
                        _chart.Legends[0].BackColor = SystemColors.WindowFrame;
                        _chart.Legends[0].ForeColor = Color.White;

                        chart_cnt++;
                    }
                }
            }
                        output_panel_graph.AutoScroll = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
