namespace Service_plan_form
{
    partial class Service_editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.service_combo = new System.Windows.Forms.ComboBox();
            this.select_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service set :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(50, 75);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // service_combo
            // 
            this.service_combo.FormattingEnabled = true;
            this.service_combo.Location = new System.Drawing.Point(120, 40);
            this.service_combo.Name = "service_combo";
            this.service_combo.Size = new System.Drawing.Size(191, 21);
            this.service_combo.TabIndex = 3;
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(240, 75);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(75, 23);
            this.select_button.TabIndex = 4;
            this.select_button.Text = "Select";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // Service_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 116);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.service_combo);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label1);
            this.Name = "Service_editor";
            this.Text = "Service_editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ComboBox service_combo;
        private System.Windows.Forms.Button select_button;
    }
}