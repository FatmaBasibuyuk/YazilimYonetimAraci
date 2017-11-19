using System;
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
    public partial class frmListOfMainProcess : Form
    {
        public int id = 0;
        public string projectName = "";
        public int UsersID;
        public frmListOfMainProcess(int id, string pName, int usersID)
        {
            this.id = id;
            this.projectName = pName;
            this.UsersID = usersID;
            InitializeComponent();
        }

        private void frmListOfProcess_Load(object sender, EventArgs e)
        {
            int ProjectID = id;
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblProcess WHERE ParentID = 0 AND ProjectID = @ProjectID", con);
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                int i;
                while (reader.Read() == true)
                {
                    i = dtGridMainProcess.Rows.Add();
                    dtGridMainProcess.Rows[i].Cells[0].Value = Convert.ToInt32(reader[0]);
                    dtGridMainProcess.Rows[i].Cells[1].Value = reader[1].ToString();
                    dtGridMainProcess.Rows[i].Cells[2].Value = Convert.ToInt32(reader[2]);
                    dtGridMainProcess.Rows[i].Cells[3].Value = Convert.ToDateTime(reader[3]);
                    dtGridMainProcess.Rows[i].Cells[4].Value = Convert.ToDateTime(reader[4]);
                    dtGridMainProcess.Rows[i].Cells[5].Value = Convert.ToInt32(reader[5]);
                    dtGridMainProcess.Rows[i].Cells[6].Value = Convert.ToInt32(reader[6]);
                    dtGridMainProcess.Rows[i].Cells[7].Value = Convert.ToInt32(reader[7]);
                    dtGridMainProcess.Rows[i].Cells[8].Value = Convert.ToInt32(reader[8]);
                    dtGridMainProcess.Rows[i].Cells[9].Value = reader[9].ToString();
                    dtGridMainProcess.Rows[i].Cells[10].Value = reader[10].ToString();
                    dtGridMainProcess.Rows[i].Cells[11].Value = Convert.ToInt32(reader[11]);
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListOfProcess_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnInsertMainProcess_Click(object sender, EventArgs e)
        {
            
            frmInsertMainProcess imp = new frmInsertMainProcess(id, projectName, UsersID);
            imp.Show();
        }

        private void dtGridMainProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex >= 0)
            {
                dtGridMainProcess.Rows[e.RowIndex].Selected = true;
            }
            int id = Convert.ToInt32(dtGridMainProcess.Rows[e.RowIndex].Cells[0].Value);
            string projectname = dtGridMainProcess.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dtGridMainProcess.Rows[e.RowIndex].Selected)
            {
                frmListOfProcess lomp = new frmListOfProcess(id, projectname, UsersID);
                lomp.Show();
            }
        }

        private void btnRaporGor_Click(object sender, EventArgs e)
        {
            int ProjectID = id;
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblProcess WHERE ParentID = 0 AND ProjectID = @ProjectID", con);
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read() == true)
                {
                        MessageBox.Show(
                       Convert.ToInt32(reader[0]).ToString() + Environment.NewLine +
                       reader[1].ToString() + Environment.NewLine +
                         Convert.ToInt32(reader[2]).ToString() + Environment.NewLine +
                         Convert.ToDateTime(reader[3]).ToString() + Environment.NewLine +
                          Convert.ToDateTime(reader[4]).ToString() + Environment.NewLine +
                          Convert.ToInt32(reader[5]).ToString() + Environment.NewLine +
                          Convert.ToInt32(reader[6]).ToString() +  Environment.NewLine +
                          Convert.ToInt32(reader[7]).ToString() + Environment.NewLine +
                          Convert.ToInt32(reader[8]).ToString() + Environment.NewLine +
                          reader[9].ToString() + Environment.NewLine +
                           reader[10].ToString() + Environment.NewLine +
                            Convert.ToInt32(reader[11]) + Environment.NewLine);
                    
                    
                   
                }
                reader.Close();
            }
            con.Close();

        }
    }
}

