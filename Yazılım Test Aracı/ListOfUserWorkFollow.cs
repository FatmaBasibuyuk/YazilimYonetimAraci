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
    public partial class frmListOfUserWorkFollow : Form
    {
        public int UsersID;
        public frmListOfUserWorkFollow(int usersID)
        {
            this.UsersID = usersID;
            InitializeComponent();
        }


        private void frmListOfUserWorkFollow_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM WorkFollow WF INNER JOIN tblWorkFollowDetails WFD ON WF.WorkFollowDetailsID = WFD.WorkFollowDetailsID", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read() == true)
                {
                    int i;
                    i = dtGridWorkFollow.Rows.Add();
                    dtGridWorkFollow.Rows[i].Cells[0].Value = Convert.ToInt32(reader[0]);
                    dtGridWorkFollow.Rows[i].Cells[1].Value = Convert.ToInt32(reader[1]);
                    dtGridWorkFollow.Rows[i].Cells[2].Value = Convert.ToDateTime(reader[2]);
                    dtGridWorkFollow.Rows[i].Cells[3].Value = Convert.ToDateTime(reader[3]);
                    dtGridWorkFollow.Rows[i].Cells[4].Value = Convert.ToInt32(reader[5]);
                    if (reader[6] == null)
                    {
                        dtGridWorkFollow.Rows[i].Cells[5].Value = "0";
                    }
                    else
                    {
                        dtGridWorkFollow.Rows[i].Cells[5].Value = Convert.ToInt32(reader[6]);
                    }
                    dtGridWorkFollow.Rows[i].Cells[6].Value = reader[8].ToString();
                }
                reader.Close();
            }
            con.Close();

        }

        private void dtGridWorkFollow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dtGridWorkFollow.Rows[e.RowIndex].Selected = true;
            }
            int WorkFollowID = Convert.ToInt32(dtGridWorkFollow.Rows[e.RowIndex].Cells[0].Value);
            int ProcessID = Convert.ToInt32(dtGridWorkFollow.Rows[e.RowIndex].Cells[1].Value.ToString());
            DateTime StartDate = Convert.ToDateTime(dtGridWorkFollow.Rows[e.RowIndex].Cells[2].Value);
            DateTime FinishDate = Convert.ToDateTime(dtGridWorkFollow.Rows[e.RowIndex].Cells[3].Value.ToString());
            int UserID = Convert.ToInt32(dtGridWorkFollow.Rows[e.RowIndex].Cells[4].Value);
            string WorkFollowName = dtGridWorkFollow.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (dtGridWorkFollow.Rows[e.RowIndex].Selected)
            {
                frmChangeCompleteRate lomp = new frmChangeCompleteRate(WorkFollowID, ProcessID, StartDate, FinishDate, UserID, WorkFollowName);
                lomp.Show();
            }

        }
    }
}
