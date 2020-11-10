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
            this.arrival_Emergency_levels = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Arrival_label = new System.Windows.Forms.Label();
            this.arrival_row1 = new System.Windows.Forms.Label();
            this.arrival_row2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.arr_time_row1 = new System.Windows.Forms.Label();
            this.arr_time_row2 = new System.Windows.Forms.Label();
            this.arrival_row3 = new System.Windows.Forms.Label();
            this.arr_time_row3 = new System.Windows.Forms.Label();
            this.arrival_row4 = new System.Windows.Forms.Label();
            this.arr_time_row4 = new System.Windows.Forms.Label();
            this.arrival_row5 = new System.Windows.Forms.Label();
            this.arr_time_row5 = new System.Windows.Forms.Label();
            this.arrival_row6 = new System.Windows.Forms.Label();
            this.arr_time_row6 = new System.Windows.Forms.Label();
            this.arrival_row7 = new System.Windows.Forms.Label();
            this.arr_time_row7 = new System.Windows.Forms.Label();
            this.arrival_row8 = new System.Windows.Forms.Label();
            this.arr_time_row8 = new System.Windows.Forms.Label();
            this.arrival_row9 = new System.Windows.Forms.Label();
            this.arr_time_row9 = new System.Windows.Forms.Label();
            this.Emergency_levels_label = new System.Windows.Forms.Label();
            this.simulateButton = new System.Windows.Forms.Button();
            this.instruction_txt = new System.Windows.Forms.TextBox();
            this.add_arrival_button = new System.Windows.Forms.Button();
            this.instruction_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.time_text.Location = new System.Drawing.Point(348, 50);
            this.time_text.Name = "time_text";
            this.time_text.Size = new System.Drawing.Size(72, 83);
            this.time_text.TabIndex = 2;
            this.time_text.Text = "0";
            // 
            // arrival_Emergency_levels
            // 
            this.arrival_Emergency_levels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_Emergency_levels.FormattingEnabled = true;
            this.arrival_Emergency_levels.ItemHeight = 29;
            this.arrival_Emergency_levels.Items.AddRange(new object[] {
            "Emergency Aircraft",
            "Normal Aircraft"});
            this.arrival_Emergency_levels.Location = new System.Drawing.Point(799, 217);
            this.arrival_Emergency_levels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arrival_Emergency_levels.Name = "arrival_Emergency_levels";
            this.arrival_Emergency_levels.Size = new System.Drawing.Size(437, 62);
            this.arrival_Emergency_levels.TabIndex = 1;
            this.arrival_Emergency_levels.SelectedIndexChanged += new System.EventHandler(this.arrival_Emergency_levels_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.4102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.5898F));
            this.tableLayoutPanel1.Controls.Add(this.Arrival_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.arr_time_row1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.arr_time_row2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.arr_time_row3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.arr_time_row4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.arr_time_row5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.arr_time_row6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.arr_time_row7, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.arr_time_row8, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.arrival_row9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.arr_time_row9, 3, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 162);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 549);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Arrival_label
            // 
            this.Arrival_label.AutoSize = true;
            this.Arrival_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Arrival_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrival_label.Location = new System.Drawing.Point(3, 0);
            this.Arrival_label.Name = "Arrival_label";
            this.Arrival_label.Size = new System.Drawing.Size(198, 54);
            this.Arrival_label.TabIndex = 0;
            this.Arrival_label.Text = "ARRIVALS";
            this.Arrival_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row1
            // 
            this.arrival_row1.AutoSize = true;
            this.arrival_row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_row1.Location = new System.Drawing.Point(3, 54);
            this.arrival_row1.Name = "arrival_row1";
            this.arrival_row1.Size = new System.Drawing.Size(198, 54);
            this.arrival_row1.TabIndex = 1;
            this.arrival_row1.Text = "----";
            this.arrival_row1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row2
            // 
            this.arrival_row2.AutoSize = true;
            this.arrival_row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_row2.Location = new System.Drawing.Point(3, 108);
            this.arrival_row2.Name = "arrival_row2";
            this.arrival_row2.Size = new System.Drawing.Size(198, 54);
            this.arrival_row2.TabIndex = 2;
            this.arrival_row2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row1
            // 
            this.arr_time_row1.AutoSize = true;
            this.arr_time_row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row1.Location = new System.Drawing.Point(407, 54);
            this.arr_time_row1.Name = "arr_time_row1";
            this.arr_time_row1.Size = new System.Drawing.Size(103, 54);
            this.arr_time_row1.TabIndex = 8;
            this.arr_time_row1.Text = "----";
            this.arr_time_row1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row2
            // 
            this.arr_time_row2.AutoSize = true;
            this.arr_time_row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row2.Location = new System.Drawing.Point(407, 108);
            this.arr_time_row2.Name = "arr_time_row2";
            this.arr_time_row2.Size = new System.Drawing.Size(103, 54);
            this.arr_time_row2.TabIndex = 10;
            this.arr_time_row2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row3
            // 
            this.arrival_row3.AutoSize = true;
            this.arrival_row3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_row3.Location = new System.Drawing.Point(3, 162);
            this.arrival_row3.Name = "arrival_row3";
            this.arrival_row3.Size = new System.Drawing.Size(198, 54);
            this.arrival_row3.TabIndex = 12;
            this.arrival_row3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row3
            // 
            this.arr_time_row3.AutoSize = true;
            this.arr_time_row3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row3.Location = new System.Drawing.Point(407, 162);
            this.arr_time_row3.Name = "arr_time_row3";
            this.arr_time_row3.Size = new System.Drawing.Size(103, 54);
            this.arr_time_row3.TabIndex = 13;
            this.arr_time_row3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row4
            // 
            this.arrival_row4.AutoSize = true;
            this.arrival_row4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_row4.Location = new System.Drawing.Point(3, 216);
            this.arrival_row4.Name = "arrival_row4";
            this.arrival_row4.Size = new System.Drawing.Size(198, 54);
            this.arrival_row4.TabIndex = 16;
            this.arrival_row4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row4
            // 
            this.arr_time_row4.AutoSize = true;
            this.arr_time_row4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row4.Location = new System.Drawing.Point(407, 216);
            this.arr_time_row4.Name = "arr_time_row4";
            this.arr_time_row4.Size = new System.Drawing.Size(103, 54);
            this.arr_time_row4.TabIndex = 17;
            this.arr_time_row4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row5
            // 
            this.arrival_row5.AutoSize = true;
            this.arrival_row5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_row5.Location = new System.Drawing.Point(3, 270);
            this.arrival_row5.Name = "arrival_row5";
            this.arrival_row5.Size = new System.Drawing.Size(198, 54);
            this.arrival_row5.TabIndex = 20;
            this.arrival_row5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row5
            // 
            this.arr_time_row5.AutoSize = true;
            this.arr_time_row5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row5.Location = new System.Drawing.Point(407, 270);
            this.arr_time_row5.Name = "arr_time_row5";
            this.arr_time_row5.Size = new System.Drawing.Size(103, 54);
            this.arr_time_row5.TabIndex = 21;
            this.arr_time_row5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row6
            // 
            this.arrival_row6.AutoSize = true;
            this.arrival_row6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_row6.Location = new System.Drawing.Point(3, 324);
            this.arrival_row6.Name = "arrival_row6";
            this.arrival_row6.Size = new System.Drawing.Size(198, 54);
            this.arrival_row6.TabIndex = 24;
            this.arrival_row6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row6
            // 
            this.arr_time_row6.AutoSize = true;
            this.arr_time_row6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row6.Location = new System.Drawing.Point(407, 324);
            this.arr_time_row6.Name = "arr_time_row6";
            this.arr_time_row6.Size = new System.Drawing.Size(103, 54);
            this.arr_time_row6.TabIndex = 25;
            this.arr_time_row6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row7
            // 
            this.arrival_row7.AutoSize = true;
            this.arrival_row7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_row7.Location = new System.Drawing.Point(3, 378);
            this.arrival_row7.Name = "arrival_row7";
            this.arrival_row7.Size = new System.Drawing.Size(198, 54);
            this.arrival_row7.TabIndex = 28;
            this.arrival_row7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row7
            // 
            this.arr_time_row7.AutoSize = true;
            this.arr_time_row7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row7.Location = new System.Drawing.Point(407, 378);
            this.arr_time_row7.Name = "arr_time_row7";
            this.arr_time_row7.Size = new System.Drawing.Size(103, 54);
            this.arr_time_row7.TabIndex = 29;
            this.arr_time_row7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row8
            // 
            this.arrival_row8.AutoSize = true;
            this.arrival_row8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_row8.Location = new System.Drawing.Point(3, 432);
            this.arrival_row8.Name = "arrival_row8";
            this.arrival_row8.Size = new System.Drawing.Size(198, 54);
            this.arrival_row8.TabIndex = 32;
            this.arrival_row8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row8
            // 
            this.arr_time_row8.AutoSize = true;
            this.arr_time_row8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row8.Location = new System.Drawing.Point(407, 432);
            this.arr_time_row8.Name = "arr_time_row8";
            this.arr_time_row8.Size = new System.Drawing.Size(103, 54);
            this.arr_time_row8.TabIndex = 33;
            this.arr_time_row8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrival_row9
            // 
            this.arrival_row9.AutoSize = true;
            this.arrival_row9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrival_row9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_row9.Location = new System.Drawing.Point(3, 486);
            this.arrival_row9.Name = "arrival_row9";
            this.arrival_row9.Size = new System.Drawing.Size(198, 63);
            this.arrival_row9.TabIndex = 36;
            this.arrival_row9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row9
            // 
            this.arr_time_row9.AutoSize = true;
            this.arr_time_row9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row9.Location = new System.Drawing.Point(407, 486);
            this.arr_time_row9.Name = "arr_time_row9";
            this.arr_time_row9.Size = new System.Drawing.Size(103, 63);
            this.arr_time_row9.TabIndex = 37;
            this.arr_time_row9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Emergency_levels_label
            // 
            this.Emergency_levels_label.AutoSize = true;
            this.Emergency_levels_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emergency_levels_label.Location = new System.Drawing.Point(759, 172);
            this.Emergency_levels_label.Name = "Emergency_levels_label";
            this.Emergency_levels_label.Size = new System.Drawing.Size(493, 36);
            this.Emergency_levels_label.TabIndex = 3;
            this.Emergency_levels_label.Text = "Select the Type of Aircraft for Arrival";
            // 
            // simulateButton
            // 
            this.simulateButton.BackColor = System.Drawing.Color.LawnGreen;
            this.simulateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.simulateButton.Location = new System.Drawing.Point(920, 30);
            this.simulateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(243, 101);
            this.simulateButton.TabIndex = 4;
            this.simulateButton.Text = "Simulate";
            this.simulateButton.UseVisualStyleBackColor = false;
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
            // 
            // instruction_txt
            // 
            this.instruction_txt.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_txt.Location = new System.Drawing.Point(534, 426);
            this.instruction_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instruction_txt.Multiline = true;
            this.instruction_txt.Name = "instruction_txt";
            this.instruction_txt.ReadOnly = true;
            this.instruction_txt.Size = new System.Drawing.Size(890, 282);
            this.instruction_txt.TabIndex = 4;
            // 
            // add_arrival_button
            // 
            this.add_arrival_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_arrival_button.Location = new System.Drawing.Point(880, 299);
            this.add_arrival_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_arrival_button.Name = "add_arrival_button";
            this.add_arrival_button.Size = new System.Drawing.Size(283, 65);
            this.add_arrival_button.TabIndex = 6;
            this.add_arrival_button.Text = "Add Arrival";
            this.add_arrival_button.UseVisualStyleBackColor = true;
            this.add_arrival_button.Click += new System.EventHandler(this.add_arrival_button_Click);
            // 
            // instruction_label
            // 
            this.instruction_label.AutoSize = true;
            this.instruction_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_label.Location = new System.Drawing.Point(779, 379);
            this.instruction_label.Name = "instruction_label";
            this.instruction_label.Size = new System.Drawing.Size(445, 36);
            this.instruction_label.TabIndex = 8;
            this.instruction_label.Text = "Instruction Conveyed to the Pilot";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(89, 50);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(247, 83);
            this.time_label.TabIndex = 9;
            this.time_label.Text = "Time :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1440, 722);
            this.Controls.Add(this.instruction_txt);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.instruction_label);
            this.Controls.Add(this.add_arrival_button);
            this.Controls.Add(this.simulateButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Emergency_levels_label);
            this.Controls.Add(this.arrival_Emergency_levels);
            this.Controls.Add(this.time_text);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Air Flight Control Simulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer simulate_timer;
        private System.Windows.Forms.Label time_text;
        private System.Windows.Forms.ListBox arrival_Emergency_levels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Arrival_label;
        private System.Windows.Forms.Label arrival_row1;
        private System.Windows.Forms.Label arrival_row2;
        private System.Windows.Forms.Label Emergency_levels_label;
        private System.Windows.Forms.Button simulateButton;
        private System.Windows.Forms.Button add_arrival_button;
        private System.Windows.Forms.Label instruction_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label arr_time_row1;
        private System.Windows.Forms.Label arr_time_row2;
        private System.Windows.Forms.Label arrival_row3;
        private System.Windows.Forms.Label arr_time_row3;
        private System.Windows.Forms.Label arrival_row4;
        private System.Windows.Forms.Label arr_time_row4;
        private System.Windows.Forms.Label arrival_row5;
        private System.Windows.Forms.Label arr_time_row5;
        private System.Windows.Forms.Label arrival_row6;
        private System.Windows.Forms.Label arr_time_row6;
        private System.Windows.Forms.Label arrival_row7;
        private System.Windows.Forms.Label arr_time_row7;
        private System.Windows.Forms.Label arrival_row8;
        private System.Windows.Forms.Label arr_time_row8;
        private System.Windows.Forms.Label arrival_row9;
        private System.Windows.Forms.Label arr_time_row9;
        private System.Windows.Forms.TextBox instruction_txt;
    }
}

