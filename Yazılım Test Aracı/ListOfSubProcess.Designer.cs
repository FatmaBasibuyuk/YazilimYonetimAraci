namespace Yazılım_Test_Aracı
{
    partial class frmListOfSubProcess
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
            this.btnInsertSubProcess = new System.Windows.Forms.Button();
            this.lblActivePerson = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dtGridSubProcess = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSubProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertSubProcess
            // 
            this.btnInsertSubProcess.Location = new System.Drawing.Point(34, 33);
            this.btnInsertSubProcess.Name = "btnInsertSubProcess";
            this.btnInsertSubProcess.Size = new System.Drawing.Size(140, 48);
            this.btnInsertSubProcess.TabIndex = 23;
            this.btnInsertSubProcess.Text = "INSERT SUB PROCESS";
            this.btnInsertSubProcess.UseVisualStyleBackColor = true;
            this.btnInsertSubProcess.Click += new System.EventHandler(this.btnInsertSubProcess_Click);
            // 
            // lblActivePerson
            // 
            this.lblActivePerson.AutoSize = true;
            this.lblActivePerson.Location = new System.Drawing.Point(1088, 42);
            this.lblActivePerson.Name = "lblActivePerson";
            this.lblActivePerson.Size = new System.Drawing.Size(0, 17);
            this.lblActivePerson.TabIndex = 22;
            this.lblActivePerson.Click += new System.EventHandler(this.lblActivePerson_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1091, 79);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 37);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dtGridSubProcess
            // 
            this.dtGridSubProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSubProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtGridSubProcess.Location = new System.Drawing.Point(11, 148);
            this.dtGridSubProcess.Name = "dtGridSubProcess";
            this.dtGridSubProcess.RowTemplate.Height = 24;
            this.dtGridSubProcess.Size = new System.Drawing.Size(1238, 332);
            this.dtGridSubProcess.TabIndex = 20;
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
            this.lblRequestProcess.Location = new System.Drawing.Point(30, 108);
            this.lblRequestProcess.Name = "lblRequestProcess";
            this.lblRequestProcess.Size = new System.Drawing.Size(643, 20);
            this.lblRequestProcess.TabIndex = 19;
            this.lblRequestProcess.Text = "In the following main processes, select the one you want to add process to.";
            // 
            // frmListOfSubProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 513);
            this.Controls.Add(this.btnInsertSubProcess);
            this.Controls.Add(this.lblActivePerson);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dtGridSubProcess);
            this.Controls.Add(this.lblRequestProcess);
            this.Name = "frmListOfSubProcess";
            this.Text = "ListOfSubProcess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListOfSubProcess_FormClosing);
            this.Load += new System.EventHandler(this.frmListOfSubProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSubProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertSubProcess;
        private System.Windows.Forms.Label lblActivePerson;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dtGridSubProcess;
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