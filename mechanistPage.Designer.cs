namespace myFirstApp
{
    partial class mechanistPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mechanistPage));
            this.dgvNewJobs = new System.Windows.Forms.DataGridView();
            this.jobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newJobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOngoingJobs = new System.Windows.Forms.DataGridView();
            this.goingJobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goingDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goingState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHoldJobs = new System.Windows.Forms.DataGridView();
            this.holdJobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOngoingJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoldJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNewJobs
            // 
            this.dgvNewJobs.AllowUserToAddRows = false;
            this.dgvNewJobs.AllowUserToDeleteRows = false;
            this.dgvNewJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNewJobs.BackgroundColor = System.Drawing.Color.White;
            this.dgvNewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobID,
            this.newJobDescription,
            this.newState});
            this.dgvNewJobs.Location = new System.Drawing.Point(87, 224);
            this.dgvNewJobs.Name = "dgvNewJobs";
            this.dgvNewJobs.ReadOnly = true;
            this.dgvNewJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewJobs.Size = new System.Drawing.Size(461, 537);
            this.dgvNewJobs.TabIndex = 9;
            this.dgvNewJobs.DoubleClick += new System.EventHandler(this.dgvNewJobs_DoubleClick);
            // 
            // jobID
            // 
            this.jobID.DataPropertyName = "jobID";
            this.jobID.HeaderText = "jobID";
            this.jobID.Name = "jobID";
            this.jobID.ReadOnly = true;
            // 
            // newJobDescription
            // 
            this.newJobDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newJobDescription.DataPropertyName = "description";
            this.newJobDescription.HeaderText = "Description";
            this.newJobDescription.Name = "newJobDescription";
            this.newJobDescription.ReadOnly = true;
            // 
            // newState
            // 
            this.newState.DataPropertyName = "status";
            this.newState.HeaderText = "State";
            this.newState.Name = "newState";
            this.newState.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 89);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Jobs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvOngoingJobs
            // 
            this.dgvOngoingJobs.AllowUserToAddRows = false;
            this.dgvOngoingJobs.AllowUserToDeleteRows = false;
            this.dgvOngoingJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOngoingJobs.BackgroundColor = System.Drawing.Color.White;
            this.dgvOngoingJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOngoingJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goingJobID,
            this.goingDescription,
            this.goingState});
            this.dgvOngoingJobs.Location = new System.Drawing.Point(1095, 224);
            this.dgvOngoingJobs.Name = "dgvOngoingJobs";
            this.dgvOngoingJobs.ReadOnly = true;
            this.dgvOngoingJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOngoingJobs.Size = new System.Drawing.Size(422, 537);
            this.dgvOngoingJobs.TabIndex = 10;
            this.dgvOngoingJobs.DoubleClick += new System.EventHandler(this.dgvOngoingJobs_DoubleClick);
            // 
            // goingJobID
            // 
            this.goingJobID.DataPropertyName = "jobID";
            this.goingJobID.HeaderText = "jobID";
            this.goingJobID.Name = "goingJobID";
            this.goingJobID.ReadOnly = true;
            // 
            // goingDescription
            // 
            this.goingDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goingDescription.DataPropertyName = "description";
            this.goingDescription.HeaderText = "Description";
            this.goingDescription.Name = "goingDescription";
            this.goingDescription.ReadOnly = true;
            // 
            // goingState
            // 
            this.goingState.DataPropertyName = "status";
            this.goingState.HeaderText = "State";
            this.goingState.Name = "goingState";
            this.goingState.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1106, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 89);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ongoing Jobs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvHoldJobs
            // 
            this.dgvHoldJobs.AllowUserToAddRows = false;
            this.dgvHoldJobs.AllowUserToDeleteRows = false;
            this.dgvHoldJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvHoldJobs.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoldJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoldJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.holdJobID,
            this.holdDescription,
            this.holdState});
            this.dgvHoldJobs.Location = new System.Drawing.Point(604, 224);
            this.dgvHoldJobs.Name = "dgvHoldJobs";
            this.dgvHoldJobs.ReadOnly = true;
            this.dgvHoldJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoldJobs.Size = new System.Drawing.Size(445, 537);
            this.dgvHoldJobs.TabIndex = 12;
            this.dgvHoldJobs.DoubleClick += new System.EventHandler(this.dgvHoldJobs_Click);
            // 
            // holdJobID
            // 
            this.holdJobID.DataPropertyName = "jobID";
            this.holdJobID.HeaderText = "jobID";
            this.holdJobID.Name = "holdJobID";
            this.holdJobID.ReadOnly = true;
            // 
            // holdDescription
            // 
            this.holdDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.holdDescription.DataPropertyName = "description";
            this.holdDescription.HeaderText = "Description";
            this.holdDescription.Name = "holdDescription";
            this.holdDescription.ReadOnly = true;
            // 
            // holdState
            // 
            this.holdState.DataPropertyName = "status";
            this.holdState.HeaderText = "State";
            this.holdState.Name = "holdState";
            this.holdState.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(670, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 89);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hold Jobs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Exit";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 3;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.Location = new System.Drawing.Point(1399, 770);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(118, 47);
            this.bunifuThinButton22.TabIndex = 89;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mechanistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1623, 832);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.dgvHoldJobs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNewJobs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOngoingJobs);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mechanistPage";
            this.Text = "mechanistPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOngoingJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoldJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNewJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn newJobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn newState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOngoingJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn goingJobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn goingDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn goingState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHoldJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdJobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdState;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Timer timer1;
    }
}