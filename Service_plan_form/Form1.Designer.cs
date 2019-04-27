namespace Service_plan_form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage Individual;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_summary = new System.Windows.Forms.Panel();
            this.operation_cost = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.Label();
            this.utilization_percent = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.Label();
            this.served_demand = new System.Windows.Forms.Label();
            this.departure_time = new System.Windows.Forms.Label();
            this.stop_station = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.service_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.output_panel = new System.Windows.Forms.Panel();
            this.output_panel_graph = new System.Windows.Forms.Panel();
            this.stationcheckBox = new System.Windows.Forms.CheckBox();
            this.to_demand_box = new MetroFramework.Controls.MetroComboBox();
            this.barChart = new System.Windows.Forms.CheckBox();
            this.Spl = new System.Windows.Forms.CheckBox();
            this.from_demand_box = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.save_service = new System.Windows.Forms.Button();
            this.calculate_console = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkedListBox_station = new System.Windows.Forms.CheckedListBox();
            this.stopstation_label = new System.Windows.Forms.Label();
            this.inbound_checkbox = new System.Windows.Forms.CheckBox();
            this.outbound_checkbox = new System.Windows.Forms.CheckBox();
            this.service_type = new System.Windows.Forms.Label();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.textfilepath = new System.Windows.Forms.TextBox();
            this.import_csv_service = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.service_name_textbox = new System.Windows.Forms.TextBox();
            this.add_service = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_groupbox = new System.Windows.Forms.GroupBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serviceTab = new System.Windows.Forms.TabControl();
            this.service_set = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.save_path = new System.Windows.Forms.TextBox();
            this.export_to_time_table_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.summary_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Selected_service_dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizationpercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.config_btn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.stopStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reload_demand = new System.Windows.Forms.Button();
            Individual = new System.Windows.Forms.TabPage();
            Individual.SuspendLayout();
            this.panel_summary.SuspendLayout();
            this.output_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.input_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.serviceTab.SuspendLayout();
            this.service_set.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_service_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopStationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Individual
            // 
            Individual.AllowDrop = true;
            Individual.BackColor = System.Drawing.Color.Wheat;
            Individual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Individual.Controls.Add(this.panel_summary);
            Individual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            Individual.Location = new System.Drawing.Point(4, 23);
            Individual.Margin = new System.Windows.Forms.Padding(0);
            Individual.Name = "Individual";
            Individual.Size = new System.Drawing.Size(272, 443);
            Individual.TabIndex = 0;
            Individual.Text = "Individual";
            // 
            // panel_summary
            // 
            this.panel_summary.BackColor = System.Drawing.Color.PeachPuff;
            this.panel_summary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_summary.Controls.Add(this.operation_cost);
            this.panel_summary.Controls.Add(this.label12);
            this.panel_summary.Controls.Add(this.profit);
            this.panel_summary.Controls.Add(this.utilization_percent);
            this.panel_summary.Controls.Add(this.income);
            this.panel_summary.Controls.Add(this.served_demand);
            this.panel_summary.Controls.Add(this.departure_time);
            this.panel_summary.Controls.Add(this.stop_station);
            this.panel_summary.Controls.Add(this.label11);
            this.panel_summary.Controls.Add(this.label10);
            this.panel_summary.Controls.Add(this.label9);
            this.panel_summary.Controls.Add(this.label8);
            this.panel_summary.Controls.Add(this.label7);
            this.panel_summary.Controls.Add(this.label6);
            this.panel_summary.Controls.Add(this.label4);
            this.panel_summary.Controls.Add(this.service_name);
            this.panel_summary.Font = new System.Drawing.Font("Varela", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_summary.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel_summary.Location = new System.Drawing.Point(3, 3);
            this.panel_summary.Name = "panel_summary";
            this.panel_summary.Size = new System.Drawing.Size(266, 432);
            this.panel_summary.TabIndex = 3;
            // 
            // operation_cost
            // 
            this.operation_cost.AutoSize = true;
            this.operation_cost.Location = new System.Drawing.Point(127, 327);
            this.operation_cost.Name = "operation_cost";
            this.operation_cost.Size = new System.Drawing.Size(133, 21);
            this.operation_cost.TabIndex = 15;
            this.operation_cost.Text = "Operation_Cost";
            this.operation_cost.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-4, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Operation Cost :";
            // 
            // profit
            // 
            this.profit.AutoSize = true;
            this.profit.Location = new System.Drawing.Point(127, 359);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(53, 21);
            this.profit.TabIndex = 13;
            this.profit.Text = "Profit";
            this.profit.Visible = false;
            // 
            // utilization_percent
            // 
            this.utilization_percent.AutoSize = true;
            this.utilization_percent.Location = new System.Drawing.Point(127, 264);
            this.utilization_percent.Name = "utilization_percent";
            this.utilization_percent.Size = new System.Drawing.Size(158, 21);
            this.utilization_percent.TabIndex = 12;
            this.utilization_percent.Text = "Utilization_Percent";
            this.utilization_percent.Visible = false;
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Location = new System.Drawing.Point(127, 294);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(68, 21);
            this.income.TabIndex = 11;
            this.income.Text = "Income";
            this.income.Visible = false;
            // 
            // served_demand
            // 
            this.served_demand.AutoSize = true;
            this.served_demand.Location = new System.Drawing.Point(19, 148);
            this.served_demand.Name = "served_demand";
            this.served_demand.Size = new System.Drawing.Size(138, 21);
            this.served_demand.TabIndex = 10;
            this.served_demand.Text = "Served_Demand";
            this.served_demand.Visible = false;
            this.served_demand.Click += new System.EventHandler(this.served_demand_Click);
            // 
            // departure_time
            // 
            this.departure_time.AutoSize = true;
            this.departure_time.Location = new System.Drawing.Point(135, 36);
            this.departure_time.Name = "departure_time";
            this.departure_time.Size = new System.Drawing.Size(136, 21);
            this.departure_time.TabIndex = 9;
            this.departure_time.Text = "Departure_Time";
            this.departure_time.Visible = false;
            // 
            // stop_station
            // 
            this.stop_station.AutoSize = true;
            this.stop_station.Location = new System.Drawing.Point(114, 69);
            this.stop_station.Name = "stop_station";
            this.stop_station.Size = new System.Drawing.Size(112, 21);
            this.stop_station.TabIndex = 8;
            this.stop_station.Text = "Stop_Station";
            this.stop_station.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Service Name  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Profit :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Utilize Percent :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Income :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Varela", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 27);
            this.label7.TabIndex = 3;
            this.label7.Text = "Served Demand ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Departure Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "StopStation :";
            // 
            // service_name
            // 
            this.service_name.AutoSize = true;
            this.service_name.Location = new System.Drawing.Point(132, 3);
            this.service_name.Name = "service_name";
            this.service_name.Size = new System.Drawing.Size(122, 21);
            this.service_name.TabIndex = 0;
            this.service_name.Text = "Service_Name";
            this.service_name.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(927, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Demand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 916);
            this.panel1.TabIndex = 1;
            // 
            // output_panel
            // 
            this.output_panel.Controls.Add(this.output_panel_graph);
            this.output_panel.Controls.Add(this.stationcheckBox);
            this.output_panel.Controls.Add(this.to_demand_box);
            this.output_panel.Controls.Add(this.barChart);
            this.output_panel.Controls.Add(this.Spl);
            this.output_panel.Controls.Add(this.from_demand_box);
            this.output_panel.Controls.Add(this.label2);
            this.output_panel.Controls.Add(this.button1);
            this.output_panel.ForeColor = System.Drawing.SystemColors.Info;
            this.output_panel.Location = new System.Drawing.Point(48, 373);
            this.output_panel.Name = "output_panel";
            this.output_panel.Size = new System.Drawing.Size(1301, 541);
            this.output_panel.TabIndex = 2;
            // 
            // output_panel_graph
            // 
            this.output_panel_graph.AutoScroll = true;
            this.output_panel_graph.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_panel_graph.Location = new System.Drawing.Point(14, 71);
            this.output_panel_graph.Name = "output_panel_graph";
            this.output_panel_graph.Size = new System.Drawing.Size(1253, 467);
            this.output_panel_graph.TabIndex = 4;
            this.output_panel_graph.Click += new System.EventHandler(this.button1_Click);
            // 
            // stationcheckBox
            // 
            this.stationcheckBox.AutoSize = true;
            this.stationcheckBox.ForeColor = System.Drawing.SystemColors.Info;
            this.stationcheckBox.Location = new System.Drawing.Point(822, 4);
            this.stationcheckBox.Name = "stationcheckBox";
            this.stationcheckBox.Size = new System.Drawing.Size(85, 20);
            this.stationcheckBox.TabIndex = 7;
            this.stationcheckBox.Text = "Time frame";
            this.stationcheckBox.UseVisualStyleBackColor = true;
            // 
            // to_demand_box
            // 
            this.to_demand_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.to_demand_box.ForeColor = System.Drawing.SystemColors.Info;
            this.to_demand_box.FormattingEnabled = true;
            this.to_demand_box.ItemHeight = 23;
            this.to_demand_box.Location = new System.Drawing.Point(609, 21);
            this.to_demand_box.Name = "to_demand_box";
            this.to_demand_box.Size = new System.Drawing.Size(183, 29);
            this.to_demand_box.TabIndex = 3;
            this.to_demand_box.Theme = MetroFramework.MetroThemeStyle.Light;
            this.to_demand_box.UseSelectable = true;
            // 
            // barChart
            // 
            this.barChart.AutoSize = true;
            this.barChart.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barChart.ForeColor = System.Drawing.SystemColors.Info;
            this.barChart.Location = new System.Drawing.Point(823, 26);
            this.barChart.Name = "barChart";
            this.barChart.Size = new System.Drawing.Size(76, 18);
            this.barChart.TabIndex = 5;
            this.barChart.Text = "Bar Chart";
            this.barChart.UseVisualStyleBackColor = true;
            this.barChart.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Spl
            // 
            this.Spl.AutoSize = true;
            this.Spl.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spl.ForeColor = System.Drawing.SystemColors.Info;
            this.Spl.Location = new System.Drawing.Point(822, 47);
            this.Spl.Name = "Spl";
            this.Spl.Size = new System.Drawing.Size(86, 18);
            this.Spl.TabIndex = 6;
            this.Spl.Text = "Spline Area";
            this.Spl.UseVisualStyleBackColor = true;
            // 
            // from_demand_box
            // 
            this.from_demand_box.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.from_demand_box.ForeColor = System.Drawing.SystemColors.Info;
            this.from_demand_box.FormattingEnabled = true;
            this.from_demand_box.ItemHeight = 23;
            this.from_demand_box.Location = new System.Drawing.Point(383, 21);
            this.from_demand_box.Name = "from_demand_box";
            this.from_demand_box.Size = new System.Drawing.Size(192, 29);
            this.from_demand_box.TabIndex = 2;
            this.from_demand_box.Theme = MetroFramework.MetroThemeStyle.Light;
            this.from_demand_box.UseSelectable = true;
            this.from_demand_box.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Varela", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "DEMAND - SUPPLY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.reload_demand);
            this.panel3.Controls.Add(this.save_service);
            this.panel3.Controls.Add(this.calculate_console);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.inbound_checkbox);
            this.panel3.Controls.Add(this.outbound_checkbox);
            this.panel3.Controls.Add(this.service_type);
            this.panel3.Controls.Add(this.dgvService);
            this.panel3.Controls.Add(this.textfilepath);
            this.panel3.Controls.Add(this.import_csv_service);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.service_name_textbox);
            this.panel3.Controls.Add(this.add_service);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Varela", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(6, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1284, 340);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // save_service
            // 
            this.save_service.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_service.ForeColor = System.Drawing.SystemColors.Desktop;
            this.save_service.Location = new System.Drawing.Point(0, 305);
            this.save_service.Name = "save_service";
            this.save_service.Size = new System.Drawing.Size(99, 30);
            this.save_service.TabIndex = 13;
            this.save_service.Text = "Save services";
            this.save_service.UseVisualStyleBackColor = true;
            this.save_service.Click += new System.EventHandler(this.save_service_Click);
            // 
            // calculate_console
            // 
            this.calculate_console.Enabled = false;
            this.calculate_console.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_console.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculate_console.Location = new System.Drawing.Point(103, 305);
            this.calculate_console.Name = "calculate_console";
            this.calculate_console.Size = new System.Drawing.Size(227, 30);
            this.calculate_console.TabIndex = 12;
            this.calculate_console.Text = "GENERATE SERVICE";
            this.calculate_console.UseVisualStyleBackColor = true;
            this.calculate_console.Click += new System.EventHandler(this.calculate_console_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkedListBox_station);
            this.panel2.Controls.Add(this.stopstation_label);
            this.panel2.Location = new System.Drawing.Point(14, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 144);
            this.panel2.TabIndex = 11;
            // 
            // checkedListBox_station
            // 
            this.checkedListBox_station.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.checkedListBox_station.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_station.CheckOnClick = true;
            this.checkedListBox_station.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_station.ForeColor = System.Drawing.SystemColors.Info;
            this.checkedListBox_station.FormattingEnabled = true;
            this.checkedListBox_station.Location = new System.Drawing.Point(51, 7);
            this.checkedListBox_station.Name = "checkedListBox_station";
            this.checkedListBox_station.Size = new System.Drawing.Size(168, 119);
            this.checkedListBox_station.TabIndex = 6;
            // 
            // stopstation_label
            // 
            this.stopstation_label.AutoSize = true;
            this.stopstation_label.Font = new System.Drawing.Font("Varela", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopstation_label.Location = new System.Drawing.Point(4, 7);
            this.stopstation_label.Name = "stopstation_label";
            this.stopstation_label.Size = new System.Drawing.Size(41, 17);
            this.stopstation_label.TabIndex = 0;
            this.stopstation_label.Text = "stop :";
            // 
            // inbound_checkbox
            // 
            this.inbound_checkbox.AutoSize = true;
            this.inbound_checkbox.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inbound_checkbox.Location = new System.Drawing.Point(208, 98);
            this.inbound_checkbox.Name = "inbound_checkbox";
            this.inbound_checkbox.Size = new System.Drawing.Size(71, 18);
            this.inbound_checkbox.TabIndex = 10;
            this.inbound_checkbox.Text = "inbound";
            this.inbound_checkbox.UseVisualStyleBackColor = true;
            this.inbound_checkbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // outbound_checkbox
            // 
            this.outbound_checkbox.AutoSize = true;
            this.outbound_checkbox.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outbound_checkbox.Location = new System.Drawing.Point(123, 98);
            this.outbound_checkbox.Name = "outbound_checkbox";
            this.outbound_checkbox.Size = new System.Drawing.Size(79, 18);
            this.outbound_checkbox.TabIndex = 9;
            this.outbound_checkbox.Text = "outbound";
            this.outbound_checkbox.UseVisualStyleBackColor = true;
            this.outbound_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // service_type
            // 
            this.service_type.AutoSize = true;
            this.service_type.Font = new System.Drawing.Font("Varela", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_type.Location = new System.Drawing.Point(19, 97);
            this.service_type.Name = "service_type";
            this.service_type.Size = new System.Drawing.Size(86, 17);
            this.service_type.TabIndex = 8;
            this.service_type.Text = "service type :";
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToResizeRows = false;
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvService.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(338, 27);
            this.dgvService.Name = "dgvService";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Varela", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvService.Size = new System.Drawing.Size(929, 287);
            this.dgvService.TabIndex = 7;
            this.dgvService.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvService_RowHeaderMouseClick);
            this.dgvService.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvService_RowHeaderMouseClick);
            this.dgvService.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvService_RowsAdded);
            // 
            // textfilepath
            // 
            this.textfilepath.Location = new System.Drawing.Point(0, 238);
            this.textfilepath.Name = "textfilepath";
            this.textfilepath.Size = new System.Drawing.Size(10, 28);
            this.textfilepath.TabIndex = 6;
            this.textfilepath.Visible = false;
            // 
            // import_csv_service
            // 
            this.import_csv_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_csv_service.ForeColor = System.Drawing.SystemColors.ControlText;
            this.import_csv_service.Location = new System.Drawing.Point(0, 272);
            this.import_csv_service.Name = "import_csv_service";
            this.import_csv_service.Size = new System.Drawing.Size(99, 31);
            this.import_csv_service.TabIndex = 4;
            this.import_csv_service.Text = "Import services";
            this.import_csv_service.UseVisualStyleBackColor = true;
            this.import_csv_service.Click += new System.EventHandler(this.import_csv_service_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Varela", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "service name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // service_name_textbox
            // 
            this.service_name_textbox.Location = new System.Drawing.Point(124, 57);
            this.service_name_textbox.Name = "service_name_textbox";
            this.service_name_textbox.Size = new System.Drawing.Size(175, 28);
            this.service_name_textbox.TabIndex = 2;
            // 
            // add_service
            // 
            this.add_service.Enabled = false;
            this.add_service.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_service.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_service.Location = new System.Drawing.Point(102, 272);
            this.add_service.Name = "add_service";
            this.add_service.Size = new System.Drawing.Size(100, 31);
            this.add_service.TabIndex = 1;
            this.add_service.Text = "Add Service";
            this.add_service.UseVisualStyleBackColor = true;
            this.add_service.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Varela", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVICE VIEW";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // input_groupbox
            // 
            this.input_groupbox.Controls.Add(this.panel3);
            this.input_groupbox.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_groupbox.ForeColor = System.Drawing.SystemColors.Info;
            this.input_groupbox.Location = new System.Drawing.Point(42, 0);
            this.input_groupbox.Name = "input_groupbox";
            this.input_groupbox.Size = new System.Drawing.Size(1307, 367);
            this.input_groupbox.TabIndex = 4;
            this.input_groupbox.TabStop = false;
            this.input_groupbox.Text = "Add Service Here";
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Black;
            this.exitbutton.Location = new System.Drawing.Point(1607, 2);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(44, 28);
            this.exitbutton.TabIndex = 8;
            this.exitbutton.Text = "X";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serviceTab);
            this.groupBox1.Controls.Add(this.summary_label);
            this.groupBox1.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1362, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 539);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // serviceTab
            // 
            this.serviceTab.Controls.Add(Individual);
            this.serviceTab.Controls.Add(this.service_set);
            this.serviceTab.Location = new System.Drawing.Point(6, 63);
            this.serviceTab.Multiline = true;
            this.serviceTab.Name = "serviceTab";
            this.serviceTab.SelectedIndex = 0;
            this.serviceTab.Size = new System.Drawing.Size(280, 470);
            this.serviceTab.TabIndex = 13;
            this.serviceTab.SelectedIndexChanged += new System.EventHandler(this.serviceTab_SelectedIndexChanged);
            // 
            // service_set
            // 
            this.service_set.BackColor = System.Drawing.Color.LightPink;
            this.service_set.Controls.Add(this.panel4);
            this.service_set.Location = new System.Drawing.Point(4, 23);
            this.service_set.Name = "service_set";
            this.service_set.Padding = new System.Windows.Forms.Padding(3);
            this.service_set.Size = new System.Drawing.Size(272, 443);
            this.service_set.TabIndex = 1;
            this.service_set.Text = "Overall";
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.save_path);
            this.panel4.Controls.Add(this.export_to_time_table_btn);
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.label21);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(6, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 436);
            this.panel4.TabIndex = 4;
            // 
            // save_path
            // 
            this.save_path.Location = new System.Drawing.Point(12, 372);
            this.save_path.Name = "save_path";
            this.save_path.Size = new System.Drawing.Size(100, 22);
            this.save_path.TabIndex = 18;
            this.save_path.Visible = false;
            // 
            // export_to_time_table_btn
            // 
            this.export_to_time_table_btn.Enabled = false;
            this.export_to_time_table_btn.Location = new System.Drawing.Point(12, 400);
            this.export_to_time_table_btn.Name = "export_to_time_table_btn";
            this.export_to_time_table_btn.Size = new System.Drawing.Size(244, 33);
            this.export_to_time_table_btn.TabIndex = 17;
            this.export_to_time_table_btn.Text = "Send To Time Tabling";
            this.export_to_time_table_btn.UseVisualStyleBackColor = true;
            this.export_to_time_table_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
            this.richTextBox1.Location = new System.Drawing.Point(8, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(248, 284);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 14);
            this.label21.TabIndex = 7;
            this.label21.Text = "  ";
            // 
            // summary_label
            // 
            this.summary_label.AutoSize = true;
            this.summary_label.BackColor = System.Drawing.Color.Coral;
            this.summary_label.Font = new System.Drawing.Font("Varela", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_label.ForeColor = System.Drawing.Color.Cornsilk;
            this.summary_label.Location = new System.Drawing.Point(6, 18);
            this.summary_label.Name = "summary_label";
            this.summary_label.Size = new System.Drawing.Size(281, 41);
            this.summary_label.TabIndex = 1;
            this.summary_label.Text = "Service Summary";
            this.summary_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Selected_service_dgv);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(1362, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 331);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Selected Service";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Selected_service_dgv
            // 
            this.Selected_service_dgv.AutoGenerateColumns = false;
            this.Selected_service_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Selected_service_dgv.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.Selected_service_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Selected_service_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.servicenameDataGridViewTextBoxColumn,
            this.profitabilityDataGridViewTextBoxColumn,
            this.utilizationpercentDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn});
            this.Selected_service_dgv.DataSource = this.servicesummaryBindingSource;
            this.Selected_service_dgv.Location = new System.Drawing.Point(9, 71);
            this.Selected_service_dgv.Name = "Selected_service_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected_service_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Selected_service_dgv.RowHeadersWidth = 20;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Selected_service_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Selected_service_dgv.Size = new System.Drawing.Size(282, 254);
            this.Selected_service_dgv.TabIndex = 2;
            this.Selected_service_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selected_service_dgv_CellContentClick);
            this.Selected_service_dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selected_service_dgv_CellEnter);
            this.Selected_service_dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Selected_service_dgv_CellMouseClick);
            this.Selected_service_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Selected_service_dgv_CellMouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // servicenameDataGridViewTextBoxColumn
            // 
            this.servicenameDataGridViewTextBoxColumn.DataPropertyName = "Service_name";
            this.servicenameDataGridViewTextBoxColumn.HeaderText = "Service_name";
            this.servicenameDataGridViewTextBoxColumn.Name = "servicenameDataGridViewTextBoxColumn";
            this.servicenameDataGridViewTextBoxColumn.Width = 106;
            // 
            // profitabilityDataGridViewTextBoxColumn
            // 
            this.profitabilityDataGridViewTextBoxColumn.DataPropertyName = "Profitability";
            this.profitabilityDataGridViewTextBoxColumn.HeaderText = "Profitability";
            this.profitabilityDataGridViewTextBoxColumn.Name = "profitabilityDataGridViewTextBoxColumn";
            this.profitabilityDataGridViewTextBoxColumn.Width = 93;
            // 
            // utilizationpercentDataGridViewTextBoxColumn
            // 
            this.utilizationpercentDataGridViewTextBoxColumn.DataPropertyName = "Utilization_percent";
            this.utilizationpercentDataGridViewTextBoxColumn.HeaderText = "Utilization_percent";
            this.utilizationpercentDataGridViewTextBoxColumn.Name = "utilizationpercentDataGridViewTextBoxColumn";
            this.utilizationpercentDataGridViewTextBoxColumn.Width = 132;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.Width = 71;
            // 
            // servicesummaryBindingSource
            // 
            this.servicesummaryBindingSource.DataSource = typeof(Service_plan_form.Service_summary);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Font = new System.Drawing.Font("Varela", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Selected Service";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xlsx";
            // 
            // config_btn
            // 
            this.config_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(64)))));
            this.config_btn.Image = global::Service_plan_form.Properties.Resources.settings_work_tool__2_;
            this.config_btn.Location = new System.Drawing.Point(1516, 2);
            this.config_btn.Name = "config_btn";
            this.config_btn.Size = new System.Drawing.Size(37, 28);
            this.config_btn.TabIndex = 12;
            this.config_btn.UseVisualStyleBackColor = false;
            this.config_btn.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(199)))), ((int)(((byte)(72)))));
            this.reloadBtn.Image = global::Service_plan_form.Properties.Resources.refresh_page_option__1_;
            this.reloadBtn.Location = new System.Drawing.Point(1559, 2);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(42, 28);
            this.reloadBtn.TabIndex = 11;
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // stopStationBindingSource
            // 
            this.stopStationBindingSource.DataMember = "StopStation";
            this.stopStationBindingSource.DataSource = this.servicesummaryBindingSource;
            // 
            // reload_demand
            // 
            this.reload_demand.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reload_demand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reload_demand.Location = new System.Drawing.Point(208, 273);
            this.reload_demand.Name = "reload_demand";
            this.reload_demand.Size = new System.Drawing.Size(122, 30);
            this.reload_demand.TabIndex = 14;
            this.reload_demand.Text = "Recheck Mode";
            this.reload_demand.UseVisualStyleBackColor = true;
            this.reload_demand.Click += new System.EventHandler(this.reload_demand_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1665, 918);
            this.Controls.Add(this.config_btn);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.input_groupbox);
            this.Controls.Add(this.output_panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            Individual.ResumeLayout(false);
            this.panel_summary.ResumeLayout(false);
            this.panel_summary.PerformLayout();
            this.output_panel.ResumeLayout(false);
            this.output_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.input_groupbox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.serviceTab.ResumeLayout(false);
            this.service_set.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_service_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopStationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel output_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox input_groupbox;
        private MetroFramework.Controls.MetroComboBox from_demand_box;
        private MetroFramework.Controls.MetroComboBox to_demand_box;
        private System.Windows.Forms.Panel output_panel_graph;
        private System.Windows.Forms.CheckBox barChart;
        private System.Windows.Forms.CheckBox Spl;
        private System.Windows.Forms.CheckBox stationcheckBox;
        private System.Windows.Forms.Button add_service;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox service_name_textbox;
        private System.Windows.Forms.Button import_csv_service;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textfilepath;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.CheckBox outbound_checkbox;
        private System.Windows.Forms.Label service_type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label stopstation_label;
        private System.Windows.Forms.CheckBox inbound_checkbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label summary_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox_station;
        private System.Windows.Forms.Button calculate_console;
        private System.Windows.Forms.DataGridView Selected_service_dgv;
        private System.Windows.Forms.BindingSource servicesummaryBindingSource;
        private System.Windows.Forms.BindingSource stopStationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.TabControl serviceTab;
        private System.Windows.Forms.TabPage service_set;
        private System.Windows.Forms.Panel panel_summary;
        private System.Windows.Forms.Label operation_cost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label profit;
        private System.Windows.Forms.Label utilization_percent;
        private System.Windows.Forms.Label income;
        private System.Windows.Forms.Label served_demand;
        private System.Windows.Forms.Label departure_time;
        private System.Windows.Forms.Label stop_station;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label service_name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button save_service;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button config_btn;
        private System.Windows.Forms.Button export_to_time_table_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox save_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizationpercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button reload_demand;
    }
}

