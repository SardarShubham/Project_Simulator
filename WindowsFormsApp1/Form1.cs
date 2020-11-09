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
        static int time;
        static int flightNo = 1000;
        int E_level;
        bool isSimulatorON;
        const int landing_time = 100 ; // 100 sec
        const int takeOff_time = 120; // 2 min
        const int holding_to_approach_time = 30; // 30 sec
        const int fuel_capacity = 1800; // 1800 litres
        const int fuelConsume_Rate = 4; // 4 lit/sec
        int time_counter;
        bool isRunwayAvailable;
        string temp;
        PriorityQueue PQ;
        List<Label> arrival_label_list;
        string[] arrivalList;
        Circular_list instruction_list;
        public Form1()
        {
            InitializeComponent();
            isSimulatorON = false;
            time_counter = 0;
            isRunwayAvailable = true;
            temp = null;
            // object of priority queue
            PQ = new PriorityQueue();
            // list of labels for arrivals table
            arrival_label_list = new List<Label>();
            // object of circular array
            instruction_list = new Circular_list();
            // adding the labels into the list of labels
            arrival_label_list.Add(arrival_row1);
            arrival_label_list.Add(arrival_row2);
            arrival_label_list.Add(arrival_row3);
            arrival_label_list.Add(arrival_row4);
            arrival_label_list.Add(arrival_row5);
            // emergency level
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
            time = time + 5;
            time_text.Text = time.ToString();
            instruction_txt.Text = instruction_list.display();
            updateArrivalTable();
            /* if runway availability , add landing
            //if (isRunwayAvailable)
            {
                string temp = PQ.deQueue();
                instruction_list.add(temp + "is moving to the final approach");
             
                instruction_list.add(temp + " is landing!");
                isRunwayAvailable = false;
                
            }
            else time_counter = time_counter + time;
           
            if (time_counter > landing_time)
            {
                instruction_list.add(temp + " has been landed");
                time_counter = 0;
                isRunwayAvailable = true;
            } */
            
            
            
        }

        private void add_arrival_button_Click(object sender, EventArgs e)
        {
            flightNo++;
            // if the holding stack/ priority queue is not full
            if (!PQ.isFull())
            {
                // adding flight to the holding stack
                PQ.enQueue(flightNo.ToString(), E_level);
                string str2 = E_level.ToString();
                string str = flightNo.ToString();
                // generating instruction to be displayed
                string str3 = "F-" + str + " is added into the holding pattern! " + str2;
                // adding the instructions into the list
                instruction_list.add(str3);
            }     
        }


        private void add_departure_button_Click(object sender, EventArgs e)
        {
            // if runway is availabe then only
            if (!PQ.isEmpty())
            {
                string str = PQ.deQueue();
                instruction_list.add("F-" + str + " is cleared for landing! ");
            }
        }

        private void arrival_Emergency_levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            // getting the emergency level for selected choice
            E_level = arrival_Emergency_levels.SelectedIndex + 1;
        }

        // method to update the Arrival Time-table
        private void updateArrivalTable()
        {
            // if there arrivals exists
            if (!PQ.isEmpty())
            { 
            // copying the expected arrivals into a local array
            arrivalList = PQ.copyQueue();
            // setting the table texts
            int i = 0;
                foreach (string str in arrivalList)
                {
                    arrival_label_list[i].Text = str;
                    i++;
                }
            }
        }
    }
}
