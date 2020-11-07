using Priority_Queue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int flightNo = 1000;
        int E_level;
        bool isSimulatorON;
        PriorityQueue PQ;
        public Form1()
        {
            InitializeComponent();
            isSimulatorON = false;
            PQ = new PriorityQueue();
            E_level = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void simulateButton_Click(object sender, EventArgs e)
        {
            if (isSimulatorON == false)
            {
                simulateButton.Text = "Stop";
                simulate_timer.Start();
                isSimulatorON = true;
            }
            else
            {
                simulateButton.Text = "Simulate";
                simulate_timer.Stop();
                isSimulatorON = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String time = time_text.Text;
            int t1 = Int32.Parse(time);
            t1 = t1 + 5;
            time_text.Text = t1.ToString();
            
            
        }

        private void add_arrival_button_Click(object sender, EventArgs e)
        {
            flightNo++;
            PQ.enQueue(flightNo.ToString(), E_level);
            string str = flightNo.ToString();
            instruction_text.Text = str + " is added into the holding stack! ";
        }

        private void add_departure_button_Click(object sender, EventArgs e)
        {

        }

        private void list_Emergency_levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            E_level = list_Emergency_levels.SelectedIndex + 1;
        }
    }
}
