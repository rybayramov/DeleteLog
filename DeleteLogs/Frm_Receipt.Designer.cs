namespace DeleteLogs
{
    partial class Frm_Receipt
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_evrak_seri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CariHkodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CariHAdi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_srmMerkez = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DepoNo = new System.Windows.Forms.TextBox();
            this.txt_evrak_sira = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.koduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miqdarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faktLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faktLineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(287, 181);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.koduDataGridViewTextBoxColumn,
            this.adıDataGridViewTextBoxColumn,
            this.miqdarıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.faktLineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 316);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dataGridView1_CancelRowEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(677, 455);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 35);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Saxla";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "İmtina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_evrak_seri
            // 
            this.txt_evrak_seri.Enabled = false;
            this.txt_evrak_seri.Location = new System.Drawing.Point(94, 37);
            this.txt_evrak_seri.Name = "txt_evrak_seri";
            this.txt_evrak_seri.Size = new System.Drawing.Size(52, 20);
            this.txt_evrak_seri.TabIndex = 4;
            this.txt_evrak_seri.Text = "101";
            this.txt_evrak_seri.TextChanged += new System.EventHandler(this.txt_evrak_seri_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sənəd nöm.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "C/H Kodu";
            // 
            // txt_CariHkodu
            // 
            this.txt_CariHkodu.Location = new System.Drawing.Point(94, 63);
            this.txt_CariHkodu.Name = "txt_CariHkodu";
            this.txt_CariHkodu.Size = new System.Drawing.Size(117, 20);
            this.txt_CariHkodu.TabIndex = 6;
            this.txt_CariHkodu.Text = "0261";
            this.txt_CariHkodu.TextChanged += new System.EventHandler(this.txt_CariHkodu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "C/H Adı";
            // 
            // txt_CariHAdi
            // 
            this.txt_CariHAdi.Location = new System.Drawing.Point(94, 89);
            this.txt_CariHAdi.Name = "txt_CariHAdi";
            this.txt_CariHAdi.Size = new System.Drawing.Size(177, 20);
            this.txt_CariHAdi.TabIndex = 8;
            this.txt_CariHAdi.Text = "YE DOY MMC";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tarix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tarix";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(396, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sorum mrkz.";
            // 
            // txt_srmMerkez
            // 
            this.txt_srmMerkez.Enabled = false;
            this.txt_srmMerkez.Location = new System.Drawing.Point(638, 37);
            this.txt_srmMerkez.Name = "txt_srmMerkez";
            this.txt_srmMerkez.Size = new System.Drawing.Size(56, 20);
            this.txt_srmMerkez.TabIndex = 14;
            this.txt_srmMerkez.Text = "101";
            this.txt_srmMerkez.TextChanged += new System.EventHandler(this.txt_srmMerkez_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Qəbul tarixi";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(638, 66);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Depo";
            // 
            // txt_DepoNo
            // 
            this.txt_DepoNo.Enabled = false;
            this.txt_DepoNo.Location = new System.Drawing.Point(638, 92);
            this.txt_DepoNo.Name = "txt_DepoNo";
            this.txt_DepoNo.Size = new System.Drawing.Size(159, 20);
            this.txt_DepoNo.TabIndex = 18;
            this.txt_DepoNo.Text = "DISCOUNT101";
            // 
            // txt_evrak_sira
            // 
            this.txt_evrak_sira.Enabled = false;
            this.txt_evrak_sira.Location = new System.Drawing.Point(152, 37);
            this.txt_evrak_sira.Name = "txt_evrak_sira";
            this.txt_evrak_sira.Size = new System.Drawing.Size(59, 20);
            this.txt_evrak_sira.TabIndex = 20;
            this.txt_evrak_sira.Text = "178";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 20);
            this.button4.TabIndex = 22;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 20);
            this.button5.TabIndex = 23;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // koduDataGridViewTextBoxColumn
            // 
            this.koduDataGridViewTextBoxColumn.DataPropertyName = "Kodu";
            this.koduDataGridViewTextBoxColumn.HeaderText = "Kodu";
            this.koduDataGridViewTextBoxColumn.Name = "koduDataGridViewTextBoxColumn";
            this.koduDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // adıDataGridViewTextBoxColumn
            // 
            this.adıDataGridViewTextBoxColumn.DataPropertyName = "Adı";
            this.adıDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adıDataGridViewTextBoxColumn.Name = "adıDataGridViewTextBoxColumn";
            // 
            // miqdarıDataGridViewTextBoxColumn
            // 
            this.miqdarıDataGridViewTextBoxColumn.DataPropertyName = "Miqdarı";
            this.miqdarıDataGridViewTextBoxColumn.HeaderText = "Miqdarı";
            this.miqdarıDataGridViewTextBoxColumn.Name = "miqdarıDataGridViewTextBoxColumn";
            // 
            // faktLineBindingSource
            // 
            this.faktLineBindingSource.DataSource = typeof(DeleteLogs.Frm_Receipt.FaktLine);
            // 
            // Frm_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 490);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_evrak_sira);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_DepoNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_srmMerkez);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CariHAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CariHkodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_evrak_seri);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewX1);
            this.Name = "Frm_Receipt";
            this.Text = "Alış qaiməsi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faktLineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_evrak_seri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CariHkodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CariHAdi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_srmMerkez;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DepoNo;
        private System.Windows.Forms.TextBox txt_evrak_sira;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource faktLineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn koduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miqdarıDataGridViewTextBoxColumn;
    }
}

