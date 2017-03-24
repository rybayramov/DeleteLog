using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteLogs
{
    public partial class Frm_Receipt : Form
    {
        private bool gridedit;
        public string user_kod;
        public string shop;
        public Frm_Receipt()
        {
            InitializeComponent();
        }
        private List<FaktLine> FPrintObject;
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo source = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory());

            foreach (FileInfo fi in source.GetFiles())
            {
                if (fi.Extension == ".log")
                {
                    var creationTime = fi.Name.Substring(0, 8);

                    if (DateTime.ParseExact(creationTime,
                                      "yyyyMMdd",
                                       CultureInfo.InvariantCulture) < (DateTime.Now - new TimeSpan(7, 0, 0, 0)))
                    {
                        fi.Delete();
                    }
                }
            }
        }
        public class FaktLine
        {
            public string Kodu { get; set; }
            public string Adı { get; set; }
            public string Miqdarı { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(null, null);
            FPrintObject = new List<FaktLine>();  
            for (int i = 0; i < 100; i++)
            {
                FaktLine cash3 = new FaktLine() { Kodu = "", Adı = "", Miqdarı = "", };
                FPrintObject.Add(cash3);
            }
            dataGridView1.DataSource = FPrintObject;
            txt_evrak_seri.Text = shop;
            txt_srmMerkez.Text = shop;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            int setrno = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MicroDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            SqlTransaction tran = conn.BeginTransaction();
            comm.Transaction = tran;
            foreach (var item in FPrintObject)
            {
                if (!string.IsNullOrEmpty(item.Kodu))
                {
                    comm.CommandText = @"INSERT [STOK_HAREKETLERI] ( [sth_RECid_DBCno], [sth_RECid_RECno], [sth_SpecRECno], [sth_iptal], [sth_fileid], [sth_hidden], [sth_kilitli], [sth_degisti], [sth_checksum], [sth_create_user], [sth_create_date],   [sth_lastup_user], [sth_lastup_date],     [sth_special1], [sth_special2], [sth_special3], [sth_firmano], [sth_subeno], [sth_tarih],              [sth_tip], [sth_cins], [sth_normal_iade], [sth_evraktip], [sth_evrakno_seri], [sth_evrakno_sira],            [sth_satirno], [sth_belge_no],      [sth_belge_tarih],           [sth_stok_kod],         [sth_isk_mas1], [sth_isk_mas2], [sth_isk_mas3], [sth_isk_mas4], [sth_isk_mas5], [sth_isk_mas6], [sth_isk_mas7], [sth_isk_mas8], [sth_isk_mas9], [sth_isk_mas10], [sth_sat_iskmas1], [sth_sat_iskmas2], [sth_sat_iskmas3], [sth_sat_iskmas4], [sth_sat_iskmas5], [sth_sat_iskmas6], [sth_sat_iskmas7], [sth_sat_iskmas8], [sth_sat_iskmas9], [sth_sat_iskmas10], [sth_pos_satis], [sth_promosyon_fl], [sth_cari_cinsi], [sth_cari_kodu], [sth_cari_grup_no], [sth_isemri_gider_kodu], [sth_plasiyer_kodu], [sth_har_doviz_cinsi], [sth_har_doviz_kuru], [sth_alt_doviz_kuru], [sth_stok_doviz_cinsi], [sth_stok_doviz_kuru], [sth_miktar],     [sth_miktar2], [sth_birim_pntr],                  [sth_tutar], [sth_iskonto1], [sth_iskonto2], [sth_iskonto3], [sth_iskonto4], [sth_iskonto5], [sth_iskonto6], [sth_masraf1], [sth_masraf2], [sth_masraf3], [sth_masraf4], [sth_vergi_pntr], [sth_vergi], [sth_masraf_vergi_pntr], [sth_masraf_vergi], [sth_netagirlik], [sth_odeme_op], [sth_aciklama], [sth_sip_recid_dbcno], [sth_sip_recid_recno], [sth_fat_recid_dbcno], [sth_fat_recid_recno], [sth_giris_depo_no], [sth_cikis_depo_no], [sth_malkbl_sevk_tarihi], [sth_cari_srm_merkezi], [sth_stok_srm_merkezi], [sth_fis_tarihi],          [sth_fis_sirano], [sth_vergisiz_fl], [sth_maliyet_ana], [sth_maliyet_alternatif], [sth_maliyet_orjinal], [sth_adres_no], [sth_parti_kodu], [sth_lot_no], [sth_kons_recid_dbcno], [sth_kons_recid_recno], [sth_proje_kodu], [sth_exim_kodu], [sth_otv_pntr], [sth_otv_vergi], [sth_brutagirlik], [sth_disticaret_turu], [sth_otvtutari], [sth_otvvergisiz_fl], [sth_oiv_pntr], [sth_oiv_vergi], [sth_oivvergisiz_fl], [sth_fiyat_liste_no], [sth_oivtutari], [sth_Tevkifat_turu], [sth_nakliyedeposu], [sth_nakliyedurumu], [sth_yetkili_recid_dbcno], [sth_yetkili_recid_recno], [sth_taxfree_fl], [sth_ilave_edilecek_kdv]) 
                                                          VALUES ( 0                , -1               , 0,               0,             16,           0,             0,           0,              0, "+user_kod+ ",            GETDATE(), " + user_kod + ",               GETDATE(), N'',           N'',             N'',               0,           0,        CONVERT(DATE,GETDATE()),    0,          0,                0,            13,  N'" + txt_evrak_seri.Text + "',N'" + txt_evrak_sira.Text + "'," + setrno + " ,             N'',         CONVERT(DATE,GETDATE()), N'" + item.Kodu + "',            0,              0,            0,              0,                0,                  0,          0,              0,                 0,                   0,     0,                      0,          0,                      0,                   0,                  0,              0,                  0,                 0,                   0,                      1,         0,                      0,    N'" + txt_CariHkodu.Text + "',0,                 N'',                        N'',             0,                                  1,     3.6462,             0,                       1,   " + item.Miqdarı + "," + item.Miqdarı + ",                 1,              0,                 0,          0,              0,          0,                  0,             0,           0,                 0,               0,          0,          1,                 0,           0,                     0,                      0,                   0,         N'',                0,               0,                      0,       0,  '" + txt_srmMerkez.Text + "','" + txt_srmMerkez.Text + "',CONVERT(DATE,GETDATE()),N'" + txt_srmMerkez.Text + "',N'" + txt_srmMerkez.Text + "',          CONVERT(DATE,GETDATE()),        0 ,          1,                      0,                  0,                      0,                       0,                 N'',     0,              0,                 0,                          N'',                    N'',         0,          0,                 0,                  1,                       0,                 0,                   0,          0,                 0,                   0,                      0,             0,                      0,               0,                     0,                       0,                          0,                     0)  UPDATE [dbo].[STOK_HAREKETLERI] "+
                                       " SET [sth_RECid_RECno]=[sth_RECno] WHERE [sth_RECid_RECno] = -1"; 
                    comm.ExecuteNonQuery();
                    setrno++;
                }
            }
            tran.Commit();
            conn.Close();

            FPrintObject.Clear();
            for (int i = 0; i < 100; i++)
            {
                FaktLine cash3 = new FaktLine() { Kodu = "", Adı = "", Miqdarı = "", };
                FPrintObject.Add(cash3);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FPrintObject;
        }

        private void txt_evrak_seri_TextChanged(object sender, EventArgs e)
        {
            txt_evrak_sira.Text = "1";
            string connectionString = ConfigurationManager.ConnectionStrings["MicroDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = @"SELECT sth_evrakno_seri,max(sth_evrakno_sira)+1 sth_evrakno_sira
  FROM [dbo].[STOK_HAREKETLERI]
  where sth_evrakno_seri='"+ txt_evrak_seri.Text+ @"'
  group by sth_evrakno_seri";
            SqlDataReader reader= comm.ExecuteReader();
            while (reader.Read())
            {
              txt_evrak_sira.Text=  reader["sth_evrakno_sira"].ToString();
            }

        }

        private void txt_srmMerkez_TextChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MicroDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = @"select dep_no,dep_adi from MikroDB_V15_DISCOUNT.dbo.DEPOLAR where dep_no='"+ txt_srmMerkez.Text+"'";
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                txt_DepoNo.Text = reader["dep_adi"].ToString();
            }
        }
       

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int yourLastColumnIndex = dataGridView1.Columns.Count - 1;
            if (dataGridView1.Focused && keyData == Keys.Tab)
            {
                if (dataGridView1.CurrentCell.ColumnIndex == yourLastColumnIndex &&
            dataGridView1.CurrentRow.Index == dataGridView1.RowCount - 1)
                {
                    FaktLine cash = new FaktLine() { Kodu = "", Adı = "", Miqdarı = "", };
                    FPrintObject.Add(cash);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = FPrintObject;
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2];

                }
            }
            if (gridedit == true && keyData == Keys.Enter)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                dataGridView1.CurrentCell = dataGridView1.Rows[rowindex].Cells[1];
                string search = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
                string connectionString = ConfigurationManager.ConnectionStrings["MicroDB"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = @"select sto_kod, sto_isim from STOKLAR where
  sto_kod in (select bar_stokkodu
  from BARKOD_TANIMLARI
  WHERE bar_kodu LIKE '%" + search + "%' OR bar_stokkodu LIKE '%" + search + "%') and sto_sat_cari_kod = '" + txt_CariHkodu.Text + "'";
                SqlDataReader reader = comm.ExecuteReader();
                int RecordCount = 0;


                while (reader.Read())
                {
                    ++RecordCount;
                    if (RecordCount > 1)
                    {
                        break;
                    }

                    FaktLine currentObject = (FaktLine)dataGridView1.CurrentRow.DataBoundItem;

                    if (RecordCount == 1)
                    {
                        currentObject.Kodu = reader["sto_kod"].ToString();
                        currentObject.Adı = reader["sto_isim"].ToString();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = FPrintObject;
                    }
                }
                if (RecordCount == 0)
                {
                    MessageBox.Show("Kod və ya Cari Hesab səhv seçilib");
                }
            }
            
                  
                
                    
            if (gridedit==true && keyData == Keys.F10)
            {
                using (var form = new Frm_Stok())
                {
                   
                    int rowindex = dataGridView1.CurrentCell.RowIndex;
                    int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                    dataGridView1.CurrentCell = dataGridView1.Rows[rowindex].Cells[1];
                    form.ReturnValue1 = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
                    form.CariHesab = txt_CariHkodu.Text; 
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        FaktLine  currentObject = (FaktLine)dataGridView1.CurrentRow.DataBoundItem;
                        currentObject.Kodu=form.ReturnValue1;
                        currentObject.Adı = "";
                        string connectionString = ConfigurationManager.ConnectionStrings["MicroDB"].ConnectionString;
                        SqlConnection conn = new SqlConnection(connectionString);
                        conn.Open();
                        SqlCommand comm = conn.CreateCommand();
                        comm.CommandText = @"select sto_isim from STOKLAR WHERE sto_kod = '" + form.ReturnValue1 + "'";
                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            currentObject.Adı = reader["sto_isim"].ToString();
                        }
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = FPrintObject;
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txt_CariHkodu_TextChanged(object sender, EventArgs e)
        {
            txt_CariHAdi.Text = "";
            string connectionString = ConfigurationManager.ConnectionStrings["MicroDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = @"select top 1 cari_kod,cari_unvan1 from MikroDB_V15_DISCOUNT.dbo.CARI_HESAPLAR WHERE cari_kilitli!=1 and cari_kod = '"+ txt_CariHkodu.Text+"'";
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                txt_CariHAdi.Text = reader["cari_unvan1"].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var form = new Frm_CariHesab())
            {
                form.ReturnValue1 = txt_CariHkodu.Text;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txt_CariHkodu.Text = form.ReturnValue1;
                }
            }
       
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
          //  dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dataGridView1_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
           if(dataGridView1.CurrentCell.ColumnIndex == 2)
                MessageBox.Show("miqdar");
            gridedit = true;
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            gridedit = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex == 2)
            //{
            //    MessageBox.Show("miqdar xanasi");
            //}
        }
    }
}
