namespace WindowsFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtÜrünRengi = new System.Windows.Forms.TextBox();
            this.txtÜrünDepolamaKpasitesi = new System.Windows.Forms.TextBox();
            this.txtÜrünİşlemcisi = new System.Windows.Forms.TextBox();
            this.txtÜrünFiyatı = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kayıtekle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtÜrünAdedi = new System.Windows.Forms.TextBox();
            this.stoktakipDataSet1 = new WindowsFormsApp10.stoktakipDataSet1();
            this.stoktakipDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜRÜN RENGİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÜRÜN DEPOLAMA KAPASİTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÜRÜN İŞLEMCİSİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ÜRÜN FİYATI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ÜRÜN ADEDİ";
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(266, 9);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(100, 22);
            this.txtÜrünAdı.TabIndex = 6;
            // 
            // txtÜrünRengi
            // 
            this.txtÜrünRengi.Location = new System.Drawing.Point(298, 44);
            this.txtÜrünRengi.Name = "txtÜrünRengi";
            this.txtÜrünRengi.Size = new System.Drawing.Size(100, 22);
            this.txtÜrünRengi.TabIndex = 7;
            // 
            // txtÜrünDepolamaKpasitesi
            // 
            this.txtÜrünDepolamaKpasitesi.Location = new System.Drawing.Point(298, 84);
            this.txtÜrünDepolamaKpasitesi.Name = "txtÜrünDepolamaKpasitesi";
            this.txtÜrünDepolamaKpasitesi.Size = new System.Drawing.Size(100, 22);
            this.txtÜrünDepolamaKpasitesi.TabIndex = 8;
            // 
            // txtÜrünİşlemcisi
            // 
            this.txtÜrünİşlemcisi.Location = new System.Drawing.Point(215, 126);
            this.txtÜrünİşlemcisi.Name = "txtÜrünİşlemcisi";
            this.txtÜrünİşlemcisi.Size = new System.Drawing.Size(100, 22);
            this.txtÜrünİşlemcisi.TabIndex = 9;
            // 
            // txtÜrünFiyatı
            // 
            this.txtÜrünFiyatı.Location = new System.Drawing.Point(198, 160);
            this.txtÜrünFiyatı.Name = "txtÜrünFiyatı";
            this.txtÜrünFiyatı.Size = new System.Drawing.Size(100, 22);
            this.txtÜrünFiyatı.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.stoktakipDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 199);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // kayıtekle
            // 
            this.kayıtekle.Location = new System.Drawing.Point(531, 50);
            this.kayıtekle.Name = "kayıtekle";
            this.kayıtekle.Size = new System.Drawing.Size(75, 67);
            this.kayıtekle.TabIndex = 12;
            this.kayıtekle.Text = "KAYIT EKLE";
            this.kayıtekle.UseVisualStyleBackColor = true;
            this.kayıtekle.Click += new System.EventHandler(this.kayıtekle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 13;
            this.button2.Text = "KAYIT SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 14;
            this.button1.Text = "KAYIT GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtÜrünAdedi
            // 
            this.txtÜrünAdedi.Location = new System.Drawing.Point(198, 197);
            this.txtÜrünAdedi.Name = "txtÜrünAdedi";
            this.txtÜrünAdedi.Size = new System.Drawing.Size(100, 22);
            this.txtÜrünAdedi.TabIndex = 15;
            // 
            // stoktakipDataSet1
            // 
            this.stoktakipDataSet1.DataSetName = "stoktakipDataSet1";
            this.stoktakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stoktakipDataSet1BindingSource
            // 
            this.stoktakipDataSet1BindingSource.DataSource = this.stoktakipDataSet1;
            this.stoktakipDataSet1BindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtÜrünAdedi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kayıtekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtÜrünFiyatı);
            this.Controls.Add(this.txtÜrünİşlemcisi);
            this.Controls.Add(this.txtÜrünDepolamaKpasitesi);
            this.Controls.Add(this.txtÜrünRengi);
            this.Controls.Add(this.txtÜrünAdı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktakipDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.TextBox txtÜrünRengi;
        private System.Windows.Forms.TextBox txtÜrünDepolamaKpasitesi;
        private System.Windows.Forms.TextBox txtÜrünİşlemcisi;
        private System.Windows.Forms.TextBox txtÜrünFiyatı;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kayıtekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtÜrünAdedi;
        private System.Windows.Forms.BindingSource stoktakipDataSet1BindingSource;
        private stoktakipDataSet1 stoktakipDataSet1;
    }
}

