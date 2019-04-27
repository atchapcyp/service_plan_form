using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_plan_form
{
    public partial class Config_form : Form
    {
        public Config_form()
        {
            InitializeComponent();
        }

        private void restore_defult_config_btn_Click(object sender, EventArgs e)
        {

            operation_textbox.Text = "1.0";
            service_speed_textbox.Text = "20000";
            dwell_time_textbox.Text = "5";
            headway_textbox.Text = "10";
            utilize_textbox.Text = "50";
            trainsize_textbox.Text = "500";
            outbound_checkbox_config.Checked = true;
        }

        private void config_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                PhysicalData.operation_cost_per_meter = Convert.ToSingle(operation_textbox.Text);
                PhysicalData.service_speed = Convert.ToSingle(service_speed_textbox.Text); // meter per hour
                PhysicalData.dwell_time = Convert.ToInt32(dwell_time_textbox.Text); // miniute
                PhysicalData.headway = Convert.ToInt32(headway_textbox.Text); //miniute
                PhysicalData.utilize_percent = Convert.ToInt32(utilize_textbox.Text);
                PhysicalData.TrainSize = Convert.ToInt32(trainsize_textbox.Text);
                if (outbound_checkbox_config.Checked == true)
                {
                    PhysicalData.Current_mode = 0;
                }
                if (inbound_checkbox_config.Checked == true)
                {
                    PhysicalData.Current_mode = 1;
                }
                MessageBox.Show("          Configuration Saved            ");
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("All Input must be number.");
            }
        }

        private void Config_form_Load(object sender, EventArgs e)
        {
            if (PhysicalData.Current_mode == 0)
            {
                outbound_checkbox_config.Checked = true;
            }
            if (PhysicalData.Current_mode == 1)
            {
              inbound_checkbox_config.Checked = true;
            }
            operation_textbox.Text = PhysicalData.operation_cost_per_meter.ToString();
            service_speed_textbox.Text = PhysicalData.service_speed.ToString();
            dwell_time_textbox.Text = PhysicalData.dwell_time.ToString();
            headway_textbox.Text = PhysicalData.headway.ToString();
            utilize_textbox.Text = PhysicalData.utilize_percent.ToString();
            trainsize_textbox.Text = PhysicalData.TrainSize.ToString();
        }

        private void inbound_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (inbound_checkbox_config.Checked)
            {
                outbound_checkbox_config.Checked = false;
            }
        }

        private void outbound_checkbox_config_CheckedChanged(object sender, EventArgs e)
        {
            if (outbound_checkbox_config.Checked)
            {
                inbound_checkbox_config.Checked = false;
            }
        }
    }
}
