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
using CsvHelper;

namespace Service_plan_form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
            
        List<Service_summary>  selected_services = new List<Service_summary>();
            List<Demand_blueprint> dm = new List<Demand_blueprint>();
        DataNamesMapper<Demand_blueprint> mapper = new DataNamesMapper<Demand_blueprint>();
        public static List<Station> stations = new List<Station>();
        DataSet result;
        static DataSet Test_result;
        public static DataTable dt = new DataTable();
        static string project_path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string xlsx_path = @"demand_format\demandTFtestXLSX_new.xlsx";
       // string xlsx_path = @"demand_format\demand_waiting_time.xlsx";
        static string test_path = @"demand_format\TestData.xlsx";

        private void Form1_Load(object sender, EventArgs e)
        {
            var filePath = Path.Combine(project_path,xlsx_path);
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
                        checkedListBox_station.Items.Add(stations[i].station_name);

                    }
                    Console.WriteLine(stations[2].station_name);
                    Console.WriteLine(stations[2].demand_station[0][0]);
                    foreach (var demand in dm)
                    {
                        
                      Console.WriteLine("START : " + demand.StartTime + ", STOP: " + demand.EndTime.ToShortTimeString()+ ", ST1: " + demand.Station1 + ", ST2: " + demand.Station2 + ", ST3: " + demand.Station3+", ST4: " + demand.Station4 + ", ST5: " + demand.Station5);
                    }

                    // The result of each spreadsheet is in result.Tables
                } 
            }
            
           
            
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

        public void getService_dgv()
        {
            List<Service> services = new List<Service>();
           
            Service temp_service;
            int dep_hour = 8; int dep_min = 0;
            int counter = 0;
            foreach (DataGridViewRow row in dgvService.Rows)
            {
                if (dgvService.Rows.Count-1==counter)
                {
                    break;
                }
                temp_service = new Service(row.Cells[0].Value.ToString(), getStopStation(counter), dep_hour, dep_min);
                services.Add(temp_service);
                counter++;
            }

            var b = 0;
              selected_services.Clear();
             (selected_services,_) = Service_algo.genService(services);

            BindingSource bs = new BindingSource();
            bs.DataSource = typeof(Service_summary);
            for (var index = 0; index < selected_services.Count; index++)
            {
                bs.Add(selected_services[index]);
            }
           // bs.DataSource = typeof(Airplane);  
            
            Selected_service_dgv.DataSource = bs;
            Selected_service_dgv.AutoGenerateColumns = true;

            Console.WriteLine("DGV DONE "+bs.Count);
        }

        int[] getStopStation(int datagridviewRow)
        {
            int[] stop_station = new int[5];
            for (int i = 0,y=2; i < 5; i++,y++)
            {
                stop_station[i]=Int32.Parse(dgvService.Rows[datagridviewRow].Cells[y].Value.ToString());
            }
            return stop_station;
        }

        public static List<Station> readxlsx()
        {   var Test_stations = new List<Station>();
            var Test_dm = new List<Demand_blueprint>();
           var Test_mapper = new DataNamesMapper<Demand_blueprint>();
            var filePath = Path.Combine(project_path, test_path);
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    Test_result = reader.AsDataSet();
                    for (int i = 0; i < Test_result.Tables.Count; i++)
                    {
                        Test_dm.AddRange(Test_mapper.Map(Test_result.Tables[i]));

                    }

                    for (int i = 0; i < Test_result.Tables.Count; i++)
                    {
                        Test_stations.Add(new Station(Test_dm, i, Test_result.Tables.Count));
                    }
                }
            }
            return Test_stations;
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

            if (Spl.Checked)
            {
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
                            _chart.Series[0].ChartType = SeriesChartType.SplineArea;
                            _chart.Series.Add("Serve Demand");
                            _chart.Series[1].ChartType = SeriesChartType.SplineArea;
                            for (int i = 0; i < stations[_o].tf_count - 1; i++)
                            {
                                _chart.Series[0].Points.AddXY(stations[_o].start_time[i], stations[_o].demand_station[i][_d]);
                                _chart.Series[1].Points.AddXY(stations[_o].start_time[i], stations[_o].demand_station[i][_d]/2);
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

                            _chart.Titles.Add("From " + stations[_o].station_name + " to " + stations[_d].station_name);
                            _chart.Titles[0].ForeColor = Color.White;
                            //   _chart.Titles[0].Text = planning_sch[_o].station_name + " -> " + planning_sch[_d].station_name;
                            _chart.Titles[0].Alignment = ContentAlignment.TopLeft;
                            _chart.Legends.Add("legend");
                            _chart.Legends[0].BackColor = SystemColors.WindowFrame;
                            _chart.Legends[0].ForeColor = Color.White;
                            _chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

                            chart_cnt++;
                        }
                    }
                }
            }
            if (barChart.Checked)
            {
                // plot bar chart
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

                            for (int i = 0; i < stations[_o].tf_count - 1; i++)
                            {
                                _chart.Series[0].Points.AddXY(stations[_o].start_time[i], stations[_o].demand_station[i][_d]);
                                _chart.Series[0].Points[i].Color =Color.Orange;
                            } 

                            _chart.Titles.Add("From " + stations[_o].station_name + " to " + stations[_d].station_name);
                            _chart.Titles[0].ForeColor = Color.White;
                            //   _chart.Titles[0].Text = planning_sch[_o].station_name + " -> " + planning_sch[_d].station_name;
                            _chart.Titles[0].Alignment = ContentAlignment.TopLeft;
                            _chart.Legends.Add("legend");
                            _chart.Legends[0].BackColor = SystemColors.WindowFrame;
                            _chart.Legends[0].ForeColor = Color.AliceBlue;
                            _chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

                            _chart.Series[0].Color = Color.Orange;
                            chart_cnt++;
                        }
                    }
                }
            }
            if (stationcheckBox.Checked)
          
                {
                    // plot chart TIME FRAME
                    foreach (int _o in _origin)
                    {
                            for (int timeframe = 0; timeframe < stations[_o].tf_count - 1; timeframe++)
                            {
                                
                                Chart _chart = new Chart();

                                output_panel_graph.Controls.Add(_chart);
                                _chart.Location = new Point(3, 10 + 160 * chart_cnt);
                                _chart.Size = new Size(_x_size / 2, 150);
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
                           
                                _chart.ChartAreas[0].AxisY.LineColor = Color.White;
                                _chart.ChartAreas[0].AxisY.MajorGrid.LineColor = SystemColors.ControlDark;
                                _chart.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.White;
                                _chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                        
                                _chart.Series.Add("demand");
                                _chart.Series[0].ChartType = SeriesChartType.Column;
                                _chart.Series.Add("Served Demand");
                        _chart.Series[1].ChartType = SeriesChartType.Column;
                                for (int i = 0; i < stations.Count; i++)
                                { 
                                    _chart.Series[0].Points.AddXY(stations[i].station_name, stations[_o].demand_station[timeframe][i]);
                                    _chart.Series[0].IsValueShownAsLabel = true;
                                    _chart.Series[1].Points.AddXY(stations[i].station_name, stations[_o].demand_station[timeframe][i]/10);
                                    _chart.Series[1].IsValueShownAsLabel = true;
                        }
                              
                           _chart.Titles.Add(" Time " + stations[_o].start_time[timeframe].ToShortTimeString()+" - " + stations[_o].stop_time[timeframe].ToShortTimeString()+" demand from "+ stations[_o].station_name +" to");
                         
                                _chart.Titles[0].ForeColor = Color.White;

                                //_chart.Titles[0].Alignment = ContentAlignment.TopLeft;
                                _chart.Legends.Add("legend");
                                _chart.Legends[0].BackColor = SystemColors.WindowFrame;
                                _chart.Legends[0].ForeColor = Color.White;
                                _chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

                                chart_cnt++;
                            }
                            
                        
                    }
                }
                        output_panel_graph.AutoScroll = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
         
        }

       /* public DataTable readCSV(string filePath)
        {
            var dt = new DataTable();

            var csv = new CsvReader(new StreamReader(filePath));
            // Creating the columns
            typeof(Service).GetProperties().Select(p => p.Name).ToList().ForEach(x => dt.Columns.Add(x));

            // Adding the rows
            csv.GetRecords<Service>().ToList.ForEach(line => dt.Rows.Add(line.Name, line.Age, line.Birthdate, line.Working));
              
            return dt;
        }*/

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void import_csv_service_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textfilepath.Text = openFileDialog1.FileName;
            BindDataCSV(textfilepath.Text);
            
        }
        private void BindDataCSV(string filePath)
        {
            dgvService.DataSource = null;
            dt.Clear();
            try
            {
                // Read in nonexistent file.
                string[] lines = System.IO.File.ReadAllLines(filePath);
            
            if (lines.Length > 0)
            {
                string firstline = lines[0];
                string[] headerLabels = firstline.Split(',');
                if (checkedListBox_station.Items.Count != headerLabels.Length - 2
                    
                    )
                {
                    MessageBox.Show("Invalid Service format Please re-select service input\n Only "+(headerLabels.Length-2)+" Stations required");
                }
                foreach(string headerWord in headerLabels)
                {
                    if (dt.Columns.Contains(headerWord))
                    {
                        break;
                    }

                    dt.Columns.Add(new DataColumn(headerWord));
                    
                }
                for(int r = 1; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                } 
            }
            if (dt.Rows.Count > 0)
            {   
               // dt.Columns[0].Unique=true;
                dgvService.DataSource = dt;
              
            }
        
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (outbound_checkbox.Checked)
            {
                inbound_checkbox.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (inbound_checkbox.Checked)
            {
                outbound_checkbox.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            DataRow dr = dt.NewRow();
            dr[0] = service_name_textbox.Text;
            if (outbound_checkbox.Checked && !inbound_checkbox.Checked)
            {
                dr[1] = "OUTBOUND";
            }
            else if (!outbound_checkbox.Checked && inbound_checkbox.Checked)
            {
                dr[1] = "INBOUND";
            }

            for (int i = 0; i < dgvService.ColumnCount-2; i++)
            {
                if (checkedListBox_station.GetItemChecked(i))
                {
                    dr[i+2] = 1;
                }
                else
                {
                    dr[i+2] = 0;
                }
  
            }

            dt.Rows.Add(dr);
            
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void calculate_console_Click(object sender, EventArgs e)
        {
            this.getService_dgv();

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dgvService_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine(e.RowIndex+"_"+e.ColumnIndex);
        }

        private void Selected_service_dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine(e.RowIndex+"_"+e.ColumnIndex);
            Console.WriteLine();
        }
    }
}
