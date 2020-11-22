using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    public partial class MainForm : Form
    {
        public static Double Timer_Time = 0;

        public static HoldingStackDisplay HSD = new HoldingStackDisplay();

        public static List<Airport> Airports = new List<Airport>();

        public MainForm()
        {
            InitializeComponent();

            Airports.Add(new Airport());
            btnNewAirport.Enabled = false;
            btnNewRunaway.Enabled = false;
            HideSubMenu();

            if (HSD.Hold_stack.Columns.Count == 0) HSD.InitializeDataTable();
        }


        private void HideSubMenu()
        {
            panelNewSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel ShowPanel)
        {
            HideSubMenu();
            ShowPanel.Visible = true;
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            //if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void btnAddNew_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(panelNewSubMenu);
        }
        #region Add New Element
        private void btnNewAircraft_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new NewAircraft());
        }

        private void btnNewRunaway_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnNewAirport_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion


        private void btnViewHoldingStack_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(HSD);
        }

        private void btnAnalyticalHistory_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void SimulateTimer_Tick(object sender, EventArgs e)
        {
            labelTimeSec.Text = (Timer_Time++).ToString() + " s";

            int CompletedOnes = 0;
            foreach (Aircraft aircraft in Airports[0].Holding_Stacks[0].AirPlanes) if (aircraft.Activity_Status == 2) CompletedOnes++;
            if (CompletedOnes == Airports[0].Holding_Stacks[0].AirPlanes.Count) return;

            if (Airports[0].Holding_Stacks[0].AirPlanes.Count != 0)
            {

                if (Airports[0].Holding_Stacks[0].AirPlanes[0].Activity_Status == 0)
                {
                    Airports[0].Holding_Stacks[0].AirPlanes[0].Activity_Status = 1;
                    Airports[0].Holding_Stacks[0].AirPlanes[0].StartTime = Timer_Time;
                }

                else if (Airports[0].Holding_Stacks[0].AirPlanes[0].StartTime + 6 < Timer_Time)// && Airports[0].Holding_Stacks[0].AirPlanes[0].Activity_Status==2)
                {
                    Airports[0].Holding_Stacks[0].AirPlanes[0].Activity_Status = 2;
                    Airports[0].Holding_Stacks[0].AirPlanes.Add(Airports[0].Holding_Stacks[0].AirPlanes[0]);
                    Airports[0].Holding_Stacks[0].AirPlanes.RemoveAt(0);
                    Airports[0].Holding_Stacks[0].DeQueue();
                    //Airports[0].Holding_Stacks[0].DeQueue();
                }

                HSD.UpdateDataTable();
            }
        }

        private void btnSimulate_Stop_Click(object sender, EventArgs e)
        {
            if (SimulateTimer.Enabled == false)
            {
                SimulateTimer.Enabled = true;
                btnSimulate_Stop.Text = "STOP";
                btnSimulate_Stop.BackColor = Color.IndianRed;

                if(Airports[0].Holding_Stacks[0].DynamicCount!=0)
                {
                    Airports[0].Holding_Stacks[0].AirPlanes[0].UpdateActivityStatus(1);
                    HSD.UpdateDataTable();
                }

                //btnStop.Visible = true;
            }

            else
            {
                SimulateTimer.Enabled = false;
                btnSimulate_Stop.Text = "SIMULATE";
                //Timer_Time = 0;
                btnSimulate_Stop.BackColor = Color.Black;
                btnStop.Visible = false;
            }
        }
        /*
        private void btnStop_Click(object sender, EventArgs e)
        {
            SimulateTimer.Enabled = false;
            Timer_Time = 0;
            btnSimulate_Stop_Click(sender, e);
        }*/
    }
}

