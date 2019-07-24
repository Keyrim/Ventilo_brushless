using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESC_fan
{
    public partial class Esc_fan : Form
    {
        public Esc_fan()
        {
            InitializeComponent();
        }

        private void NumericUpDown_port_number_ValueChanged(object sender, EventArgs e)
        {
            Arduino.PortName = "COM" + numericUpDown_port_number.Value.ToString();
        }

        private void Button_connexion_Click(object sender, EventArgs e)
        {
            if (Arduino.IsOpen) Arduino.Close();
            try
            {
                Arduino.Open();
            }
            catch
            {

            }
               
        }

        private void Button_send_value_Click(object sender, EventArgs e)
        {
            Arduino.WriteLine(numericUpDown_esc_value.ToString());
        }
    }
}
