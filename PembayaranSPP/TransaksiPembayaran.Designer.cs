
namespace PembayaranSPP
{
    partial class TransaksiPembayaran
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBulan = new System.Windows.Forms.ComboBox();
            this.tgl_bayar = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJB = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtTHN = new System.Windows.Forms.TextBox();
            this.txtID_Pegawai = new System.Windows.Forms.TextBox();
            this.btnBersih = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIS = new System.Windows.Forms.TextBox();
            this.txtID_SPP = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBaru = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dg_tp = new System.Windows.Forms.DataGridView();
            this.txtID_Pembayaran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 482);
            this.panel2.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtID_Pembayaran);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBulan);
            this.panel3.Controls.Add(this.tgl_bayar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtJB);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnHapus);
            this.panel3.Controls.Add(this.txtTHN);
            this.panel3.Controls.Add(this.txtID_Pegawai);
            this.panel3.Controls.Add(this.btnBersih);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnSimpan);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtNIS);
            this.panel3.Controls.Add(this.txtID_SPP);
            this.panel3.Location = new System.Drawing.Point(10, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 222);
            this.panel3.TabIndex = 58;
            // 
            // comboBulan
            // 
            this.comboBulan.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBulan.FormattingEnabled = true;
            this.comboBulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.comboBulan.Location = new System.Drawing.Point(456, 35);
            this.comboBulan.Name = "comboBulan";
            this.comboBulan.Size = new System.Drawing.Size(199, 27);
            this.comboBulan.TabIndex = 74;
            // 
            // tgl_bayar
            // 
            this.tgl_bayar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl_bayar.Location = new System.Drawing.Point(456, 100);
            this.tgl_bayar.Name = "tgl_bayar";
            this.tgl_bayar.Size = new System.Drawing.Size(199, 25);
            this.tgl_bayar.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 67;
            this.label7.Text = "Jumlah Bayar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(452, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 66;
            this.label10.Text = "Tanggal Bayar";
            // 
            // txtJB
            // 
            this.txtJB.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJB.Location = new System.Drawing.Point(235, 166);
            this.txtJB.Multiline = true;
            this.txtJB.Name = "txtJB";
            this.txtJB.Size = new System.Drawing.Size(201, 30);
            this.txtJB.TabIndex = 64;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.Location = new System.Drawing.Point(680, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 33);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "ID SPP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tahun dibayar";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnHapus.FlatAppearance.BorderSize = 2;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Blue;
            this.btnHapus.Location = new System.Drawing.Point(680, 112);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(198, 33);
            this.btnHapus.TabIndex = 73;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtTHN
            // 
            this.txtTHN.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTHN.Location = new System.Drawing.Point(237, 35);
            this.txtTHN.Multiline = true;
            this.txtTHN.Name = "txtTHN";
            this.txtTHN.Size = new System.Drawing.Size(201, 30);
            this.txtTHN.TabIndex = 59;
            // 
            // txtID_Pegawai
            // 
            this.txtID_Pegawai.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Pegawai.Location = new System.Drawing.Point(14, 102);
            this.txtID_Pegawai.Multiline = true;
            this.txtID_Pegawai.Name = "txtID_Pegawai";
            this.txtID_Pegawai.Size = new System.Drawing.Size(201, 30);
            this.txtID_Pegawai.TabIndex = 50;
            // 
            // btnBersih
            // 
            this.btnBersih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBersih.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBersih.FlatAppearance.BorderSize = 2;
            this.btnBersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBersih.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBersih.ForeColor = System.Drawing.Color.Blue;
            this.btnBersih.Location = new System.Drawing.Point(680, 151);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.Size = new System.Drawing.Size(198, 33);
            this.btnBersih.TabIndex = 69;
            this.btnBersih.Text = "Bersih";
            this.btnBersih.UseVisualStyleBackColor = false;
            this.btnBersih.Click += new System.EventHandler(this.btnBersih_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "NIS";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSimpan.FlatAppearance.BorderSize = 2;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.Blue;
            this.btnSimpan.Location = new System.Drawing.Point(680, 32);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(198, 33);
            this.btnSimpan.TabIndex = 71;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Bulan dibayar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "ID Pegawai";
            // 
            // txtNIS
            // 
            this.txtNIS.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIS.Location = new System.Drawing.Point(14, 166);
            this.txtNIS.Multiline = true;
            this.txtNIS.Name = "txtNIS";
            this.txtNIS.Size = new System.Drawing.Size(201, 30);
            this.txtNIS.TabIndex = 57;
            // 
            // txtID_SPP
            // 
            this.txtID_SPP.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_SPP.Location = new System.Drawing.Point(235, 101);
            this.txtID_SPP.Multiline = true;
            this.txtID_SPP.Name = "txtID_SPP";
            this.txtID_SPP.Size = new System.Drawing.Size(201, 30);
            this.txtID_SPP.TabIndex = 52;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnBaru);
            this.panel4.Controls.Add(this.txtCari);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dg_tp);
            this.panel4.Location = new System.Drawing.Point(10, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(903, 229);
            this.panel4.TabIndex = 56;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(680, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 33);
            this.btnExit.TabIndex = 74;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 22);
            this.label9.TabIndex = 63;
            this.label9.Text = "Transaksi Pembayaran";
            // 
            // btnBaru
            // 
            this.btnBaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBaru.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBaru.FlatAppearance.BorderSize = 2;
            this.btnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaru.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaru.ForeColor = System.Drawing.Color.Blue;
            this.btnBaru.Location = new System.Drawing.Point(680, 136);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(198, 33);
            this.btnBaru.TabIndex = 72;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = false;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(456, 14);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(201, 30);
            this.txtCari.TabIndex = 61;
            this.txtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCari_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "Cari";
            // 
            // dg_tp
            // 
            this.dg_tp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tp.Location = new System.Drawing.Point(14, 50);
            this.dg_tp.Name = "dg_tp";
            this.dg_tp.Size = new System.Drawing.Size(643, 157);
            this.dg_tp.TabIndex = 57;
            this.dg_tp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_tp_CellClick);
            // 
            // txtID_Pembayaran
            // 
            this.txtID_Pembayaran.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Pembayaran.Location = new System.Drawing.Point(14, 35);
            this.txtID_Pembayaran.Multiline = true;
            this.txtID_Pembayaran.Name = "txtID_Pembayaran";
            this.txtID_Pembayaran.Size = new System.Drawing.Size(201, 30);
            this.txtID_Pembayaran.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 76;
            this.label1.Text = "ID Pembayaran";
            // 
            // TransaksiPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(947, 504);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TransaksiPembayaran";
            this.Text = "Transaksi Pembayaran";
            this.Load += new System.EventHandler(this.TransaksiPembayaran_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTHN;
        private System.Windows.Forms.TextBox txtID_Pegawai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNIS;
        private System.Windows.Forms.TextBox txtID_SPP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_tp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJB;
        private System.Windows.Forms.DateTimePicker tgl_bayar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersih;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.ComboBox comboBulan;
        private System.Windows.Forms.TextBox txtID_Pembayaran;
        private System.Windows.Forms.Label label1;
    }
}