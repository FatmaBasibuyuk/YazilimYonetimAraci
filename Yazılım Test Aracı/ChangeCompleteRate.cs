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
    public partial class frmChangeCompleteRate : Form
    {
        public int WorkFollowID;
        public int ProcessID;
        public DateTime StartDate;
        public DateTime FinishDate;
        public int UsersID;
        public string WorkFollowName;
        public frmChangeCompleteRate(int WorkFollowID,int ProcessID,DateTime StartDate,DateTime FinishDate,int UserID,string  WorkFollowName)
        {
            this.WorkFollowID = WorkFollowID;
            this.ProcessID = ProcessID;
            this.StartDate = StartDate;
            this.FinishDate = FinishDate;
            this.UsersID = UserID;
            this.WorkFollowName = WorkFollowName;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtWorkFollowID.Text = WorkFollowID.ToString();
            txtUserID.Text = UsersID.ToString();
            txtProcessID.Text = ProcessID.ToString();
            txtStartDate.Text = StartDate.ToString();
            txtFinishDate.Text = FinishDate.ToString();
            txtWorkFollowName.Text = WorkFollowName;
            int CompleteRate = Convert.ToInt32(cmbCompleteRate.Text);
            string connectionString = @"Data Source=TOSHIBA;Integrated Security=True;Initial Catalog=YazilimYonetimAraci;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE WorkFollow SET CompleteRate = @CompleteRate WHERE WorkFollowID = @WorkFollowID", con);
            cmd.Parameters.AddWithValue("WorkFollowID", WorkFollowID);
            cmd.Parameters.AddWithValue("CompleteRate", CompleteRate);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Complete Rate successfully update.");
            con.Close();

        }

        private void frmChangeCompleteRate_Load(object sender, EventArgs e)
        {
            txtWorkFollowID.Text = WorkFollowID.ToString();
            txtUserID.Text = UsersID.ToString();
            txtProcessID.Text = ProcessID.ToString();
            txtStartDate.Text = StartDate.ToString();
            txtFinishDate.Text = FinishDate.ToString();
            txtWorkFollowName.Text = WorkFollowName;

            for (int i = 0; i < 101; i++)
            {
                cmbCompleteRate.Items.Add(i);
            }
        }
    }
}
