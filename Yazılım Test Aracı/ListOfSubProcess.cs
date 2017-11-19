﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Test_Aracı
{
    public partial class frmListOfSubProcess : Form
    {
        public int id = 0;
        public string projectName = "";
        public int UsersID;
        public frmListOfSubProcess(int id, string pName, int usersID)
        {
            this.id = id;
            this.projectName = pName;
            this.UsersID = usersID;
            InitializeComponent();
        }

        private void btnInsertSubProcess_Click(object sender, EventArgs e)
        {
            frmInsertSubProcess ip = new frmInsertSubProcess(id, projectName, UsersID);
            ip.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListOfSubProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Çıkış Mesajı", MessageBoxButtons.YesNo);
            if (x == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers WHERE UsersID = @UsersID ", con);
                cmd.Parameters.AddWithValue("UsersID", UsersID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Users u = new Users();
                    while (reader.Read() == true)
                    {
                        u.UsersID = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();
                    con.Close();
                    e.Cancel = false;
                }
            }
        }

        private void frmListOfSubProcess_Load(object sender, EventArgs e)
        {
            int ProjectID = id;
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblProcess WHERE ParentID = 2 AND ProjectID = @ProjectID", con);
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i;
                while (reader.Read() == true)
                {
                    i = dtGridSubProcess.Rows.Add();
                    dtGridSubProcess.Rows[i].Cells[0].Value = Convert.ToInt32(reader[0]);
                    dtGridSubProcess.Rows[i].Cells[1].Value = reader[1].ToString();
                    dtGridSubProcess.Rows[i].Cells[2].Value = Convert.ToInt32(reader[2]);
                    dtGridSubProcess.Rows[i].Cells[3].Value = Convert.ToDateTime(reader[3]);
                    dtGridSubProcess.Rows[i].Cells[4].Value = Convert.ToDateTime(reader[4]);
                    dtGridSubProcess.Rows[i].Cells[5].Value = Convert.ToInt32(reader[5]);
                    dtGridSubProcess.Rows[i].Cells[6].Value = Convert.ToInt32(reader[6]);
                    dtGridSubProcess.Rows[i].Cells[7].Value = Convert.ToInt32(reader[7]);
                    dtGridSubProcess.Rows[i].Cells[8].Value = Convert.ToInt32(reader[8]);
                    dtGridSubProcess.Rows[i].Cells[9].Value = reader[9].ToString();
                    dtGridSubProcess.Rows[i].Cells[10].Value = reader[10].ToString();
                    dtGridSubProcess.Rows[i].Cells[11].Value = Convert.ToInt32(reader[11]);
                }
                reader.Close();
            }
            con.Close();

            string connectionString1 = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con1 = new SqlConnection(connectionString1);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM tblUsers WHERE UsersID = @UsersID", con1);
            cmd1.Parameters.AddWithValue("UsersID", UsersID);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.HasRows)
            {
                Users u1 = new Users();
                while (reader1.Read() == true)
                {
                    u1.UserName = reader1[1].ToString();
                    u1.UserSurname = reader1[2].ToString();
                }
                lblActivePerson.Text = u1.UserName + " " + u1.UserSurname;
            }
            con1.Close();
        }

        private void lblActivePerson_Click(object sender, EventArgs e)
        {

        }
    }
}
