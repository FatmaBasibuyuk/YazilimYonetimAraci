namespace Yazılım_Test_Aracı
{
    partial class frmListOfProcess
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
            this.btnInsertProcess = new System.Windows.Forms.Button();
            this.lblActivePerson = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dtGridProcess = new System.Windows.Forms.DataGridView();
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
            this.lblRequestProcess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertProcess
            // 
            this.btnInsertProcess.Location = new System.Drawing.Point(38, 23);
            this.btnInsertProcess.Name = "btnInsertProcess";
            this.btnInsertProcess.Size = new System.Drawing.Size(140, 48);
            this.btnInsertProcess.TabIndex = 23;
            this.btnInsertProcess.Text = "INSERT PROCESS";
            this.btnInsertProcess.UseVisualStyleBackColor = true;
            this.btnInsertProcess.Click += new System.EventHandler(this.btnInsertProcess_Click);
            // 
            // lblActivePerson
            // 
            this.lblActivePerson.AutoSize = true;
            this.lblActivePerson.Location = new System.Drawing.Point(1092, 32);
            this.lblActivePerson.Name = "lblActivePerson";
            this.lblActivePerson.Size = new System.Drawing.Size(0, 17);
            this.lblActivePerson.TabIndex = 22;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1095, 69);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 37);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dtGridProcess
            // 
            this.dtGridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtGridProcess.Location = new System.Drawing.Point(15, 138);
            this.dtGridProcess.Name = "dtGridProcess";
            this.dtGridProcess.RowTemplate.Height = 24;
            this.dtGridProcess.Size = new System.Drawing.Size(1238, 332);
            this.dtGridProcess.TabIndex = 20;
            this.dtGridProcess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProcess_CellClick);
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
            // lblRequestProcess
            // 
            this.lblRequestProcess.AutoSize = true;
            this.lblRequestProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRequestProcess.Location = new System.Drawing.Point(34, 98);
            this.lblRequestProcess.Name = "lblRequestProcess";
            this.lblRequestProcess.Size = new System.Drawing.Size(643, 20);
            this.lblRequestProcess.TabIndex = 19;
            this.lblRequestProcess.Text = "In the following main processes, select the one you want to add process to.";
            // 
            // frmListOfProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 492);
            this.Controls.Add(this.btnInsertProcess);
            this.Controls.Add(this.lblActivePerson);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dtGridProcess);
            this.Controls.Add(this.lblRequestProcess);
            this.Name = "frmListOfProcess";
            this.Text = "ListOfProcess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListOfProcess_FormClosing);
            this.Load += new System.EventHandler(this.frmListOfProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertProcess;
        private System.Windows.Forms.Label lblActivePerson;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dtGridProcess;
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
        private System.Windows.Forms.Label lblRequestProcess;
    }
}