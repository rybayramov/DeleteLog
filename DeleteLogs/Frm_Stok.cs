using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteLogs
{
    public partial class Frm_Stok : Form
    {
        public string ReturnValue1 { get; set; }
        public string CariHesab { get; set; }
        public Frm_Stok()
        {
            InitializeComponent();
        }

        private void Frm_CariHesab_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MicroDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            //SqlCommand comm = conn.CreateCommand();
            //comm.CommandText = @"select cari_kod,cari_unvan1 from MikroDB_V15_DISCOUNT.dbo.CARI_HESAPLAR WHERE cari_kilitli!=1 ";
            //SqlDataReader reader = comm.ExecuteReader();

            //var dataAdapter = new SqlDataAdapter(@"select cari_kod,cari_unvan1 from MikroDB_V15_DISCOUNT.dbo.CARI_HESAPLAR WHERE cari_kilitli!=1 ", conn);

            //var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //var ds = new DataSet();
            //dataAdapter.Fill(ds);
            //dataGridView1.ReadOnly = true;
            //dataGridView1.DataSource = ds.Tables[0];


            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = @"select sto_kod,sto_isim from STOKLAR where sto_sat_cari_kod='" + CariHesab+"'";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;

            DataGridViewRow row = dataGridView1.Rows
            .Cast<DataGridViewRow>()
            .Where(r => r.Cells["sto_kod"].Value.ToString().StartsWith(ReturnValue1))
            .First();

          //  rowIndex = ;

            dataGridView1.CurrentCell = dataGridView1.Rows[row.Index].Cells["sto_kod"];

            dataGridView1.CurrentCell.Selected = true;

          //  dataGridView1.CurrentCell = dataGridView1.Item("cari_kod", "0377");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
         //   ParkSiyahi currentObject = new ParkSiyahi();
        //    currentObject = (ParkSiyahi)dataGridView6.CurrentRow.DataBoundItem;
           // this.ReturnValue1 = currentObject.ParkNo.ToString();

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex =  dataGridView1.CurrentCell.ColumnIndex;

            this.ReturnValue1 = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
