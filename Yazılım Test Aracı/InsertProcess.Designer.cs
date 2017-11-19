namespace Yazılım_Test_Aracı
{
    partial class frmInsertProcess
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
            this.cmbFromWho = new System.Windows.Forms.ComboBox();
            this.lblFromWho = new System.Windows.Forms.Label();
            this.txtWorkFollowName = new System.Windows.Forms.TextBox();
            this.lblWorkFollowName = new System.Windows.Forms.Label();
            this.cmbCompleteRate = new System.Windows.Forms.ComboBox();
            this.lblCompleteRate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFromWho
            // 
            this.cmbFromWho.FormattingEnabled = true;
            this.cmbFromWho.Location = new System.Drawing.Point(522, 253);
            this.cmbFromWho.Name = "cmbFromWho";
            this.cmbFromWho.Size = new System.Drawing.Size(202, 24);
            this.cmbFromWho.TabIndex = 41;
            this.cmbFromWho.Leave += new System.EventHandler(this.cmbFromWho_Leave);
            // 
            // lblFromWho
            // 
            this.lblFromWho.AutoSize = true;
            this.lblFromWho.Location = new System.Drawing.Point(411, 256);
            this.lblFromWho.Name = "lblFromWho";
            this.lblFromWho.Size = new System.Drawing.Size(77, 17);
            this.lblFromWho.TabIndex = 40;
            this.lblFromWho.Text = "From Who:";
            // 
            // txtWorkFollowName
            // 
            this.txtWorkFollowName.Location = new System.Drawing.Point(522, 192);
            this.txtWorkFollowName.Name = "txtWorkFollowName";
            this.txtWorkFollowName.Size = new System.Drawing.Size(202, 22);
            this.txtWorkFollowName.TabIndex = 39;
            this.txtWorkFollowName.Leave += new System.EventHandler(this.txtWorkFollowName_Leave);
            // 
            // lblWorkFollowName
            // 
            this.lblWorkFollowName.AutoSize = true;
            this.lblWorkFollowName.Location = new System.Drawing.Point(387, 192);
            this.lblWorkFollowName.Name = "lblWorkFollowName";
            this.lblWorkFollowName.Size = new System.Drawing.Size(129, 17);
            this.lblWorkFollowName.TabIndex = 38;
            this.lblWorkFollowName.Text = "Work Follow Name:";
            // 
            // cmbCompleteRate
            // 
            this.cmbCompleteRate.FormattingEnabled = true;
            this.cmbCompleteRate.Location = new System.Drawing.Point(522, 135);
            this.cmbCompleteRate.Name = "cmbCompleteRate";
            this.cmbCompleteRate.Size = new System.Drawing.Size(202, 24);
            this.cmbCompleteRate.TabIndex = 37;
            this.cmbCompleteRate.Leave += new System.EventHandler(this.cmbCompleteRate_Leave);
            // 
            // lblCompleteRate
            // 
            this.lblCompleteRate.AutoSize = true;
            this.lblCompleteRate.Location = new System.Drawing.Point(411, 135);
            this.lblCompleteRate.Name = "lblCompleteRate";
            this.lblCompleteRate.Size = new System.Drawing.Size(105, 17);
            this.lblCompleteRate.TabIndex = 36;
            this.lblCompleteRate.Text = "Complete Rate:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(418, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(273, 76);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(151, 303);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(206, 90);
            this.txtDescription.TabIndex = 34;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(26, 303);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 33;
            this.lblDescription.Text = "Description:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(151, 192);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(202, 81);
            this.txtNotes.TabIndex = 32;
            this.txtNotes.Leave += new System.EventHandler(this.txtNotes_Leave);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(25, 192);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 17);
            this.lblNotes.TabIndex = 31;
            this.lblNotes.Text = "Notes:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(522, 80);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(202, 24);
            this.cmbPriority.TabIndex = 30;
            this.cmbPriority.Leave += new System.EventHandler(this.cmbPriority_Leave);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(415, 83);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(56, 17);
            this.lblPriority.TabIndex = 29;
            this.lblPriority.Text = "Priority:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(522, 32);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(202, 22);
            this.txtDuration.TabIndex = 28;
            this.txtDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuration_KeyPress);
            this.txtDuration.Leave += new System.EventHandler(this.txtDuration_Leave);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(415, 32);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(66, 17);
            this.lblDuration.TabIndex = 27;
            this.lblDuration.Text = "Duration:";
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Location = new System.Drawing.Point(151, 130);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(202, 22);
            this.dtpFinishDate.TabIndex = 26;
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Location = new System.Drawing.Point(25, 130);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(83, 17);
            this.lblFinishDate.TabIndex = 25;
            this.lblFinishDate.Text = "Finish Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(151, 80);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(202, 22);
            this.dtpStartDate.TabIndex = 24;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(25, 80);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblStartDate.TabIndex = 23;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(151, 32);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(202, 22);
            this.txtProcessName.TabIndex = 22;
            this.txtProcessName.Leave += new System.EventHandler(this.txtProcessName_Leave);
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(25, 32);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(104, 17);
            this.lblProcessName.TabIndex = 21;
            this.lblProcessName.Text = "Process Name:";
            // 
            // frmInsertProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 423);
            this.Controls.Add(this.cmbFromWho);
            this.Controls.Add(this.lblFromWho);
            this.Controls.Add(this.txtWorkFollowName);
            this.Controls.Add(this.lblWorkFollowName);
            this.Controls.Add(this.cmbCompleteRate);
            this.Controls.Add(this.lblCompleteRate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.dtpFinishDate);
            this.Controls.Add(this.lblFinishDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.lblProcessName);
            this.Name = "frmInsertProcess";
            this.Text = "InsertProcess";
            this.Load += new System.EventHandler(this.frmInsertProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFromWho;
        private System.Windows.Forms.Label lblFromWho;
        private System.Windows.Forms.TextBox txtWorkFollowName;
        private System.Windows.Forms.Label lblWorkFollowName;
        private System.Windows.Forms.ComboBox cmbCompleteRate;
        private System.Windows.Forms.Label lblCompleteRate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label lblProcessName;
    }
}