﻿namespace Service_plan_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.output_panel = new System.Windows.Forms.Panel();
            this.to_demand_box = new MetroFramework.Controls.MetroComboBox();
            this.from_demand_box = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Station1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.input_groupbox = new System.Windows.Forms.GroupBox();
            this.output_panel_graph = new System.Windows.Forms.Panel();
            this.output_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Station1)).BeginInit();
            this.input_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Varela Round", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(880, 278);
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
            this.panel1.Size = new System.Drawing.Size(150, 634);
            this.panel1.TabIndex = 1;
            // 
            // output_panel
            // 
            this.output_panel.Controls.Add(this.output_panel_graph);
            this.output_panel.Controls.Add(this.to_demand_box);
            this.output_panel.Controls.Add(this.from_demand_box);
            this.output_panel.Controls.Add(this.label2);
            this.output_panel.ForeColor = System.Drawing.SystemColors.Info;
            this.output_panel.Location = new System.Drawing.Point(153, 328);
            this.output_panel.Name = "output_panel";
            this.output_panel.Size = new System.Drawing.Size(839, 308);
            this.output_panel.TabIndex = 2;
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
            // from_demand_box
            // 
            this.from_demand_box.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.from_demand_box.ForeColor = System.Drawing.SystemColors.Info;
            this.from_demand_box.FormattingEnabled = true;
            this.from_demand_box.ItemHeight = 23;
            this.from_demand_box.Location = new System.Drawing.Point(383, 21);
            this.from_demand_box.Name = "from_demand_box";
            this.from_demand_box.Size = new System.Drawing.Size(183, 29);
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
            this.label2.Size = new System.Drawing.Size(358, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "OUTPUT SHOW HERE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.Station1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Varela", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(6, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 289);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Station1
            // 
            chartArea1.Name = "ChartArea1";
            this.Station1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Station1.Legends.Add(legend1);
            this.Station1.Location = new System.Drawing.Point(157, 65);
            this.Station1.Name = "Station1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Station1";
            this.Station1.Series.Add(series1);
            this.Station1.Size = new System.Drawing.Size(285, 115);
            this.Station1.TabIndex = 1;
            this.Station1.Text = "chart1";
            this.Station1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Font = new System.Drawing.Font("Varela Round", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUT SHOW HERE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // input_groupbox
            // 
            this.input_groupbox.Controls.Add(this.panel3);
            this.input_groupbox.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_groupbox.ForeColor = System.Drawing.SystemColors.Info;
            this.input_groupbox.Location = new System.Drawing.Point(167, 0);
            this.input_groupbox.Name = "input_groupbox";
            this.input_groupbox.Size = new System.Drawing.Size(707, 322);
            this.input_groupbox.TabIndex = 4;
            this.input_groupbox.TabStop = false;
            this.input_groupbox.Text = "Input GroupBox";
            // 
            // output_panel_graph
            // 
            this.output_panel_graph.AutoScroll = true;
            this.output_panel_graph.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_panel_graph.Location = new System.Drawing.Point(14, 54);
            this.output_panel_graph.Name = "output_panel_graph";
            this.output_panel_graph.Size = new System.Drawing.Size(806, 242);
            this.output_panel_graph.TabIndex = 4;
            this.output_panel_graph.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1001, 636);
            this.Controls.Add(this.input_groupbox);
            this.Controls.Add(this.output_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.output_panel.ResumeLayout(false);
            this.output_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Station1)).EndInit();
            this.input_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel output_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Station1;
        private System.Windows.Forms.GroupBox input_groupbox;
        private MetroFramework.Controls.MetroComboBox from_demand_box;
        private MetroFramework.Controls.MetroComboBox to_demand_box;
        private System.Windows.Forms.Panel output_panel_graph;
    }
}

