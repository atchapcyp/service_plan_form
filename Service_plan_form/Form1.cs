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
using Excel = Microsoft.Office.Interop.Excel;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace Service_plan_form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
        }
            
        List<Service_summary>  selected_services = new List<Service_summary>();
        List<Demand_blueprint> dm = new List<Demand_blueprint>();
        DataNamesMapper<Demand_blueprint> mapper = new DataNamesMapper<Demand_blueprint>();
        public static List<Station> stations = new List<Station>();
        List<Service> service_list = new List<Service>();
        DataSet result;
        static DataSet Test_result;
        public static DataTable dt = new DataTable();
        static string project_path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string xlsx_path = @"demand_format\demandTFtestXLSX_new.xlsx";
      //  string xlsx_path = @"demand_format\demand_waiting_time.xlsx";
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
                    
                    foreach (var demand in dm)
                    {
                        
                      Console.WriteLine("START : " + demand.StartTime + ", STOP: " + demand.EndTime.ToShortTimeString()+ ", ST1: " + demand.Station1 + ", ST2: " + demand.Station2 + ", ST3: " + demand.Station3+", ST4: " + demand.Station4 + ", ST5: " + demand.Station5);
                    }

               
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
                if (dgvService.Rows.Count==counter)
                {
                    break;
                }
                temp_service = new Service(row.Cells[0].Value.ToString(), getStopStation(counter), dep_hour, dep_min);
                services.Add(temp_service);
                counter++;
            }
            service_list = services;
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
            foreach (DataGridViewRow dgvr in Selected_service_dgv.Rows)//dgv is datagridview
            {
                var carry = ConvertToDouble(dgvr.Cells[2].Value.ToString());
                
                if (carry>0)
                {
                    dgvr.DefaultCellStyle.BackColor = Color.FromArgb(222, 251, 184);
                }
                else
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Firebrick;
                    dgvr.DefaultCellStyle.ForeColor= Color.Beige;
                }
                
            }

            richTextBox1.Text = ""; //reset
            var average_wait = 0.0;
            foreach (Station station in stations)
            {
                Console.WriteLine("Station : " + station.station_name);
                Console.WriteLine("sum_passenger : " + station.sum_passenger);
                Console.WriteLine("sum_waiting time : " + station.sum_waiting_time);
                Console.WriteLine("_____________________________________________________________ ");
                
                    average_wait += Math.Round((station.sum_waiting_time / 400000 * 60), 2);
                
            }
                richTextBox1.Text += "Average Ppan waiting time  : " + average_wait/stations.Count + " miniutes\n\n";
            
            // get sum profit
            var sum_profit_all_selected = 0.0;

            foreach(Service_summary _sum in selected_services)
            {
                sum_profit_all_selected += _sum.Profitability;
            }
            richTextBox1.Text += "Profitablie of Plan : " + sum_profit_all_selected+"\n\n";

            var sum_utilize = 0.0;
            var max_util=0.0;
            var min_util = 100.0;
            foreach (Service_summary _sum in selected_services)
            {
                sum_utilize += _sum.Utilization_percent;
                if (_sum.Utilization_percent >= max_util)
                {
                    max_util = _sum.Utilization_percent;
                }

                if (_sum.Utilization_percent <= min_util)
                {
                    min_util = _sum.Utilization_percent;
                }

            }
            var average_utilize = sum_utilize / selected_services.Count;
            richTextBox1.Text += "Avarage Utilization of Plan : " + Math.Round(Convert.ToDecimal(average_utilize), 2)+" \n\n";
            richTextBox1.Text += "MAX Utilization of Plan : " + Math.Round(Convert.ToDecimal(max_util), 2) + " \n\n";
            richTextBox1.Text += "MIN Utilization of Plan : " + Math.Round(Convert.ToDecimal(min_util), 2) + " \n\n";

            Console.WriteLine("DGV DONE "+bs.Count);
        }
        public static double ConvertToDouble(string Value) {
            if (Value == null) {
                return 0;
            }
            else {
                double OutVal;
                double.TryParse(Value, out OutVal);

                if (double.IsNaN(OutVal) || double.IsInfinity(OutVal)) {
                    return 0;
                }
                return OutVal;
            }
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
            //private void routeManagmentToolStripMenuItem_Click(object sender, EventArgs e)
            //{
            //    Route_management route_form = new Route_management();
            //    route_form.Show();
            //}
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

                            _chart.Series.Add("Demand");
                            _chart.Series[0].ChartType = SeriesChartType.SplineArea;
                            _chart.Series.Add("Over-Demand Service");
                            _chart.Series[1].ChartType = SeriesChartType.SplineArea;
                            _chart.Series.Add("Served Demand");
                            for (int i = 0; i < stations[_o].tf_count; i++)
                            {
                                _chart.Series[0].Points.AddXY(stations[_o].start_time[i], stations[_o].demand_station[i][_d]);
                                _chart.Series[1].Points.AddXY(stations[_o].start_time[i], stations[_o].served_demand[i][_d]);
                            }
                            //Console.WriteLine("_________________________________________deMdn count " + stations[_o].demand_station[i][_d])


                            _chart.Titles.Add("From " + stations[_o].station_name + " to " + stations[_d].station_name);
                            _chart.Titles[0].ForeColor = Color.White;
                            //   _chart.Titles[0].Text = planning_sch[_o].station_name + " -> " + planning_sch[_d].station_name;
                            _chart.Titles[0].Alignment = ContentAlignment.TopLeft;
                            _chart.Legends.Add("legend");
                            _chart.Legends[0].BackColor = SystemColors.WindowFrame;
                            _chart.Legends[0].ForeColor = Color.White;
                            _chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                            _chart.Series[1].Color = Color.FromArgb(120,74, 136, 255);
                            _chart.Series[0].Color = Color.FromArgb(200,255, 103, 103  );
                            _chart.Series[2].Color = Color.FromArgb(153, 119, 175);
                            

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
                            _chart.Series.Add("Over-Demand Service");
                            _chart.Series[1].ChartType = SeriesChartType.Column;

                            for (int i = 0; i < stations[_o].tf_count; i++)
                            {
                                _chart.Series[0].Points.AddXY(stations[_o].start_time[i], stations[_o].demand_station[i][_d]);
                                _chart.Series[1].Points.AddXY(stations[_o].start_time[i], stations[_o].served_demand[i][_d]);
                                _chart.Series[0].Points[i].Color = Color.Orange;
                            }

                            _chart.Titles.Add("Demand From " + stations[_o].station_name + " to " + stations[_d].station_name);
                            _chart.Titles[0].ForeColor = Color.White;
                            //   _chart.Titles[0].Text = planning_sch[_o].station_name + " -> " + planning_sch[_d].station_name;
                            _chart.Titles[0].Alignment = ContentAlignment.TopCenter;
                            _chart.Legends.Add("legend");
                            _chart.Legends[0].BackColor = SystemColors.WindowFrame;
                            _chart.Legends[0].ForeColor = Color.AliceBlue;
                            _chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                            _chart.Series[0].IsValueShownAsLabel = true;
                            _chart.Series[1].IsValueShownAsLabel = true;
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
                            for (int timeframe = 0; timeframe < stations[_o].tf_count; timeframe++)
                            {
                                
                                Chart _chart = new Chart();

                                output_panel_graph.Controls.Add(_chart);
                                if (timeframe % 2 == 0)
                                {
                                    _chart.Location = new Point(3, 10 + 160 * chart_cnt);
                                    chart_cnt++;
                                }
                                else
                                {
                                    _chart.Location = new Point(_x_size / 2, 10 + 160 * (chart_cnt-1));
                                }
                                
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
                                    if (stations[_o].station_name == stations[i].station_name)
                                    {
                                        continue;
                                    }
                                    _chart.Series[0].Points.AddXY(stations[i].station_name, stations[_o].demand_station[timeframe][i]);
                                    _chart.Series[0].IsValueShownAsLabel = true;
                                    _chart.Series[1].Points.AddXY(stations[i].station_name, stations[_o].served_demand[timeframe][i]);
                                    _chart.Series[1].IsValueShownAsLabel = true;
                                    _chart.Series[0].LabelForeColor = Color.White;
                                    _chart.Series[1].LabelForeColor = Color.White;
                                }
                              
                           _chart.Titles.Add(" Time " + stations[_o].start_time[timeframe].ToShortTimeString()+" - " + stations[_o].stop_time[timeframe].ToShortTimeString()+" demand from "+ stations[_o].station_name +" to");
                         
                                _chart.Titles[0].ForeColor = Color.White;

                                //_chart.Titles[0].Alignment = ContentAlignment.TopLeft;
                                _chart.Legends.Add("legend");
                                _chart.Legends[0].BackColor = SystemColors.WindowFrame;
                                _chart.Legends[0].ForeColor = Color.White;
                                _chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

                               
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
                if (checkedListBox_station.Items.Count != headerLabels.Length - 2 )
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

        private void save_service_Click(object sender, EventArgs e)
        {   
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLS files (*.xls)|*.xls|XLSX files (*.xlsx)|*.xlsx|CSV (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Services");

                // From DataGridView to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(worksheet, this.dgvService, new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
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

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {

            }
            else
            {
                Console.WriteLine(selected_services[e.RowIndex].Income);
                service_name.Text = selected_services[e.RowIndex].Service_name;
                service_name.Visible = true;
                stop_station.Text = Service_algo.PrettyPrintArraysFormat(selected_services[e.RowIndex].StopStation);
                stop_station.Visible = true;
                departure_time.Text = selected_services[e.RowIndex].Departure_time[selected_services[e.RowIndex].indexOfFirstStation()].ToShortTimeString();
                departure_time.Visible = true;
                served_demand.Text = Service_algo.showarray_toStr(selected_services[e.RowIndex].Actual_serve_income);
                served_demand.Visible = true;
                income.Text = selected_services[e.RowIndex].Income.ToString();
                income.Visible = true;
                utilization_percent.Text = selected_services[e.RowIndex].Utilization_percent.ToString();
                utilization_percent.Visible = true;
                profit.Text = selected_services[e.RowIndex].Profitability.ToString();
                profit.Visible = true;
                operation_cost.Text=((double) (selected_services[e.RowIndex].operation_cost)).ToString();
                operation_cost.Visible = true;
                
                panel_summary.Refresh();
            }
        }

        private void Selected_service_dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            Console.WriteLine(e.RowIndex+"_"+e.ColumnIndex);

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {

            }
            else
            {
                Console.WriteLine(selected_services[e.RowIndex].Income);
                service_name.Text = selected_services[e.RowIndex].Service_name;
                service_name.Visible = true;
                stop_station.Text = Service_algo.PrettyPrintArraysFormat(selected_services[e.RowIndex].StopStation);
                stop_station.Visible = true;
                departure_time.Text = selected_services[e.RowIndex].Departure_time[selected_services[e.RowIndex].indexOfFirstStation()].ToShortTimeString();
                departure_time.Visible = true;
                served_demand.Text = Service_algo.showarray_toStr(selected_services[e.RowIndex].Actual_serve_income);
                served_demand.Visible = true;
                income.Text = selected_services[e.RowIndex].Income.ToString();
                income.Visible = true;
                utilization_percent.Text = selected_services[e.RowIndex].Utilization_percent.ToString();
                utilization_percent.Visible = true;
                profit.Text = selected_services[e.RowIndex].Profitability.ToString();
                profit.Visible = true;
                operation_cost.Text = ((double)(selected_services[e.RowIndex].operation_cost)).ToString();
              
                operation_cost.Visible = true;
                panel_summary.Refresh();
            }
        }

        private void dgvService_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            add_service.Enabled = true;
            calculate_console.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Selected_service_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void serviceTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void served_demand_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            var workbook = new ExcelFile();
            ExcelWorksheet service_freq = workbook.Worksheets.Add("Result");
            ExcelWorksheet worksheet2 = workbook.Worksheets.Add("Service");
            int[,] service_freq_carry = new int[service_list.Count, stations[0].start_time.Count];
            int[,] stopStation_toXlsx = new int[service_list.Count, service_list[0].StopStation.Length];
            
            for (int i = 0; i < service_list.Count; i++)
            {
                for (int j = 0; j < service_list[0].StopStation.Length; j++)
                {
                    stopStation_toXlsx[i,j]= service_list[i].StopStation[j];
                }
            }
            
            
           int[,] result = new int[,] { { 5, 5, 5, 5, 5 }, { 5, 5, 5, 5, 5 }, { 5, 5, 5, 5, 5 }, { 5, 5, 5, 5, 5 }, { 5, 5, 5, 5, 5 }, { 5, 5, 5, 5, 5 } };

            
            service_freq.Cells["A1"].Value = "Example of writing typical table - tallest buildings in the world (2019):";

            // Column width of 8, 30, 16, 20, 9, 11, 9, 9, 4 and 5 characters.
            service_freq.Columns["A"].SetWidth(8, LengthUnit.ZeroCharacterWidth); // Rank
            service_freq.Columns["B"].SetWidth(8, LengthUnit.ZeroCharacterWidth); // Building
            service_freq.Columns["C"].SetWidth(8, LengthUnit.ZeroCharacterWidth); // City
            service_freq.Columns["D"].SetWidth(8, LengthUnit.ZeroCharacterWidth); // Country
            service_freq.Columns["E"].SetWidth(8, LengthUnit.ZeroCharacterWidth); // Metric
            service_freq.Columns["F"].SetWidth(8, LengthUnit.ZeroCharacterWidth); // Imperial
            service_freq.Columns["G"].SetWidth(8, LengthUnit.ZeroCharacterWidth); // Floors
            service_freq.Columns["H"].SetWidth(8, LengthUnit.ZeroCharacterWidth); // Built (Year)
            service_freq.Columns["I"].SetWidth(8, LengthUnit.ZeroCharacterWidth);
            service_freq.Columns["J"].SetWidth(8, LengthUnit.ZeroCharacterWidth);


            // Write header data to Excel cells.
            foreach (DataGridViewRow dgvr in Selected_service_dgv.Rows)//dgv is datagridview
            {
                var carry = ConvertToDouble(dgvr.Cells[2].Value.ToString());

                var i=getIndexOfServiceList(dgvr.Cells[1].Value.ToString());
                //Console.WriteLine("_____SERVICE DGV____"+dgvr.Cells[1].Value.ToString()+"_ "+i);
                var j = getIndexBy_time(selected_services[dgvr.Index].Departure_time[selected_services[dgvr.Index].indexOfFirstStation()]);
                // Console.WriteLine("_____SERVICE TIME____"+ selected_services[dgvr.Index].Departure_time[selected_services[dgvr.Index].indexOfFirstStation()].ToShortTimeString()+"___"+j);
                service_freq_carry[i,j] += 1;
            }

            for(int i =0; i< service_list.Count; i++)
            {
                for(int j=0;j< stations[0].start_time.Count; j++)
                {
                    service_freq.Cells[i, j].Value = service_freq_carry[i, j];
                }
            }
            for(int i = 0; i < stations[0].start_time.Count; i++)
            {
                service_freq.Cells[service_list.Count, i].Value = i + stations[0].start_time[0].Hour;
            }

            for (int i = 0; i < service_list.Count; i++) // to be fix later
            {
                
                for (int j = 0; j < service_list[0].StopStation.Length; j++)
                {
                    worksheet2.Cells[i, j].Value = stopStation_toXlsx[i, j];
                }
                    
            }



            var style = new CellStyle();
            style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            style.VerticalAlignment = VerticalAlignmentStyle.Center;
            style.FillPattern.SetSolid(Color.Chocolate);
            style.Font.Weight = ExcelFont.BoldWeight;
            style.Font.Color = Color.White;
            style.WrapText = true;
            style.Borders.SetBorders(MultipleBorders.Right | MultipleBorders.Top, Color.Black, LineStyle.Thin);


            // Write and format sample data to Excel cells.

            

            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|xlsx files (*.xlsx)|*.xlsx|csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = ".xlsx";
            saveFileDialog1.FilterIndex = 3;
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Browse Text Files";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                workbook.Save(saveFileDialog1.FileName);
            }
        }

        public int getIndexBy_time(DateTime service_time)
        {
           foreach((DateTime station_time,int index) in stations[0].start_time.Select((station_time, index) => ( station_time, index )))
            {
                if (station_time.Hour == service_time.Hour)
                {
                    return index;
                }
            }

            return -1;
        }

        public int getIndexOfServiceList(string service_name)
        {
            int index = 0;
            foreach (Service _service in service_list)
            {
                if (_service.ServiceId == service_name)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            {
                Config_form config_form = new Config_form();
                config_form.Show();
            }
        }
    }
}
