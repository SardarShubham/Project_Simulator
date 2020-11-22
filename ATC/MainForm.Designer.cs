namespace ATC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelWholeSideMenu = new System.Windows.Forms.Panel();
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAnalyticalHistory = new System.Windows.Forms.Button();
            this.btnViewHoldingStack = new System.Windows.Forms.Button();
            this.panelNewSubMenu = new System.Windows.Forms.Panel();
            this.btnNewAirport = new System.Windows.Forms.Button();
            this.btnNewRunaway = new System.Windows.Forms.Button();
            this.btnNewAircraft = new System.Windows.Forms.Button();
            this.picAddNewButton = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelSimulator = new System.Windows.Forms.Label();
            this.labelATC = new System.Windows.Forms.Label();
            this.picATCIcon = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTimeSec = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.btnSimulate_Stop = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.SimulateTimer = new System.Windows.Forms.Timer(this.components);
            this.panelWholeSideMenu.SuspendLayout();
            this.PanelSideMenu.SuspendLayout();
            this.panelNewSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewButton)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picATCIcon)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWholeSideMenu
            // 
            this.panelWholeSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(58)))), ((int)(((byte)(85)))));
            this.panelWholeSideMenu.Controls.Add(this.PanelSideMenu);
            this.panelWholeSideMenu.Controls.Add(this.panelLogo);
            this.panelWholeSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWholeSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelWholeSideMenu.Name = "panelWholeSideMenu";
            this.panelWholeSideMenu.Size = new System.Drawing.Size(187, 543);
            this.panelWholeSideMenu.TabIndex = 6;
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(58)))), ((int)(((byte)(85)))));
            this.PanelSideMenu.Controls.Add(this.btnHelp);
            this.PanelSideMenu.Controls.Add(this.btnAnalyticalHistory);
            this.PanelSideMenu.Controls.Add(this.btnViewHoldingStack);
            this.PanelSideMenu.Controls.Add(this.panelNewSubMenu);
            this.PanelSideMenu.Controls.Add(this.picAddNewButton);
            this.PanelSideMenu.Controls.Add(this.btnAddNew);
            this.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSideMenu.Location = new System.Drawing.Point(0, 110);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(187, 309);
            this.PanelSideMenu.TabIndex = 3;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Lime;
            this.btnHelp.Location = new System.Drawing.Point(0, 260);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(187, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAnalyticalHistory
            // 
            this.btnAnalyticalHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.btnAnalyticalHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalyticalHistory.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAnalyticalHistory.FlatAppearance.BorderSize = 0;
            this.btnAnalyticalHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.btnAnalyticalHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyticalHistory.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyticalHistory.ForeColor = System.Drawing.Color.Lime;
            this.btnAnalyticalHistory.Location = new System.Drawing.Point(0, 215);
            this.btnAnalyticalHistory.Name = "btnAnalyticalHistory";
            this.btnAnalyticalHistory.Size = new System.Drawing.Size(187, 45);
            this.btnAnalyticalHistory.TabIndex = 7;
            this.btnAnalyticalHistory.Text = "Analytical History";
            this.btnAnalyticalHistory.UseVisualStyleBackColor = false;
            this.btnAnalyticalHistory.Click += new System.EventHandler(this.btnAnalyticalHistory_Click);
            // 
            // btnViewHoldingStack
            // 
            this.btnViewHoldingStack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.btnViewHoldingStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewHoldingStack.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnViewHoldingStack.FlatAppearance.BorderSize = 0;
            this.btnViewHoldingStack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.btnViewHoldingStack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHoldingStack.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHoldingStack.ForeColor = System.Drawing.Color.Lime;
            this.btnViewHoldingStack.Location = new System.Drawing.Point(0, 170);
            this.btnViewHoldingStack.Name = "btnViewHoldingStack";
            this.btnViewHoldingStack.Size = new System.Drawing.Size(187, 45);
            this.btnViewHoldingStack.TabIndex = 6;
            this.btnViewHoldingStack.Text = " View Holding Stack";
            this.btnViewHoldingStack.UseVisualStyleBackColor = false;
            this.btnViewHoldingStack.Click += new System.EventHandler(this.btnViewHoldingStack_Click);
            // 
            // panelNewSubMenu
            // 
            this.panelNewSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.panelNewSubMenu.Controls.Add(this.btnNewAirport);
            this.panelNewSubMenu.Controls.Add(this.btnNewRunaway);
            this.panelNewSubMenu.Controls.Add(this.btnNewAircraft);
            this.panelNewSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewSubMenu.Location = new System.Drawing.Point(0, 45);
            this.panelNewSubMenu.Name = "panelNewSubMenu";
            this.panelNewSubMenu.Size = new System.Drawing.Size(187, 125);
            this.panelNewSubMenu.TabIndex = 5;
            this.panelNewSubMenu.Visible = false;
            // 
            // btnNewAirport
            // 
            this.btnNewAirport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewAirport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(63)))), ((int)(((byte)(125)))));
            this.btnNewAirport.FlatAppearance.BorderSize = 0;
            this.btnNewAirport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(63)))), ((int)(((byte)(125)))));
            this.btnNewAirport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAirport.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAirport.ForeColor = System.Drawing.Color.Gold;
            this.btnNewAirport.Location = new System.Drawing.Point(0, 80);
            this.btnNewAirport.Name = "btnNewAirport";
            this.btnNewAirport.Size = new System.Drawing.Size(187, 40);
            this.btnNewAirport.TabIndex = 2;
            this.btnNewAirport.Text = "New Airport";
            this.btnNewAirport.UseVisualStyleBackColor = true;
            this.btnNewAirport.Click += new System.EventHandler(this.btnNewAirport_Click);
            // 
            // btnNewRunaway
            // 
            this.btnNewRunaway.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewRunaway.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(63)))), ((int)(((byte)(125)))));
            this.btnNewRunaway.FlatAppearance.BorderSize = 0;
            this.btnNewRunaway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(63)))), ((int)(((byte)(125)))));
            this.btnNewRunaway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRunaway.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRunaway.ForeColor = System.Drawing.Color.Gold;
            this.btnNewRunaway.Location = new System.Drawing.Point(0, 40);
            this.btnNewRunaway.Name = "btnNewRunaway";
            this.btnNewRunaway.Size = new System.Drawing.Size(187, 40);
            this.btnNewRunaway.TabIndex = 1;
            this.btnNewRunaway.Text = "  New Runaway";
            this.btnNewRunaway.UseVisualStyleBackColor = true;
            this.btnNewRunaway.Click += new System.EventHandler(this.btnNewRunaway_Click);
            // 
            // btnNewAircraft
            // 
            this.btnNewAircraft.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewAircraft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(63)))), ((int)(((byte)(125)))));
            this.btnNewAircraft.FlatAppearance.BorderSize = 0;
            this.btnNewAircraft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(63)))), ((int)(((byte)(125)))));
            this.btnNewAircraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAircraft.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAircraft.ForeColor = System.Drawing.Color.Gold;
            this.btnNewAircraft.Location = new System.Drawing.Point(0, 0);
            this.btnNewAircraft.Name = "btnNewAircraft";
            this.btnNewAircraft.Size = new System.Drawing.Size(187, 40);
            this.btnNewAircraft.TabIndex = 0;
            this.btnNewAircraft.Text = " New Aircraft";
            this.btnNewAircraft.UseVisualStyleBackColor = true;
            this.btnNewAircraft.Click += new System.EventHandler(this.btnNewAircraft_Click);
            // 
            // picAddNewButton
            // 
            this.picAddNewButton.Image = ((System.Drawing.Image)(resources.GetObject("picAddNewButton.Image")));
            this.picAddNewButton.Location = new System.Drawing.Point(17, 84);
            this.picAddNewButton.Name = "picAddNewButton";
            this.picAddNewButton.Size = new System.Drawing.Size(35, 29);
            this.picAddNewButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddNewButton.TabIndex = 4;
            this.picAddNewButton.TabStop = false;
            this.picAddNewButton.WaitOnLoad = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(73)))), ((int)(((byte)(54)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.Lime;
            this.btnAddNew.Location = new System.Drawing.Point(0, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(187, 45);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "    New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Navy;
            this.panelLogo.Controls.Add(this.labelSimulator);
            this.panelLogo.Controls.Add(this.labelATC);
            this.panelLogo.Controls.Add(this.picATCIcon);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(187, 110);
            this.panelLogo.TabIndex = 2;
            // 
            // labelSimulator
            // 
            this.labelSimulator.AutoSize = true;
            this.labelSimulator.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimulator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(5)))));
            this.labelSimulator.Location = new System.Drawing.Point(12, 77);
            this.labelSimulator.Name = "labelSimulator";
            this.labelSimulator.Size = new System.Drawing.Size(130, 30);
            this.labelSimulator.TabIndex = 2;
            this.labelSimulator.Text = "Simulator";
            // 
            // labelATC
            // 
            this.labelATC.AutoSize = true;
            this.labelATC.BackColor = System.Drawing.Color.Navy;
            this.labelATC.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelATC.ForeColor = System.Drawing.Color.Yellow;
            this.labelATC.Location = new System.Drawing.Point(12, 26);
            this.labelATC.Name = "labelATC";
            this.labelATC.Size = new System.Drawing.Size(66, 27);
            this.labelATC.TabIndex = 1;
            this.labelATC.Text = "ATC";
            // 
            // picATCIcon
            // 
            this.picATCIcon.Image = ((System.Drawing.Image)(resources.GetObject("picATCIcon.Image")));
            this.picATCIcon.Location = new System.Drawing.Point(96, 12);
            this.picATCIcon.Name = "picATCIcon";
            this.picATCIcon.Size = new System.Drawing.Size(58, 50);
            this.picATCIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picATCIcon.TabIndex = 0;
            this.picATCIcon.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelTop.Controls.Add(this.btnStop);
            this.panelTop.Controls.Add(this.panelTime);
            this.panelTop.Controls.Add(this.btnSimulate_Stop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(187, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(892, 62);
            this.panelTop.TabIndex = 7;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Lime;
            this.btnStop.Location = new System.Drawing.Point(723, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(126, 41);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.labelTimeSec);
            this.panelTime.Controls.Add(this.labelTime);
            this.panelTime.Location = new System.Drawing.Point(6, 12);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(176, 41);
            this.panelTime.TabIndex = 1;
            // 
            // labelTimeSec
            // 
            this.labelTimeSec.AutoSize = true;
            this.labelTimeSec.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSec.ForeColor = System.Drawing.Color.Yellow;
            this.labelTimeSec.Location = new System.Drawing.Point(77, 9);
            this.labelTimeSec.Name = "labelTimeSec";
            this.labelTimeSec.Size = new System.Drawing.Size(30, 20);
            this.labelTimeSec.TabIndex = 1;
            this.labelTimeSec.Text = "0 s";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Yellow;
            this.labelTime.Location = new System.Drawing.Point(15, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(60, 20);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "TIME : ";
            // 
            // btnSimulate_Stop
            // 
            this.btnSimulate_Stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSimulate_Stop.FlatAppearance.BorderSize = 0;
            this.btnSimulate_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSimulate_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulate_Stop.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulate_Stop.ForeColor = System.Drawing.Color.Lime;
            this.btnSimulate_Stop.Location = new System.Drawing.Point(576, 12);
            this.btnSimulate_Stop.Name = "btnSimulate_Stop";
            this.btnSimulate_Stop.Size = new System.Drawing.Size(126, 41);
            this.btnSimulate_Stop.TabIndex = 0;
            this.btnSimulate_Stop.Text = "SIMULATE";
            this.btnSimulate_Stop.UseVisualStyleBackColor = false;
            this.btnSimulate_Stop.Click += new System.EventHandler(this.btnSimulate_Stop_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Black;
            this.panelChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChildForm.BackgroundImage")));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(187, 62);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(892, 481);
            this.panelChildForm.TabIndex = 8;
            // 
            // SimulateTimer
            // 
            this.SimulateTimer.Interval = 1000;
            this.SimulateTimer.Tick += new System.EventHandler(this.SimulateTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1079, 543);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelWholeSideMenu);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelWholeSideMenu.ResumeLayout(false);
            this.PanelSideMenu.ResumeLayout(false);
            this.panelNewSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewButton)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picATCIcon)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWholeSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelSimulator;
        private System.Windows.Forms.Label labelATC;
        private System.Windows.Forms.PictureBox picATCIcon;
        private System.Windows.Forms.Panel PanelSideMenu;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAnalyticalHistory;
        private System.Windows.Forms.Button btnViewHoldingStack;
        private System.Windows.Forms.Panel panelNewSubMenu;
        private System.Windows.Forms.Button btnNewAirport;
        private System.Windows.Forms.Button btnNewRunaway;
        private System.Windows.Forms.Button btnNewAircraft;
        private System.Windows.Forms.PictureBox picAddNewButton;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Timer SimulateTimer;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label labelTimeSec;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button btnSimulate_Stop;
        private System.Windows.Forms.Button btnStop;
    }
}