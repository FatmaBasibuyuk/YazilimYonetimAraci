namespace Yazılım_Test_Aracı
{
    partial class frmListOfMainProcess
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
            this.lblRequestProcess = new System.Windows.Forms.Label();
            this.dtGridMainProcess = new System.Windows.Forms.DataGridView();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblActivePerson = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInsertMainProcess = new System.Windows.Forms.Button();
            this.btnRaporGor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMainProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequestProcess
            // 
            this.lblRequestProcess.AutoSize = true;
            this.lblRequestProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRequestProcess.Location = new System.Drawing.Point(31, 88);
            this.lblRequestProcess.Name = "lblRequestProcess";
            this.lblRequestProcess.Size = new System.Drawing.Size(643, 20);
            this.lblRequestProcess.TabIndex = 8;
            this.lblRequestProcess.Text = "In the following main processes, select the one you want to add process to.";
            // 
            // dtGridMainProcess
            // 
            this.dtGridMainProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridMainProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessID,
            this.ProcessName,
            this.ProjectID,
            this.StartDate,
            this.FinishDate,
            this.Duration,
            this.CompleteRate,
            this.Priority,
            this.ParentID,
            this.Notes,
            this.Descriptions,
            this.CreateUserID});
            this.dtGridMainProcess.Location = new System.Drawing.Point(12, 128);
            this.dtGridMainProcess.Name = "dtGridMainProcess";
            this.dtGridMainProcess.RowTemplate.Height = 24;
            this.dtGridMainProcess.Size = new System.Drawing.Size(1238, 332);
            this.dtGridMainProcess.TabIndex = 9;
            this.dtGridMainProcess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridMainProcess_CellClick);
            // 
            // ProcessID
            // 
            this.ProcessID.HeaderText = "ProcessID";
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.ReadOnly = true;
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "Process Name";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "Project ID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // FinishDate
            // 
            this.FinishDate.HeaderText = "Finish Date";
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // CompleteRate
            // 
            this.CompleteRate.HeaderText = "Complete Rate";
            this.CompleteRate.Name = "CompleteRate";
            this.CompleteRate.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // ParentID
            // 
            this.ParentID.HeaderText = "ParentID";
            this.ParentID.Name = "ParentID";
            this.ParentID.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // Descriptions
            // 
            this.Descriptions.HeaderText = "Descriptions";
            this.Descriptions.Name = "Descriptions";
            this.Descriptions.ReadOnly = true;
            // 
            // CreateUserID
            // 
            this.CreateUserID.HeaderText = "CreateUserID";
            this.CreateUserID.Name = "CreateUserID";
            this.CreateUserID.ReadOnly = true;
            // 
            // lblActivePerson
            // 
            this.lblActivePerson.AutoSize = true;
            this.lblActivePerson.Location = new System.Drawing.Point(1089, 22);
            this.lblActivePerson.Name = "lblActivePerson";
            this.lblActivePerson.Size = new System.Drawing.Size(0, 17);
            this.lblActivePerson.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1092, 59);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 37);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInsertMainProcess
            // 
            this.btnInsertMainProcess.Location = new System.Drawing.Point(35, 13);
            this.btnInsertMainProcess.Name = "btnInsertMainProcess";
            this.btnInsertMainProcess.Size = new System.Drawing.Size(140, 48);
            this.btnInsertMainProcess.TabIndex = 16;
            this.btnInsertMainProcess.Text = "INSERT MAIN PROCESS";
            this.btnInsertMainProcess.UseVisualStyleBackColor = true;
            this.btnInsertMainProcess.Click += new System.EventHandler(this.btnInsertMainProcess_Click);
            // 
            // btnRaporGor
            // 
            this.btnRaporGor.Location = new System.Drawing.Point(204, 12);
            this.btnRaporGor.Name = "btnRaporGor";
            this.btnRaporGor.Size = new System.Drawing.Size(147, 49);
            this.btnRaporGor.TabIndex = 17;
            this.btnRaporGor.Text = "RAPOR GÖR";
            this.btnRaporGor.UseVisualStyleBackColor = true;
            this.btnRaporGor.Click += new System.EventHandler(this.btnRaporGor_Click);
            // 
            // frmListOfMainProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 489);
            this.Controls.Add(this.btnRaporGor);
            this.Controls.Add(this.btnInsertMainProcess);
            this.Controls.Add(this.lblActivePerson);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dtGridMainProcess);
            this.Controls.Add(this.lblRequestProcess);
            this.Name = "frmListOfMainProcess";
            this.Text = "ListOfMainProcess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListOfProcess_FormClosing);
            this.Load += new System.EventHandler(this.frmListOfProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMainProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestProcess;
        private System.Windows.Forms.DataGridView dtGridMainProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateUserID;
        private System.Windows.Forms.Label lblActivePerson;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInsertMainProcess;
        private System.Windows.Forms.Button btnRaporGor;
    }
}