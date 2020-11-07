namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.simulate_timer = new System.Windows.Forms.Timer(this.components);
            this.time_text = new System.Windows.Forms.Label();
            this.instruction_text = new System.Windows.Forms.Label();
            this.list_Emergency_levels = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Arrival_label = new System.Windows.Forms.Label();
            this.departure_row1 = new System.Windows.Forms.Label();
            this.departure_row2 = new System.Windows.Forms.Label();
            this.arrival_row1 = new System.Windows.Forms.Label();
            this.departure_label = new System.Windows.Forms.Label();
            this.arrival_row2 = new System.Windows.Forms.Label();
            this.Emergency_levels_label = new System.Windows.Forms.Label();
            this.simulateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_arrival_button = new System.Windows.Forms.Button();
            this.add_departure_button = new System.Windows.Forms.Button();
            this.instruction_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.arrival_time_row1 = new System.Windows.Forms.Label();
            this.departure_time_row1 = new System.Windows.Forms.Label();
            this.arrival_time_row2 = new System.Windows.Forms.Label();
            this.departure_time_row2 = new System.Windows.Forms.Label();
            this.arrival_row3 = new System.Windows.Forms.Label();
            this.arrival_time_row3 = new System.Windows.Forms.Label();
            this.departure_row3 = new System.Windows.Forms.Label();
            this.departure_time_row3 = new System.Windows.Forms.Label();
            this.arrival_row4 = new System.Windows.Forms.Label();
            this.arrival_time_row4 = new System.Windows.Forms.Label();
            this.departure_row4 = new System.Windows.Forms.Label();
            this.departure_time_row4 = new System.Windows.Forms.Label();
            this.arrival_row5 = new System.Windows.Forms.Label();
            this.arrival_time_row5 = new System.Windows.Forms.Label();
            this.departure_row5 = new System.Windows.Forms.Label();
            this.departure_time_row5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulate_timer
            // 
            this.simulate_timer.Interval = 1000;
            this.simulate_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_text
            // 
            this.time_text.AutoSize = true;
            this.time_text.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_text.Location = new System.Drawing.Point(484, 25);
            this.time_text.Name = "time_text";
            this.time_text.Size = new System.Drawing.Size(72, 83);
            this.time_text.TabIndex = 2;
            this.time_text.Text = "0";
            // 
            // instruction_text
            // 
            this.instruction_text.AutoSize = true;
            this.instruction_text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.instruction_text.Location = new System.Drawing.Point(0, 76);
            this.instruction_text.Name = "instruction_text";
            this.instruction_text.Size = new System.Drawing.Size(28, 17);
            this.instruction_text.TabIndex = 3;
            this.instruction_text.Text = "----";
            this.instruction_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_Emergency_levels
            // 
            this.list_Emergency_levels.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.list_Emergency_levels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Emergency_levels.FormattingEnabled = true;
            this.list_Emergency_levels.ItemHeight = 20;
            this.list_Emergency_levels.Items.AddRange(new object[] {
            "Emergency Level 1 : (Critical Patient / Transplant Organ)",
            "Emergency Level 2 : (Hijacked Plane)",
            "Emergency Level 3 : (Critical Fuel, Lightning Strike)",
            "Emergency Level 4 : (No Fuel Gliding Plane, Damaged)",
            "Emergency Level 5 : (Other Greater Dynamic Spotted Emergency"});
            this.list_Emergency_levels.Location = new System.Drawing.Point(581, 403);
            this.list_Emergency_levels.Name = "list_Emergency_levels";
            this.list_Emergency_levels.Size = new System.Drawing.Size(463, 164);
            this.list_Emergency_levels.TabIndex = 1;
            this.list_Emergency_levels.SelectedIndexChanged += new System.EventHandler(this.list_Emergency_levels_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Arrival_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.departure_row1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.departure_row2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.departure_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.arrival_time_row1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.departure_time_row1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrival_time_row2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.departure_time_row2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.arrival_time_row3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.departure_row3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.departure_time_row3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.arrival_time_row4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.departure_row4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.departure_time_row4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.arrival_time_row5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.departure_row5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.departure_time_row5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label25, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label26, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label27, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label28, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label29, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label30, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label31, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label32, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label33, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label34, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label35, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label36, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label37, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label38, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label39, 3, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 295);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Arrival_label
            // 
            this.Arrival_label.AutoSize = true;
            this.Arrival_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Arrival_label.Location = new System.Drawing.Point(3, 0);
            this.Arrival_label.Name = "Arrival_label";
            this.Arrival_label.Size = new System.Drawing.Size(132, 45);
            this.Arrival_label.TabIndex = 0;
            this.Arrival_label.Text = "ARRIVALS";
            // 
            // departure_row1
            // 
            this.departure_row1.AutoSize = true;
            this.departure_row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_row1.Location = new System.Drawing.Point(233, 45);
            this.departure_row1.Name = "departure_row1";
            this.departure_row1.Size = new System.Drawing.Size(132, 45);
            this.departure_row1.TabIndex = 3;
            this.departure_row1.Text = "----";
            this.departure_row1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_row2
            // 
            this.departure_row2.AutoSize = true;
            this.departure_row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_row2.Location = new System.Drawing.Point(233, 90);
            this.departure_row2.Name = "departure_row2";
            this.departure_row2.Size = new System.Drawing.Size(132, 45);
            this.departure_row2.TabIndex = 5;
            this.departure_row2.Text = "----";
            this.departure_row2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row1
            // 
            this.arrival_row1.AutoSize = true;
            this.arrival_row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row1.Location = new System.Drawing.Point(3, 45);
            this.arrival_row1.Name = "arrival_row1";
            this.arrival_row1.Size = new System.Drawing.Size(132, 45);
            this.arrival_row1.TabIndex = 1;
            this.arrival_row1.Text = "----";
            this.arrival_row1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_label
            // 
            this.departure_label.AutoSize = true;
            this.departure_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_label.Location = new System.Drawing.Point(233, 0);
            this.departure_label.Name = "departure_label";
            this.departure_label.Size = new System.Drawing.Size(132, 45);
            this.departure_label.TabIndex = 4;
            this.departure_label.Text = "DEPARTURES";
            // 
            // arrival_row2
            // 
            this.arrival_row2.AutoSize = true;
            this.arrival_row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row2.Location = new System.Drawing.Point(3, 90);
            this.arrival_row2.Name = "arrival_row2";
            this.arrival_row2.Size = new System.Drawing.Size(132, 45);
            this.arrival_row2.TabIndex = 2;
            this.arrival_row2.Text = "----";
            this.arrival_row2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.arrival_row2.Click += new System.EventHandler(this.label3_Click);
            // 
            // Emergency_levels_label
            // 
            this.Emergency_levels_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Emergency_levels_label.AutoSize = true;
            this.Emergency_levels_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emergency_levels_label.Location = new System.Drawing.Point(586, 353);
            this.Emergency_levels_label.Name = "Emergency_levels_label";
            this.Emergency_levels_label.Size = new System.Drawing.Size(340, 32);
            this.Emergency_levels_label.TabIndex = 3;
            this.Emergency_levels_label.Text = "Select the Type of Aircraft";
            // 
            // simulateButton
            // 
            this.simulateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simulateButton.BackColor = System.Drawing.SystemColors.Info;
            this.simulateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.simulateButton.Location = new System.Drawing.Point(733, 184);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(216, 90);
            this.simulateButton.TabIndex = 4;
            this.simulateButton.Text = "Simulate";
            this.simulateButton.UseVisualStyleBackColor = false;
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.instruction_text);
            this.panel1.Location = new System.Drawing.Point(12, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 93);
            this.panel1.TabIndex = 5;
            // 
            // add_arrival_button
            // 
            this.add_arrival_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_arrival_button.Location = new System.Drawing.Point(548, 596);
            this.add_arrival_button.Name = "add_arrival_button";
            this.add_arrival_button.Size = new System.Drawing.Size(145, 52);
            this.add_arrival_button.TabIndex = 6;
            this.add_arrival_button.Text = "Add Arrival";
            this.add_arrival_button.UseVisualStyleBackColor = true;
            this.add_arrival_button.Click += new System.EventHandler(this.add_arrival_button_Click);
            // 
            // add_departure_button
            // 
            this.add_departure_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_departure_button.Location = new System.Drawing.Point(799, 596);
            this.add_departure_button.Name = "add_departure_button";
            this.add_departure_button.Size = new System.Drawing.Size(127, 52);
            this.add_departure_button.TabIndex = 7;
            this.add_departure_button.Text = "Add Departure";
            this.add_departure_button.UseVisualStyleBackColor = true;
            this.add_departure_button.Click += new System.EventHandler(this.add_departure_button_Click);
            // 
            // instruction_label
            // 
            this.instruction_label.AutoSize = true;
            this.instruction_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_label.Location = new System.Drawing.Point(6, 142);
            this.instruction_label.Name = "instruction_label";
            this.instruction_label.Size = new System.Drawing.Size(423, 32);
            this.instruction_label.TabIndex = 8;
            this.instruction_label.Text = "Instruction Conveyed to the Pilot";
            // 
            // time_label
            // 
            this.time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(154, 25);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(299, 74);
            this.time_label.TabIndex = 9;
            this.time_label.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Time";
            // 
            // arrival_time_row1
            // 
            this.arrival_time_row1.AutoSize = true;
            this.arrival_time_row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_time_row1.Location = new System.Drawing.Point(141, 45);
            this.arrival_time_row1.Name = "arrival_time_row1";
            this.arrival_time_row1.Size = new System.Drawing.Size(86, 45);
            this.arrival_time_row1.TabIndex = 8;
            this.arrival_time_row1.Text = "----";
            this.arrival_time_row1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_time_row1
            // 
            this.departure_time_row1.AutoSize = true;
            this.departure_time_row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_time_row1.Location = new System.Drawing.Point(371, 45);
            this.departure_time_row1.Name = "departure_time_row1";
            this.departure_time_row1.Size = new System.Drawing.Size(86, 45);
            this.departure_time_row1.TabIndex = 9;
            this.departure_time_row1.Text = "----";
            this.departure_time_row1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_time_row2
            // 
            this.arrival_time_row2.AutoSize = true;
            this.arrival_time_row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_time_row2.Location = new System.Drawing.Point(141, 90);
            this.arrival_time_row2.Name = "arrival_time_row2";
            this.arrival_time_row2.Size = new System.Drawing.Size(86, 45);
            this.arrival_time_row2.TabIndex = 10;
            this.arrival_time_row2.Text = "----";
            this.arrival_time_row2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_time_row2
            // 
            this.departure_time_row2.AutoSize = true;
            this.departure_time_row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_time_row2.Location = new System.Drawing.Point(371, 90);
            this.departure_time_row2.Name = "departure_time_row2";
            this.departure_time_row2.Size = new System.Drawing.Size(86, 45);
            this.departure_time_row2.TabIndex = 11;
            this.departure_time_row2.Text = "----";
            this.departure_time_row2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row3
            // 
            this.arrival_row3.AutoSize = true;
            this.arrival_row3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row3.Location = new System.Drawing.Point(3, 135);
            this.arrival_row3.Name = "arrival_row3";
            this.arrival_row3.Size = new System.Drawing.Size(132, 45);
            this.arrival_row3.TabIndex = 12;
            this.arrival_row3.Text = "----";
            this.arrival_row3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_time_row3
            // 
            this.arrival_time_row3.AutoSize = true;
            this.arrival_time_row3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_time_row3.Location = new System.Drawing.Point(141, 135);
            this.arrival_time_row3.Name = "arrival_time_row3";
            this.arrival_time_row3.Size = new System.Drawing.Size(86, 45);
            this.arrival_time_row3.TabIndex = 13;
            this.arrival_time_row3.Text = "----";
            this.arrival_time_row3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_row3
            // 
            this.departure_row3.AutoSize = true;
            this.departure_row3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_row3.Location = new System.Drawing.Point(233, 135);
            this.departure_row3.Name = "departure_row3";
            this.departure_row3.Size = new System.Drawing.Size(132, 45);
            this.departure_row3.TabIndex = 14;
            this.departure_row3.Text = "----";
            this.departure_row3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_time_row3
            // 
            this.departure_time_row3.AutoSize = true;
            this.departure_time_row3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_time_row3.Location = new System.Drawing.Point(371, 135);
            this.departure_time_row3.Name = "departure_time_row3";
            this.departure_time_row3.Size = new System.Drawing.Size(86, 45);
            this.departure_time_row3.TabIndex = 15;
            this.departure_time_row3.Text = "----";
            this.departure_time_row3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row4
            // 
            this.arrival_row4.AutoSize = true;
            this.arrival_row4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row4.Location = new System.Drawing.Point(3, 180);
            this.arrival_row4.Name = "arrival_row4";
            this.arrival_row4.Size = new System.Drawing.Size(132, 45);
            this.arrival_row4.TabIndex = 16;
            this.arrival_row4.Text = "----";
            this.arrival_row4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_time_row4
            // 
            this.arrival_time_row4.AutoSize = true;
            this.arrival_time_row4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_time_row4.Location = new System.Drawing.Point(141, 180);
            this.arrival_time_row4.Name = "arrival_time_row4";
            this.arrival_time_row4.Size = new System.Drawing.Size(86, 45);
            this.arrival_time_row4.TabIndex = 17;
            this.arrival_time_row4.Text = "----";
            this.arrival_time_row4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_row4
            // 
            this.departure_row4.AutoSize = true;
            this.departure_row4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_row4.Location = new System.Drawing.Point(233, 180);
            this.departure_row4.Name = "departure_row4";
            this.departure_row4.Size = new System.Drawing.Size(132, 45);
            this.departure_row4.TabIndex = 18;
            this.departure_row4.Text = "----";
            this.departure_row4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_time_row4
            // 
            this.departure_time_row4.AutoSize = true;
            this.departure_time_row4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_time_row4.Location = new System.Drawing.Point(371, 180);
            this.departure_time_row4.Name = "departure_time_row4";
            this.departure_time_row4.Size = new System.Drawing.Size(86, 45);
            this.departure_time_row4.TabIndex = 19;
            this.departure_time_row4.Text = "----";
            this.departure_time_row4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row5
            // 
            this.arrival_row5.AutoSize = true;
            this.arrival_row5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row5.Location = new System.Drawing.Point(3, 225);
            this.arrival_row5.Name = "arrival_row5";
            this.arrival_row5.Size = new System.Drawing.Size(132, 45);
            this.arrival_row5.TabIndex = 20;
            this.arrival_row5.Text = "----";
            this.arrival_row5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_time_row5
            // 
            this.arrival_time_row5.AutoSize = true;
            this.arrival_time_row5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_time_row5.Location = new System.Drawing.Point(141, 225);
            this.arrival_time_row5.Name = "arrival_time_row5";
            this.arrival_time_row5.Size = new System.Drawing.Size(86, 45);
            this.arrival_time_row5.TabIndex = 21;
            this.arrival_time_row5.Text = "----";
            this.arrival_time_row5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_row5
            // 
            this.departure_row5.AutoSize = true;
            this.departure_row5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_row5.Location = new System.Drawing.Point(233, 225);
            this.departure_row5.Name = "departure_row5";
            this.departure_row5.Size = new System.Drawing.Size(132, 45);
            this.departure_row5.TabIndex = 22;
            this.departure_row5.Text = "----";
            this.departure_row5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_time_row5
            // 
            this.departure_time_row5.AutoSize = true;
            this.departure_time_row5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departure_time_row5.Location = new System.Drawing.Point(371, 225);
            this.departure_time_row5.Name = "departure_time_row5";
            this.departure_time_row5.Size = new System.Drawing.Size(86, 45);
            this.departure_time_row5.TabIndex = 23;
            this.departure_time_row5.Text = "----";
            this.departure_time_row5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(3, 270);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(132, 45);
            this.label24.TabIndex = 24;
            this.label24.Text = "label24";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(141, 270);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 17);
            this.label25.TabIndex = 25;
            this.label25.Text = "label25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(233, 270);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 17);
            this.label26.TabIndex = 26;
            this.label26.Text = "label26";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(371, 270);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 17);
            this.label27.TabIndex = 27;
            this.label27.Text = "label27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(3, 315);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(132, 45);
            this.label28.TabIndex = 28;
            this.label28.Text = "label28";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(141, 315);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(54, 17);
            this.label29.TabIndex = 29;
            this.label29.Text = "label29";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(233, 315);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 17);
            this.label30.TabIndex = 30;
            this.label30.Text = "label30";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(371, 315);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 17);
            this.label31.TabIndex = 31;
            this.label31.Text = "label31";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 360);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(54, 17);
            this.label32.TabIndex = 32;
            this.label32.Text = "label32";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(141, 360);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 17);
            this.label33.TabIndex = 33;
            this.label33.Text = "label33";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(233, 360);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(54, 17);
            this.label34.TabIndex = 34;
            this.label34.Text = "label34";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(371, 360);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(54, 17);
            this.label35.TabIndex = 35;
            this.label35.Text = "label35";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 405);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(54, 17);
            this.label36.TabIndex = 36;
            this.label36.Text = "label36";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(141, 405);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(54, 17);
            this.label37.TabIndex = 37;
            this.label37.Text = "label37";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(233, 405);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(54, 17);
            this.label38.TabIndex = 38;
            this.label38.Text = "label38";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(371, 405);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(54, 17);
            this.label39.TabIndex = 39;
            this.label39.Text = "label39";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1056, 757);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.instruction_label);
            this.Controls.Add(this.add_departure_button);
            this.Controls.Add(this.add_arrival_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simulateButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Emergency_levels_label);
            this.Controls.Add(this.list_Emergency_levels);
            this.Controls.Add(this.time_text);
            this.Name = "Form1";
            this.Text = "Air Flight Control Simulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer simulate_timer;
        private System.Windows.Forms.Label time_text;
        private System.Windows.Forms.Label instruction_text;
        private System.Windows.Forms.ListBox list_Emergency_levels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Arrival_label;
        private System.Windows.Forms.Label departure_row1;
        private System.Windows.Forms.Label departure_row2;
        private System.Windows.Forms.Label arrival_row1;
        private System.Windows.Forms.Label departure_label;
        private System.Windows.Forms.Label arrival_row2;
        private System.Windows.Forms.Label Emergency_levels_label;
        private System.Windows.Forms.Button simulateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_arrival_button;
        private System.Windows.Forms.Button add_departure_button;
        private System.Windows.Forms.Label instruction_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label arrival_time_row1;
        private System.Windows.Forms.Label departure_time_row1;
        private System.Windows.Forms.Label arrival_time_row2;
        private System.Windows.Forms.Label departure_time_row2;
        private System.Windows.Forms.Label arrival_row3;
        private System.Windows.Forms.Label arrival_time_row3;
        private System.Windows.Forms.Label departure_row3;
        private System.Windows.Forms.Label departure_time_row3;
        private System.Windows.Forms.Label arrival_row4;
        private System.Windows.Forms.Label arrival_time_row4;
        private System.Windows.Forms.Label departure_row4;
        private System.Windows.Forms.Label departure_time_row4;
        private System.Windows.Forms.Label arrival_row5;
        private System.Windows.Forms.Label arrival_time_row5;
        private System.Windows.Forms.Label departure_row5;
        private System.Windows.Forms.Label departure_time_row5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
    }
}

