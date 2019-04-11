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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.summary_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.output_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.input_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label2.Font = new System.Drawing.Font("Varela", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "DEMAND - SUPPLY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
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
            this.panel3.Size = new System.Drawing.Size(1267, 340);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.stopstation_label);
            this.panel2.Location = new System.Drawing.Point(14, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 144);
            this.panel2.TabIndex = 11;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(51, 100);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(74, 18);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Station 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(51, 76);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(74, 18);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Station 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(51, 54);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 18);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Station 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(51, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 18);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Station 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(51, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 18);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Station 1";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.dgvService.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(338, 63);
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvService.Size = new System.Drawing.Size(900, 251);
            this.dgvService.TabIndex = 7;
            // 
            // textfilepath
            // 
            this.textfilepath.Location = new System.Drawing.Point(3, 272);
            this.textfilepath.Name = "textfilepath";
            this.textfilepath.Size = new System.Drawing.Size(102, 28);
            this.textfilepath.TabIndex = 6;
            this.textfilepath.Visible = false;
            // 
            // import_csv_service
            // 
            this.import_csv_service.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_csv_service.ForeColor = System.Drawing.SystemColors.ControlText;
            this.import_csv_service.Location = new System.Drawing.Point(3, 306);
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
            this.add_service.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_service.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_service.Location = new System.Drawing.Point(124, 306);
            this.add_service.Name = "add_service";
            this.add_service.Size = new System.Drawing.Size(84, 31);
            this.add_service.TabIndex = 1;
            this.add_service.Text = "Add Service";
            this.add_service.UseVisualStyleBackColor = true;
            this.add_service.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Font = new System.Drawing.Font("Varela Round", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 42);
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
            this.input_groupbox.Text = "Input GroupBox";
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.exitbutton.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.DarkRed;
            this.exitbutton.Location = new System.Drawing.Point(1591, 0);
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
            this.groupBox1.Controls.Add(this.summary_label);
            this.groupBox1.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1355, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 330);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // summary_label
            // 
            this.summary_label.AutoSize = true;
            this.summary_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.summary_label.Font = new System.Drawing.Font("Varela Round", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_label.ForeColor = System.Drawing.Color.Cornsilk;
            this.summary_label.Location = new System.Drawing.Point(6, 18);
            this.summary_label.Name = "summary_label";
            this.summary_label.Size = new System.Drawing.Size(280, 42);
            this.summary_label.TabIndex = 1;
            this.summary_label.Text = "Service Summary";
            this.summary_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(1355, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 528);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suggestion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label5.Font = new System.Drawing.Font("Varela Round", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 42);
            this.label5.TabIndex = 1;
            this.label5.Text = "Suggestion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1685, 928);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label stopstation_label;
        private System.Windows.Forms.CheckBox inbound_checkbox;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label summary_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}

