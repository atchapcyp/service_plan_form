namespace Service_plan_form
{
    partial class Config_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config_form));
            this.service_plan_config_groupbox = new System.Windows.Forms.GroupBox();
            this.restore_defult_config_btn = new System.Windows.Forms.Button();
            this.config_save_btn = new System.Windows.Forms.Button();
            this.trainsize_textbox = new System.Windows.Forms.TextBox();
            this.train_size_label = new System.Windows.Forms.Label();
            this.utilize_textbox = new System.Windows.Forms.TextBox();
            this.utilize_threshold = new System.Windows.Forms.Label();
            this.headway_textbox = new System.Windows.Forms.TextBox();
            this.headway_label = new System.Windows.Forms.Label();
            this.dwell_time_textbox = new System.Windows.Forms.TextBox();
            this.dwell_label = new System.Windows.Forms.Label();
            this.service_speed_textbox = new System.Windows.Forms.TextBox();
            this.service_speed_label = new System.Windows.Forms.Label();
            this.operation_textbox = new System.Windows.Forms.TextBox();
            this.Operation_cost_label = new System.Windows.Forms.Label();
            this.inbound_checkbox_config = new System.Windows.Forms.CheckBox();
            this.outbound_checkbox_config = new System.Windows.Forms.CheckBox();
            this.ib_ob_mode = new System.Windows.Forms.Label();
            this.service_plan_config_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // service_plan_config_groupbox
            // 
            this.service_plan_config_groupbox.Controls.Add(this.ib_ob_mode);
            this.service_plan_config_groupbox.Controls.Add(this.inbound_checkbox_config);
            this.service_plan_config_groupbox.Controls.Add(this.outbound_checkbox_config);
            this.service_plan_config_groupbox.Controls.Add(this.restore_defult_config_btn);
            this.service_plan_config_groupbox.Controls.Add(this.config_save_btn);
            this.service_plan_config_groupbox.Controls.Add(this.trainsize_textbox);
            this.service_plan_config_groupbox.Controls.Add(this.train_size_label);
            this.service_plan_config_groupbox.Controls.Add(this.utilize_textbox);
            this.service_plan_config_groupbox.Controls.Add(this.utilize_threshold);
            this.service_plan_config_groupbox.Controls.Add(this.headway_textbox);
            this.service_plan_config_groupbox.Controls.Add(this.headway_label);
            this.service_plan_config_groupbox.Controls.Add(this.dwell_time_textbox);
            this.service_plan_config_groupbox.Controls.Add(this.dwell_label);
            this.service_plan_config_groupbox.Controls.Add(this.service_speed_textbox);
            this.service_plan_config_groupbox.Controls.Add(this.service_speed_label);
            this.service_plan_config_groupbox.Controls.Add(this.operation_textbox);
            this.service_plan_config_groupbox.Controls.Add(this.Operation_cost_label);
            this.service_plan_config_groupbox.Location = new System.Drawing.Point(12, 12);
            this.service_plan_config_groupbox.Name = "service_plan_config_groupbox";
            this.service_plan_config_groupbox.Size = new System.Drawing.Size(776, 426);
            this.service_plan_config_groupbox.TabIndex = 0;
            this.service_plan_config_groupbox.TabStop = false;
            this.service_plan_config_groupbox.Text = "Service Planning Config";
            // 
            // restore_defult_config_btn
            // 
            this.restore_defult_config_btn.Location = new System.Drawing.Point(22, 377);
            this.restore_defult_config_btn.Name = "restore_defult_config_btn";
            this.restore_defult_config_btn.Size = new System.Drawing.Size(95, 23);
            this.restore_defult_config_btn.TabIndex = 13;
            this.restore_defult_config_btn.Text = "Restore Default";
            this.restore_defult_config_btn.UseVisualStyleBackColor = true;
            this.restore_defult_config_btn.Click += new System.EventHandler(this.restore_defult_config_btn_Click);
            // 
            // config_save_btn
            // 
            this.config_save_btn.Location = new System.Drawing.Point(643, 377);
            this.config_save_btn.Name = "config_save_btn";
            this.config_save_btn.Size = new System.Drawing.Size(75, 23);
            this.config_save_btn.TabIndex = 12;
            this.config_save_btn.Text = "Apply Config";
            this.config_save_btn.UseVisualStyleBackColor = true;
            this.config_save_btn.Click += new System.EventHandler(this.config_save_btn_Click);
            // 
            // trainsize_textbox
            // 
            this.trainsize_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.trainsize_textbox.Location = new System.Drawing.Point(357, 333);
            this.trainsize_textbox.Name = "trainsize_textbox";
            this.trainsize_textbox.Size = new System.Drawing.Size(263, 29);
            this.trainsize_textbox.TabIndex = 11;
            // 
            // train_size_label
            // 
            this.train_size_label.AutoSize = true;
            this.train_size_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.train_size_label.Location = new System.Drawing.Point(249, 333);
            this.train_size_label.Name = "train_size_label";
            this.train_size_label.Size = new System.Drawing.Size(101, 24);
            this.train_size_label.TabIndex = 10;
            this.train_size_label.Text = "Train size :";
            // 
            // utilize_textbox
            // 
            this.utilize_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.utilize_textbox.Location = new System.Drawing.Point(357, 283);
            this.utilize_textbox.Name = "utilize_textbox";
            this.utilize_textbox.Size = new System.Drawing.Size(263, 29);
            this.utilize_textbox.TabIndex = 9;
            // 
            // utilize_threshold
            // 
            this.utilize_threshold.AutoSize = true;
            this.utilize_threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilize_threshold.Location = new System.Drawing.Point(79, 283);
            this.utilize_threshold.Name = "utilize_threshold";
            this.utilize_threshold.Size = new System.Drawing.Size(271, 24);
            this.utilize_threshold.TabIndex = 8;
            this.utilize_threshold.Text = "Utilization Threshold (Percent) :";
            // 
            // headway_textbox
            // 
            this.headway_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.headway_textbox.Location = new System.Drawing.Point(357, 231);
            this.headway_textbox.Name = "headway_textbox";
            this.headway_textbox.Size = new System.Drawing.Size(263, 29);
            this.headway_textbox.TabIndex = 7;
            // 
            // headway_label
            // 
            this.headway_label.AutoSize = true;
            this.headway_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headway_label.Location = new System.Drawing.Point(173, 231);
            this.headway_label.Name = "headway_label";
            this.headway_label.Size = new System.Drawing.Size(177, 24);
            this.headway_label.TabIndex = 6;
            this.headway_label.Text = "Headway (Miniute) :";
            // 
            // dwell_time_textbox
            // 
            this.dwell_time_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dwell_time_textbox.Location = new System.Drawing.Point(357, 178);
            this.dwell_time_textbox.Name = "dwell_time_textbox";
            this.dwell_time_textbox.Size = new System.Drawing.Size(263, 29);
            this.dwell_time_textbox.TabIndex = 5;
            // 
            // dwell_label
            // 
            this.dwell_label.AutoSize = true;
            this.dwell_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwell_label.Location = new System.Drawing.Point(166, 178);
            this.dwell_label.Name = "dwell_label";
            this.dwell_label.Size = new System.Drawing.Size(184, 24);
            this.dwell_label.TabIndex = 4;
            this.dwell_label.Text = "Dwell time (Miniute) :";
            // 
            // service_speed_textbox
            // 
            this.service_speed_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.service_speed_textbox.Location = new System.Drawing.Point(357, 123);
            this.service_speed_textbox.Name = "service_speed_textbox";
            this.service_speed_textbox.Size = new System.Drawing.Size(263, 29);
            this.service_speed_textbox.TabIndex = 3;
            // 
            // service_speed_label
            // 
            this.service_speed_label.AutoSize = true;
            this.service_speed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_speed_label.Location = new System.Drawing.Point(73, 123);
            this.service_speed_label.Name = "service_speed_label";
            this.service_speed_label.Size = new System.Drawing.Size(277, 24);
            this.service_speed_label.TabIndex = 2;
            this.service_speed_label.Text = "Service speed (Unit Per Meter) :";
            // 
            // operation_textbox
            // 
            this.operation_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.operation_textbox.Location = new System.Drawing.Point(357, 68);
            this.operation_textbox.Name = "operation_textbox";
            this.operation_textbox.Size = new System.Drawing.Size(263, 29);
            this.operation_textbox.TabIndex = 1;
            // 
            // Operation_cost_label
            // 
            this.Operation_cost_label.AutoSize = true;
            this.Operation_cost_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operation_cost_label.Location = new System.Drawing.Point(109, 71);
            this.Operation_cost_label.Name = "Operation_cost_label";
            this.Operation_cost_label.Size = new System.Drawing.Size(241, 24);
            this.Operation_cost_label.TabIndex = 0;
            this.Operation_cost_label.Text = "Operation cost (Per Meter) :";
            // 
            // inbound_checkbox_config
            // 
            this.inbound_checkbox_config.AutoSize = true;
            this.inbound_checkbox_config.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inbound_checkbox_config.Location = new System.Drawing.Point(442, 37);
            this.inbound_checkbox_config.Name = "inbound_checkbox_config";
            this.inbound_checkbox_config.Size = new System.Drawing.Size(71, 18);
            this.inbound_checkbox_config.TabIndex = 15;
            this.inbound_checkbox_config.Text = "inbound";
            this.inbound_checkbox_config.UseVisualStyleBackColor = true;
            this.inbound_checkbox_config.CheckedChanged += new System.EventHandler(this.inbound_checkbox_CheckedChanged);
            // 
            // outbound_checkbox_config
            // 
            this.outbound_checkbox_config.AutoSize = true;
            this.outbound_checkbox_config.Font = new System.Drawing.Font("Varela", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outbound_checkbox_config.Location = new System.Drawing.Point(357, 37);
            this.outbound_checkbox_config.Name = "outbound_checkbox_config";
            this.outbound_checkbox_config.Size = new System.Drawing.Size(79, 18);
            this.outbound_checkbox_config.TabIndex = 14;
            this.outbound_checkbox_config.Text = "outbound";
            this.outbound_checkbox_config.UseVisualStyleBackColor = true;
            this.outbound_checkbox_config.CheckedChanged += new System.EventHandler(this.outbound_checkbox_config_CheckedChanged);
            // 
            // ib_ob_mode
            // 
            this.ib_ob_mode.AutoSize = true;
            this.ib_ob_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ib_ob_mode.Location = new System.Drawing.Point(281, 31);
            this.ib_ob_mode.Name = "ib_ob_mode";
            this.ib_ob_mode.Size = new System.Drawing.Size(69, 24);
            this.ib_ob_mode.TabIndex = 16;
            this.ib_ob_mode.Text = "Mode :";
            // 
            // Config_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.service_plan_config_groupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config_form";
            this.Text = "Service Planning Config";
            this.Load += new System.EventHandler(this.Config_form_Load);
            this.service_plan_config_groupbox.ResumeLayout(false);
            this.service_plan_config_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox service_plan_config_groupbox;
        private System.Windows.Forms.Label Operation_cost_label;
        private System.Windows.Forms.TextBox utilize_textbox;
        private System.Windows.Forms.Label utilize_threshold;
        private System.Windows.Forms.TextBox headway_textbox;
        private System.Windows.Forms.Label headway_label;
        private System.Windows.Forms.TextBox dwell_time_textbox;
        private System.Windows.Forms.Label dwell_label;
        private System.Windows.Forms.TextBox service_speed_textbox;
        private System.Windows.Forms.Label service_speed_label;
        private System.Windows.Forms.TextBox operation_textbox;
        private System.Windows.Forms.TextBox trainsize_textbox;
        private System.Windows.Forms.Label train_size_label;
        private System.Windows.Forms.Button restore_defult_config_btn;
        private System.Windows.Forms.Button config_save_btn;
        private System.Windows.Forms.Label ib_ob_mode;
        private System.Windows.Forms.CheckBox inbound_checkbox_config;
        private System.Windows.Forms.CheckBox outbound_checkbox_config;
    }
}