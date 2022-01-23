using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace thesis_2nd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox_stepper.Enabled = false;
            groupBox_Homming.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

            serialPort1.Write("H" + "\n");

        }

        private void comboBox_dropdown_DropDown(object sender, EventArgs e)
        {
            string[] portlists = SerialPort.GetPortNames();
            comboBox_com.Items.Clear();
            comboBox_com.Items.AddRange(portlists);

        }

        private void button_COM_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_com.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();

                MessageBox.Show("Επιτυχία σύνδεσης με μικροελεγκτή!");
                groupBox_stepper.Enabled = true;
                groupBox_Homming.Enabled = true;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message); 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
              
            catch (Exception error)
            {
                MessageBox.Show(error.Message); 
            }

}

        private void f(object sender, EventArgs e)
        {

        }

        private void textBoxXaxis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            // send thesis value to stepper x
            string m1 = 'Q' + textBoxXaxis.Text;
            serialPort1.Write(m1 + "\n");
            
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            // send thesis value to stepper y
            string m2 = 'R' + textBoxYaxis.Text;
            serialPort1.Write(m2 + "\n");
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            // send thesis value to stepper z
            string m3 = 'S' + textBoxZaxis.Text;
            serialPort1.Write(m3 + "\n");
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            // send thesis value to steper T
            string m4 = 'T' + textBoxTable.Text;
            serialPort1.Write(m4 + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
