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

namespace DeleteLogs
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {


            string connecttionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MicroDB"].ConnectionString;
            SqlConnection cs1 = new SqlConnection(connecttionstring);
            SqlCommand cmd1 = new SqlCommand();
            cs1.Open();
            cmd1.CommandText = "select user_no, User_name from MikroDB_V15.dbo.KULLANICILAR WHERE MikroDB_V15.dbo.KULLANICILAR.User_LongName LIKE 'DISCO%'";
            cmd1.Connection = cs1;
            DataSet dtst = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd1);
            dp.Fill(dtst);
            cmb_user.DataSource = dtst;

            cmb_user.DataSource = dtst.Tables[0];
            cmb_user.DisplayMember = "User_name";
            cmb_user.ValueMember = "user_no";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Receipt form = new Frm_Receipt();
            form.user_kod = cmb_user.SelectedValue.ToString();
            form.shop = "109";
            form.Show();
        }
    }
}
