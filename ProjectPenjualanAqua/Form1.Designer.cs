namespace ProjectPenjualanAqua
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDataPegawai = new System.Windows.Forms.Button();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.btnGudang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(328, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENU UTAMA";
            // 
            // btnDataPegawai
            // 
            this.btnDataPegawai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDataPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataPegawai.ForeColor = System.Drawing.Color.White;
            this.btnDataPegawai.Location = new System.Drawing.Point(176, 342);
            this.btnDataPegawai.Name = "btnDataPegawai";
            this.btnDataPegawai.Size = new System.Drawing.Size(132, 43);
            this.btnDataPegawai.TabIndex = 2;
            this.btnDataPegawai.Text = "Data Pelanggan";
            this.btnDataPegawai.UseVisualStyleBackColor = false;
            this.btnDataPegawai.Click += new System.EventHandler(this.btnDataPegawai_Click);
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjualan.ForeColor = System.Drawing.Color.White;
            this.btnPenjualan.Location = new System.Drawing.Point(519, 342);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(132, 43);
            this.btnPenjualan.TabIndex = 3;
            this.btnPenjualan.Text = "Penjualan";
            this.btnPenjualan.UseVisualStyleBackColor = false;
            this.btnPenjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // btnGudang
            // 
            this.btnGudang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGudang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGudang.ForeColor = System.Drawing.Color.White;
            this.btnGudang.Location = new System.Drawing.Point(349, 342);
            this.btnGudang.Name = "btnGudang";
            this.btnGudang.Size = new System.Drawing.Size(132, 43);
            this.btnGudang.TabIndex = 4;
            this.btnGudang.Text = "Gudang";
            this.btnGudang.UseVisualStyleBackColor = false;
            this.btnGudang.Click += new System.EventHandler(this.btnGudang_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(847, 477);
            this.Controls.Add(this.btnGudang);
            this.Controls.Add(this.btnPenjualan);
            this.Controls.Add(this.btnDataPegawai);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ToolStripMenu1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGudangToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDataPegawai;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button btnGudang;
    }
}

