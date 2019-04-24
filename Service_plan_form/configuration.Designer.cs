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
            this.Operation_cost_label = new System.Windows.Forms.Label();
            this.operation_textbox = new System.Windows.Forms.TextBox();
            this.service_speed_textbox = new System.Windows.Forms.TextBox();
            this.service_speed_label = new System.Windows.Forms.Label();
            this.dwell_time_textbox = new System.Windows.Forms.TextBox();
            this.dwell_label = new System.Windows.Forms.Label();
            this.headway_textbox = new System.Windows.Forms.TextBox();
            this.headway_label = new System.Windows.Forms.Label();
            this.utilize_textbox = new System.Windows.Forms.TextBox();
            this.utilize_threshold = new System.Windows.Forms.Label();
            this.trainsize_textbox = new System.Windows.Forms.TextBox();
            this.train_size_label = new System.Windows.Forms.Label();
            this.config_save_btn = new System.Windows.Forms.Button();
            this.restore_defult_config_btn = new System.Windows.Forms.Button();
            this.service_plan_config_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // service_plan_config_groupbox
            // 
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
            this.service_plan_config_groupbox.Location = new System.Drawing.Point(47, 12);
            this.service_plan_config_groupbox.Name = "service_plan_config_groupbox";
            this.service_plan_config_groupbox.Size = new System.Drawing.Size(776, 426);
            this.service_plan_config_groupbox.TabIndex = 0;
            this.service_plan_config_groupbox.TabStop = false;
            this.service_plan_config_groupbox.Text = "Service Planning Config";
            // 
            // Operation_cost_label
            // 
            this.Operation_cost_label.AutoSize = true;
            this.Operation_cost_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operation_cost_label.Location = new System.Drawing.Point(99, 55);
            this.Operation_cost_label.Name = "Operation_cost_label";
            this.Operation_cost_label.Size = new System.Drawing.Size(241, 24);
            this.Operation_cost_label.TabIndex = 0;
            this.Operation_cost_label.Text = "Operation cost (Per Meter) :";
            // 
            // operation_textbox
            // 
            this.operation_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.operation_textbox.Location = new System.Drawing.Point(347, 52);
            this.operation_textbox.Name = "operation_textbox";
            this.operation_textbox.Size = new System.Drawing.Size(263, 29);
            this.operation_textbox.TabIndex = 1;
            // 
            // service_speed_textbox
            // 
            this.service_speed_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.service_speed_textbox.Location = new System.Drawing.Point(347, 107);
            this.service_speed_textbox.Name = "service_speed_textbox";
            this.service_speed_textbox.Size = new System.Drawing.Size(263, 29);
            this.service_speed_textbox.TabIndex = 3;
            // 
            // service_speed_label
            // 
            this.service_speed_label.AutoSize = true;
            this.service_speed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_speed_label.Location = new System.Drawing.Point(63, 107);
            this.service_speed_label.Name = "service_speed_label";
            this.service_speed_label.Size = new System.Drawing.Size(277, 24);
            this.service_speed_label.TabIndex = 2;
            this.service_speed_label.Text = "Service speed (Unit Per Meter) :";
            // 
            // dwell_time_textbox
            // 
            this.dwell_time_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dwell_time_textbox.Location = new System.Drawing.Point(347, 162);
            this.dwell_time_textbox.Name = "dwell_time_textbox";
            this.dwell_time_textbox.Size = new System.Drawing.Size(263, 29);
            this.dwell_time_textbox.TabIndex = 5;
            // 
            // dwell_label
            // 
            this.dwell_label.AutoSize = true;
            this.dwell_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwell_label.Location = new System.Drawing.Point(156, 162);
            this.dwell_label.Name = "dwell_label";
            this.dwell_label.Size = new System.Drawing.Size(184, 24);
            this.dwell_label.TabIndex = 4;
            this.dwell_label.Text = "Dwell time (Miniute) :";
            // 
            // headway_textbox
            // 
            this.headway_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.headway_textbox.Location = new System.Drawing.Point(347, 215);
            this.headway_textbox.Name = "headway_textbox";
            this.headway_textbox.Size = new System.Drawing.Size(263, 29);
            this.headway_textbox.TabIndex = 7;
            // 
            // headway_label
            // 
            this.headway_label.AutoSize = true;
            this.headway_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headway_label.Location = new System.Drawing.Point(163, 215);
            this.headway_label.Name = "headway_label";
            this.headway_label.Size = new System.Drawing.Size(177, 24);
            this.headway_label.TabIndex = 6;
            this.headway_label.Text = "Headway (Miniute) :";
            // 
            // utilize_textbox
            // 
            this.utilize_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.utilize_textbox.Location = new System.Drawing.Point(347, 267);
            this.utilize_textbox.Name = "utilize_textbox";
            this.utilize_textbox.Size = new System.Drawing.Size(263, 29);
            this.utilize_textbox.TabIndex = 9;
            // 
            // utilize_threshold
            // 
            this.utilize_threshold.AutoSize = true;
            this.utilize_threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilize_threshold.Location = new System.Drawing.Point(69, 267);
            this.utilize_threshold.Name = "utilize_threshold";
            this.utilize_threshold.Size = new System.Drawing.Size(271, 24);
            this.utilize_threshold.TabIndex = 8;
            this.utilize_threshold.Text = "Utilization Threshold (Percent) :";
            // 
            // trainsize_textbox
            // 
            this.trainsize_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.trainsize_textbox.Location = new System.Drawing.Point(347, 317);
            this.trainsize_textbox.Name = "trainsize_textbox";
            this.trainsize_textbox.Size = new System.Drawing.Size(263, 29);
            this.trainsize_textbox.TabIndex = 11;
            // 
            // train_size_label
            // 
            this.train_size_label.AutoSize = true;
            this.train_size_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.train_size_label.Location = new System.Drawing.Point(239, 317);
            this.train_size_label.Name = "train_size_label";
            this.train_size_label.Size = new System.Drawing.Size(101, 24);
            this.train_size_label.TabIndex = 10;
            this.train_size_label.Text = "Train size :";
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
            // Config_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.service_plan_config_groupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
    }
}