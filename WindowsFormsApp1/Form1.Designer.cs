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
            this.type_r1 = new System.Windows.Forms.Label();
            this.type_r2 = new System.Windows.Forms.Label();
            this.type_r3 = new System.Windows.Forms.Label();
            this.type_r4 = new System.Windows.Forms.Label();
            this.type_r5 = new System.Windows.Forms.Label();
            this.type_r6 = new System.Windows.Forms.Label();
            this.type_r7 = new System.Windows.Forms.Label();
            this.type_r8 = new System.Windows.Forms.Label();
            this.type_r9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fuel_r1 = new System.Windows.Forms.Label();
            this.fuel_r2 = new System.Windows.Forms.Label();
            this.fuel_r3 = new System.Windows.Forms.Label();
            this.fuel_r4 = new System.Windows.Forms.Label();
            this.fuel_r5 = new System.Windows.Forms.Label();
            this.fuel_r6 = new System.Windows.Forms.Label();
            this.fuel_r7 = new System.Windows.Forms.Label();
            this.fuel_r8 = new System.Windows.Forms.Label();
            this.fuel_r9 = new System.Windows.Forms.Label();
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
            this.arrival_Emergency_levels.Location = new System.Drawing.Point(864, 244);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
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
            this.tableLayoutPanel1.Controls.Add(this.type_r1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.type_r2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.type_r3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.type_r4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.type_r5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.type_r6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.type_r7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.type_r8, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.type_r9, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.fuel_r1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fuel_r2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.fuel_r3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.fuel_r4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.fuel_r5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.fuel_r6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.fuel_r7, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.fuel_r8, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.fuel_r9, 2, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 252);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 549);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Arrival_label
            // 
            this.Arrival_label.AutoSize = true;
            this.Arrival_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Arrival_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrival_label.Location = new System.Drawing.Point(3, 0);
            this.Arrival_label.Name = "Arrival_label";
            this.Arrival_label.Size = new System.Drawing.Size(209, 54);
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
            this.arrival_row1.Size = new System.Drawing.Size(209, 54);
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
            this.arrival_row2.Size = new System.Drawing.Size(209, 54);
            this.arrival_row2.TabIndex = 2;
            this.arrival_row2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row1
            // 
            this.arr_time_row1.AutoSize = true;
            this.arr_time_row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row1.Location = new System.Drawing.Point(472, 54);
            this.arr_time_row1.Name = "arr_time_row1";
            this.arr_time_row1.Size = new System.Drawing.Size(108, 54);
            this.arr_time_row1.TabIndex = 8;
            this.arr_time_row1.Text = "----";
            this.arr_time_row1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row2
            // 
            this.arr_time_row2.AutoSize = true;
            this.arr_time_row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row2.Location = new System.Drawing.Point(472, 108);
            this.arr_time_row2.Name = "arr_time_row2";
            this.arr_time_row2.Size = new System.Drawing.Size(108, 54);
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
            this.arrival_row3.Size = new System.Drawing.Size(209, 54);
            this.arrival_row3.TabIndex = 12;
            this.arrival_row3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row3
            // 
            this.arr_time_row3.AutoSize = true;
            this.arr_time_row3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row3.Location = new System.Drawing.Point(472, 162);
            this.arr_time_row3.Name = "arr_time_row3";
            this.arr_time_row3.Size = new System.Drawing.Size(108, 54);
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
            this.arrival_row4.Size = new System.Drawing.Size(209, 54);
            this.arrival_row4.TabIndex = 16;
            this.arrival_row4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row4
            // 
            this.arr_time_row4.AutoSize = true;
            this.arr_time_row4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row4.Location = new System.Drawing.Point(472, 216);
            this.arr_time_row4.Name = "arr_time_row4";
            this.arr_time_row4.Size = new System.Drawing.Size(108, 54);
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
            this.arrival_row5.Size = new System.Drawing.Size(209, 54);
            this.arrival_row5.TabIndex = 20;
            this.arrival_row5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row5
            // 
            this.arr_time_row5.AutoSize = true;
            this.arr_time_row5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row5.Location = new System.Drawing.Point(472, 270);
            this.arr_time_row5.Name = "arr_time_row5";
            this.arr_time_row5.Size = new System.Drawing.Size(108, 54);
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
            this.arrival_row6.Size = new System.Drawing.Size(209, 54);
            this.arrival_row6.TabIndex = 24;
            this.arrival_row6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row6
            // 
            this.arr_time_row6.AutoSize = true;
            this.arr_time_row6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row6.Location = new System.Drawing.Point(472, 324);
            this.arr_time_row6.Name = "arr_time_row6";
            this.arr_time_row6.Size = new System.Drawing.Size(108, 54);
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
            this.arrival_row7.Size = new System.Drawing.Size(209, 54);
            this.arrival_row7.TabIndex = 28;
            this.arrival_row7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row7
            // 
            this.arr_time_row7.AutoSize = true;
            this.arr_time_row7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row7.Location = new System.Drawing.Point(472, 378);
            this.arr_time_row7.Name = "arr_time_row7";
            this.arr_time_row7.Size = new System.Drawing.Size(108, 54);
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
            this.arrival_row8.Size = new System.Drawing.Size(209, 54);
            this.arrival_row8.TabIndex = 32;
            this.arrival_row8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row8
            // 
            this.arr_time_row8.AutoSize = true;
            this.arr_time_row8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row8.Location = new System.Drawing.Point(472, 432);
            this.arr_time_row8.Name = "arr_time_row8";
            this.arr_time_row8.Size = new System.Drawing.Size(108, 54);
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
            this.arrival_row9.Size = new System.Drawing.Size(209, 63);
            this.arrival_row9.TabIndex = 36;
            this.arrival_row9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arr_time_row9
            // 
            this.arr_time_row9.AutoSize = true;
            this.arr_time_row9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arr_time_row9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time_row9.Location = new System.Drawing.Point(472, 486);
            this.arr_time_row9.Name = "arr_time_row9";
            this.arr_time_row9.Size = new System.Drawing.Size(108, 63);
            this.arr_time_row9.TabIndex = 37;
            this.arr_time_row9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Emergency_levels_label
            // 
            this.Emergency_levels_label.AutoSize = true;
            this.Emergency_levels_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emergency_levels_label.Location = new System.Drawing.Point(826, 190);
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
            this.simulateButton.Location = new System.Drawing.Point(953, 32);
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
            this.instruction_txt.Location = new System.Drawing.Point(613, 468);
            this.instruction_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instruction_txt.Multiline = true;
            this.instruction_txt.Name = "instruction_txt";
            this.instruction_txt.ReadOnly = true;
            this.instruction_txt.Size = new System.Drawing.Size(890, 333);
            this.instruction_txt.TabIndex = 4;
            // 
            // add_arrival_button
            // 
            this.add_arrival_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_arrival_button.Location = new System.Drawing.Point(953, 317);
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
            this.instruction_label.Location = new System.Drawing.Point(874, 421);
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
            // type_r1
            // 
            this.type_r1.AutoSize = true;
            this.type_r1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_r1.Location = new System.Drawing.Point(218, 54);
            this.type_r1.Name = "type_r1";
            this.type_r1.Size = new System.Drawing.Size(148, 54);
            this.type_r1.TabIndex = 38;
            this.type_r1.Text = "----";
            this.type_r1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_r2
            // 
            this.type_r2.AutoSize = true;
            this.type_r2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_r2.Location = new System.Drawing.Point(218, 108);
            this.type_r2.Name = "type_r2";
            this.type_r2.Size = new System.Drawing.Size(148, 54);
            this.type_r2.TabIndex = 39;
            this.type_r2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_r3
            // 
            this.type_r3.AutoSize = true;
            this.type_r3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_r3.Location = new System.Drawing.Point(218, 162);
            this.type_r3.Name = "type_r3";
            this.type_r3.Size = new System.Drawing.Size(148, 54);
            this.type_r3.TabIndex = 40;
            this.type_r3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_r4
            // 
            this.type_r4.AutoSize = true;
            this.type_r4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_r4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_r4.Location = new System.Drawing.Point(218, 216);
            this.type_r4.Name = "type_r4";
            this.type_r4.Size = new System.Drawing.Size(148, 54);
            this.type_r4.TabIndex = 41;
            this.type_r4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_r5
            // 
            this.type_r5.AutoSize = true;
            this.type_r5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_r5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_r5.Location = new System.Drawing.Point(218, 270);
            this.type_r5.Name = "type_r5";
            this.type_r5.Size = new System.Drawing.Size(148, 54);
            this.type_r5.TabIndex = 42;
            this.type_r5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_r6
            // 
            this.type_r6.AutoSize = true;
            this.type_r6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_r6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_r6.Location = new System.Drawing.Point(218, 324);
            this.type_r6.Name = "type_r6";
            this.type_r6.Size = new System.Drawing.Size(148, 54);
            this.type_r6.TabIndex = 43;
            this.type_r6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_r7
            // 
            this.type_r7.AutoSize = true;
            this.type_r7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_r7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_r7.Location = new System.Drawing.Point(218, 378);
            this.type_r7.Name = "type_r7";
            this.type_r7.Size = new System.Drawing.Size(148, 54);
            this.type_r7.TabIndex = 44;
            this.type_r7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_r8
            // 
            this.type_r8.AutoSize = true;
            this.type_r8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_r8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_r8.Location = new System.Drawing.Point(218, 432);
            this.type_r8.Name = "type_r8";
            this.type_r8.Size = new System.Drawing.Size(148, 54);
            this.type_r8.TabIndex = 45;
            this.type_r8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_r9
            // 
            this.type_r9.AutoSize = true;
            this.type_r9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_r9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_r9.Location = new System.Drawing.Point(218, 486);
            this.type_r9.Name = "type_r9";
            this.type_r9.Size = new System.Drawing.Size(148, 63);
            this.type_r9.TabIndex = 46;
            this.type_r9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 54);
            this.label11.TabIndex = 47;
            this.label11.Text = "Type";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(372, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 54);
            this.label12.TabIndex = 48;
            this.label12.Text = "Fuel";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuel_r1
            // 
            this.fuel_r1.AutoSize = true;
            this.fuel_r1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_r1.Location = new System.Drawing.Point(372, 54);
            this.fuel_r1.Name = "fuel_r1";
            this.fuel_r1.Size = new System.Drawing.Size(94, 54);
            this.fuel_r1.TabIndex = 49;
            this.fuel_r1.Text = "----";
            this.fuel_r1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuel_r2
            // 
            this.fuel_r2.AutoSize = true;
            this.fuel_r2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_r2.Location = new System.Drawing.Point(372, 108);
            this.fuel_r2.Name = "fuel_r2";
            this.fuel_r2.Size = new System.Drawing.Size(94, 54);
            this.fuel_r2.TabIndex = 50;
            this.fuel_r2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuel_r3
            // 
            this.fuel_r3.AutoSize = true;
            this.fuel_r3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_r3.Location = new System.Drawing.Point(372, 162);
            this.fuel_r3.Name = "fuel_r3";
            this.fuel_r3.Size = new System.Drawing.Size(94, 54);
            this.fuel_r3.TabIndex = 51;
            this.fuel_r3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuel_r4
            // 
            this.fuel_r4.AutoSize = true;
            this.fuel_r4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_r4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_r4.Location = new System.Drawing.Point(372, 216);
            this.fuel_r4.Name = "fuel_r4";
            this.fuel_r4.Size = new System.Drawing.Size(94, 54);
            this.fuel_r4.TabIndex = 52;
            this.fuel_r4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuel_r5
            // 
            this.fuel_r5.AutoSize = true;
            this.fuel_r5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_r5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_r5.Location = new System.Drawing.Point(372, 270);
            this.fuel_r5.Name = "fuel_r5";
            this.fuel_r5.Size = new System.Drawing.Size(94, 54);
            this.fuel_r5.TabIndex = 53;
            this.fuel_r5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuel_r6
            // 
            this.fuel_r6.AutoSize = true;
            this.fuel_r6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_r6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_r6.Location = new System.Drawing.Point(372, 324);
            this.fuel_r6.Name = "fuel_r6";
            this.fuel_r6.Size = new System.Drawing.Size(94, 54);
            this.fuel_r6.TabIndex = 54;
            this.fuel_r6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuel_r7
            // 
            this.fuel_r7.AutoSize = true;
            this.fuel_r7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_r7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_r7.Location = new System.Drawing.Point(372, 378);
            this.fuel_r7.Name = "fuel_r7";
            this.fuel_r7.Size = new System.Drawing.Size(94, 54);
            this.fuel_r7.TabIndex = 55;
            this.fuel_r7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuel_r8
            // 
            this.fuel_r8.AutoSize = true;
            this.fuel_r8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_r8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_r8.Location = new System.Drawing.Point(372, 432);
            this.fuel_r8.Name = "fuel_r8";
            this.fuel_r8.Size = new System.Drawing.Size(94, 54);
            this.fuel_r8.TabIndex = 56;
            this.fuel_r8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuel_r9
            // 
            this.fuel_r9.AutoSize = true;
            this.fuel_r9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuel_r9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuel_r9.Location = new System.Drawing.Point(372, 486);
            this.fuel_r9.Name = "fuel_r9";
            this.fuel_r9.Size = new System.Drawing.Size(94, 63);
            this.fuel_r9.TabIndex = 57;
            this.fuel_r9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1515, 812);
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
        private System.Windows.Forms.Label type_r1;
        private System.Windows.Forms.Label type_r2;
        private System.Windows.Forms.Label type_r3;
        private System.Windows.Forms.Label type_r4;
        private System.Windows.Forms.Label type_r5;
        private System.Windows.Forms.Label type_r6;
        private System.Windows.Forms.Label type_r7;
        private System.Windows.Forms.Label type_r8;
        private System.Windows.Forms.Label type_r9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label fuel_r1;
        private System.Windows.Forms.Label fuel_r2;
        private System.Windows.Forms.Label fuel_r3;
        private System.Windows.Forms.Label fuel_r4;
        private System.Windows.Forms.Label fuel_r5;
        private System.Windows.Forms.Label fuel_r6;
        private System.Windows.Forms.Label fuel_r7;
        private System.Windows.Forms.Label fuel_r8;
        private System.Windows.Forms.Label fuel_r9;
    }
}

