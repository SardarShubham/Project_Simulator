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
        bool isSimulatorON, isLanding, isRunwayAvailable;
        string instruct_temp;
        int flightType;
        const int holding_pattern_lim = 6;
        int nxtLanding_phase;
        int apprTime_start, landTime_start, curr_time;
        int timeForTable;       
        const int landing_time = 10 ; // 10 sec
        const int fileTo_finApproach = 8; // 8 sec        
        //int time_counter;
        Aircraft arrFlt, landFlt;
       // PriorityQueue PQ;
        Priority_queue holding;
        List<Label> arrival_label_list, arr_time_list, fuel_table, flt_type_table;
        Aircraft[] arrivalList;
        Circular_list<string> instruction_list;
        Circular_list<Aircraft> arrived_flights;
        string[] inst_list;
        public Form1()
        {
            InitializeComponent();
            isSimulatorON = false;
            time = 0;
            flightType = 0;
            instruct_temp = null;
            //time_counter = 0;
            isRunwayAvailable = true;
            arrivalList = new Aircraft[7];
            nxtLanding_phase = 1;
            isLanding = false;
            // object of priority queue 
            holding = new Priority_queue(holding_pattern_lim);
            // list of labels for arrivals table
            arrival_label_list = new List<Label>();
            // object of circular array
            instruction_list = new Circular_list<string>(6);
            inst_list = new string[6];
            arrived_flights = new Circular_list<Aircraft>(9);
            // adding the labels into the list of labels
            arrival_label_list = new List<Label>() { arrival_row1, arrival_row2, arrival_row3, arrival_row4, 
                arrival_row5, arrival_row6, arrival_row7, arrival_row8, arrival_row9 };
            arr_time_list = new List<Label>() { arr_time_row1, arr_time_row2, arr_time_row3, arr_time_row4,
                arr_time_row5, arr_time_row6, arr_time_row7, arr_time_row8, arr_time_row9 };
            flt_type_table = new List<Label>() { type_r1, type_r2, type_r3, 
                type_r4, type_r5, type_r6, type_r7, type_r8, type_r9 };
            fuel_table = new List<Label>() { fuel_r1, fuel_r2, fuel_r3, fuel_r4,
                fuel_r5, fuel_r6, fuel_r7, fuel_r8, fuel_r9 };
        }

        private void simulateButton_Click(object sender, EventArgs e)
        {
            // if sumulator is off 
            if (isSimulatorON == false)
            {
                simulateButton.BackColor = System.Drawing.Color.Red;
                simulateButton.Text = "Stop";
                simulate_timer.Start();
                isSimulatorON = true;
            }
            // if simulator is on
            else
            {
                simulateButton.BackColor = System.Drawing.Color.LawnGreen;
                simulateButton.Text = "Simulate";
                simulate_timer.Stop();
                isSimulatorON = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time + 1;
            time_text.Text = time.ToString();
            curr_time = time;
            // 1.at front of file, 2. at final approach, 3. on ground
            switch (nxtLanding_phase)
            {
                case 1: // at front of file
                    if (!holding.isEmpty())
                    {
                        landFlt = holding.deQueue();
                        isLanding = true;
                        instruction_list.add(">> " + landFlt.flight_name + " is cleared for landing ,move to the final approach");
                        apprTime_start = time;
                        nxtLanding_phase = 2;
                        timeForTable = curr_time;
                    }
                    break;
                case 2: // at final approach point
                     if ((curr_time - apprTime_start) > fileTo_finApproach)
                     {
                        if (isRunwayAvailable == true)
                        {
                            instruction_list.add(">> " + landFlt.flight_name + " is landing.");
                            isRunwayAvailable = false;
                            landTime_start = time;
                            nxtLanding_phase = 3;
                        }
                        else
                        {
                           instruction_list.add(">> " + landFlt.flight_name + " ,Abort landing! Return back to the holding pattern");
                            nxtLanding_phase = 1;
                        }
                     }
                    break;
                case 3: // after landing
                    if ((curr_time - landTime_start) > landing_time)
                    {
                        instruction_list.add(">> " + landFlt.flight_name + " is landed.");
                        arrived_flights.add(landFlt);
                        isRunwayAvailable = true;
                        isLanding = false;
                        nxtLanding_phase = 1;
                    }
                    break;
            }
            // for fuel updation on each time tick
            arrivalList = holding.copyQueue();
            for (int i=0; i<holding.getCount(); i++)
            {
                arrivalList[i].updataFuel();
                if (arrivalList[i].fuel_available < 120 && arrivalList[i].EmergencyChanged == false)
                {
                    holding.changePriority(arrivalList[i]);
                    arrivalList[i].EmergencyChanged = true;
                }
            }
            // displaying instructions and updating Arrival Table
            instruction_txt.Text = display_instruction();
            updateArrivalTable();
            
        }

        private string display_instruction()
        {
            int length = instruction_list.getCount();
            string temp = "";
            // copying the instruction and adding it together
            inst_list = instruction_list.CopyTo();
            for (int i= 0; i<length; i++)
            {
                temp = temp + inst_list[i] + "\r\n";
            }
            return temp;

        }
        private void add_arrival_button_Click(object sender, EventArgs e)
        {
            if (!isSimulatorON) return;
            // object of Aircraft class
            arrFlt = new Aircraft(flightType);
            // if the holding stack/ priority queue is not full
            if (!holding.isFull())
            {
                // adding flight to the holding stack
                holding.enQueue(arrFlt);
                // generating instruction to be displayed
                if (flightType == 1)
                {
                    instruct_temp = ">> Emergency Aircraft " + arrFlt.flight_name + ", move to the front of file approach! ";
                }
                else
                {                   
                    instruct_temp = ">> " + arrFlt.flight_name + ", move to the holding pattern.";
                }               
            }
            else
            {
                instruct_temp = ">> Holding pattern is becoming overcrowded! " + arrFlt.flight_name + " , redirect to another airport!";
            }
            timeForTable = curr_time;
            // adding the instructions into the list
            instruction_list.add(instruct_temp);
        }
       

        private void arrival_Emergency_levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            // getting the emergency level for selected choice
            flightType = arrival_Emergency_levels.SelectedIndex + 1;
        }

        // method to update the Arrival Time-table
        private void updateArrivalTable()
        {
            int l1, l2, i, j, temp1;
            // for arrived flights
            l1 = arrived_flights.getCount();
            // current holding pattern flights
            l2 = holding.getCount();
            int temp = 9 - l2;  // rows available for arrived
            Aircraft[] list = arrived_flights.CopyTo();
            if (isLanding) temp = temp - 1; // rows decreaded by 1;
            if (temp > l1) temp1 = l1;  // if arrived flights are less than available table rows
            else temp1 = temp;
            // adding arrived flights information
            for (i=0; i<temp1; i++) 
            {
                arrival_label_list[i].Text = list[i].flight_name;              
                arr_time_list[i].Text = "Arrived";
                flt_type_table[i].Text = list[i].flt_type;
                fuel_table[i].Text = list[i].fuel_available.ToString();
            }      
            // if Landing is occuring, adding it's information
            if (isLanding)
            {
                arrival_label_list[i].Text = landFlt.flight_name;
                arr_time_list[i].Text = "Landing";
                flt_type_table[i].Text = landFlt.flt_type;
                fuel_table[i].Text = landFlt.fuel_available.ToString();
                i++;
            }
            // if there arrivals exists
            if (!holding.isEmpty())
            { 
                // copying the expected arrivals into a local array
                arrivalList = holding.copyQueue();
                // setting the table texts
                for (j = 0; j<l2; j++)
                {
                    arrival_label_list[i].Text = arrivalList[j].flight_name;
                    arr_time_list[i].Text = (timeForTable + (j+1)*18).ToString() + " sec";
                    flt_type_table[i].Text = arrivalList[j].flt_type;
                    fuel_table[i].Text = arrivalList[j].fuel_available.ToString();
                    i++;
                }
                // the empty rows are set to null
                while (i < 9)
                {
                    arrival_label_list[i].Text = "----";
                    arr_time_list[i].Text = "----";
                    flt_type_table[i].Text = "----";
                    fuel_table[i].Text = "----";
                    i++;
                }
            }
        }
    }
}
