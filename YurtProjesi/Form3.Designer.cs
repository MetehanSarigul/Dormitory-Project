namespace YurtProjesi
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİstatistiğiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erişimKolaylığıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtProjeDataSet3 = new YurtProjesi.YurtProjeDataSet3();
            this.tblOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOgrenciTableAdapter = new YurtProjesi.YurtProjeDataSet3TableAdapters.TblOgrenciTableAdapter();
            this.ogrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtProjeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerToolStripMenuItem,
            this.bölümlerToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.istatistikToolStripMenuItem,
            this.yöneticiToolStripMenuItem,
            this.erişimKolaylığıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKayıtToolStripMenuItem,
            this.öğrenciDüzenlemeToolStripMenuItem});
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(131, 34);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciKayıtToolStripMenuItem
            // 
            this.öğrenciKayıtToolStripMenuItem.Name = "öğrenciKayıtToolStripMenuItem";
            this.öğrenciKayıtToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.öğrenciKayıtToolStripMenuItem.Text = "Öğrenci Kayıt";
            this.öğrenciKayıtToolStripMenuItem.Click += new System.EventHandler(this.öğrenciKayıtToolStripMenuItem_Click);
            // 
            // öğrenciDüzenlemeToolStripMenuItem
            // 
            this.öğrenciDüzenlemeToolStripMenuItem.Name = "öğrenciDüzenlemeToolStripMenuItem";
            this.öğrenciDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.öğrenciDüzenlemeToolStripMenuItem.Text = "Öğrenci Düzenleme";
            this.öğrenciDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDüzenlemeToolStripMenuItem_Click);
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümİşlemleriToolStripMenuItem});
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(116, 34);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümİşlemleriToolStripMenuItem
            // 
            this.bölümİşlemleriToolStripMenuItem.Name = "bölümİşlemleriToolStripMenuItem";
            this.bölümİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.bölümİşlemleriToolStripMenuItem.Text = "Bölüm İşlemleri";
            this.bölümİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.bölümİşlemleriToolStripMenuItem_Click);
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeAlmaToolStripMenuItem});
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(127, 34);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // ödemeAlmaToolStripMenuItem
            // 
            this.ödemeAlmaToolStripMenuItem.Name = "ödemeAlmaToolStripMenuItem";
            this.ödemeAlmaToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.ödemeAlmaToolStripMenuItem.Text = "Ödeme Alma";
            this.ödemeAlmaToolStripMenuItem.Click += new System.EventHandler(this.ödemeAlmaToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderDüzenlemeToolStripMenuItem});
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(107, 34);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // giderDüzenlemeToolStripMenuItem
            // 
            this.giderDüzenlemeToolStripMenuItem.Name = "giderDüzenlemeToolStripMenuItem";
            this.giderDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.giderDüzenlemeToolStripMenuItem.Text = "Gider Düzenleme";
            this.giderDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.giderDüzenlemeToolStripMenuItem_Click);
            // 
            // istatistikToolStripMenuItem
            // 
            this.istatistikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİstatistiğiToolStripMenuItem});
            this.istatistikToolStripMenuItem.Name = "istatistikToolStripMenuItem";
            this.istatistikToolStripMenuItem.Size = new System.Drawing.Size(106, 34);
            this.istatistikToolStripMenuItem.Text = "İstatistik";
            // 
            // gelirİstatistiğiToolStripMenuItem
            // 
            this.gelirİstatistiğiToolStripMenuItem.Name = "gelirİstatistiğiToolStripMenuItem";
            this.gelirİstatistiğiToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.gelirİstatistiğiToolStripMenuItem.Text = "Gelir İstatistiği";
            this.gelirİstatistiğiToolStripMenuItem.Click += new System.EventHandler(this.gelirİstatistiğiToolStripMenuItem_Click);
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiDüzenlemeToolStripMenuItem,
            this.personelDüzenlemeToolStripMenuItem});
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(103, 34);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // yöneticiDüzenlemeToolStripMenuItem
            // 
            this.yöneticiDüzenlemeToolStripMenuItem.Name = "yöneticiDüzenlemeToolStripMenuItem";
            this.yöneticiDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(313, 38);
            this.yöneticiDüzenlemeToolStripMenuItem.Text = "Yönetici Düzenleme";
            this.yöneticiDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.yöneticiDüzenlemeToolStripMenuItem_Click);
            // 
            // personelDüzenlemeToolStripMenuItem
            // 
            this.personelDüzenlemeToolStripMenuItem.Name = "personelDüzenlemeToolStripMenuItem";
            this.personelDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(313, 38);
            this.personelDüzenlemeToolStripMenuItem.Text = "Personel Düzenleme";
            this.personelDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.personelDüzenlemeToolStripMenuItem_Click);
            // 
            // erişimKolaylığıToolStripMenuItem
            // 
            this.erişimKolaylığıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.erişimKolaylığıToolStripMenuItem.Name = "erişimKolaylığıToolStripMenuItem";
            this.erişimKolaylığıToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.erişimKolaylığıToolStripMenuItem.Text = "Erişim Kolaylığı";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(865, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 413);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktif Öğrenciler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIdDataGridViewTextBoxColumn,
            this.ogrAdSoyadDataGridViewTextBoxColumn,
            this.ogrTcDataGridViewTextBoxColumn,
            this.ogrTelDataGridViewTextBoxColumn,
            this.ogrDogumDataGridViewTextBoxColumn,
            this.ogrBolumDataGridViewTextBoxColumn,
            this.ogrMailDataGridViewTextBoxColumn,
            this.ogrOdaNoDataGridViewTextBoxColumn,
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn,
            this.ogrVeliTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOgrenciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(739, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // yurtProjeDataSet3
            // 
            this.yurtProjeDataSet3.DataSetName = "YurtProjeDataSet3";
            this.yurtProjeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrenciBindingSource
            // 
            this.tblOgrenciBindingSource.DataMember = "TblOgrenci";
            this.tblOgrenciBindingSource.DataSource = this.yurtProjeDataSet3;
            // 
            // tblOgrenciTableAdapter
            // 
            this.tblOgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogrIdDataGridViewTextBoxColumn
            // 
            this.ogrIdDataGridViewTextBoxColumn.DataPropertyName = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.HeaderText = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrIdDataGridViewTextBoxColumn.Name = "ogrIdDataGridViewTextBoxColumn";
            this.ogrIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrAdSoyadDataGridViewTextBoxColumn
            // 
            this.ogrAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrAdSoyad";
            this.ogrAdSoyadDataGridViewTextBoxColumn.HeaderText = "Ad-Soyad";
            this.ogrAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrAdSoyadDataGridViewTextBoxColumn.Name = "ogrAdSoyadDataGridViewTextBoxColumn";
            this.ogrAdSoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrTcDataGridViewTextBoxColumn
            // 
            this.ogrTcDataGridViewTextBoxColumn.DataPropertyName = "OgrTc";
            this.ogrTcDataGridViewTextBoxColumn.HeaderText = "TC";
            this.ogrTcDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrTcDataGridViewTextBoxColumn.Name = "ogrTcDataGridViewTextBoxColumn";
            this.ogrTcDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrTelDataGridViewTextBoxColumn
            // 
            this.ogrTelDataGridViewTextBoxColumn.DataPropertyName = "OgrTel";
            this.ogrTelDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.ogrTelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrTelDataGridViewTextBoxColumn.Name = "ogrTelDataGridViewTextBoxColumn";
            this.ogrTelDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrDogumDataGridViewTextBoxColumn
            // 
            this.ogrDogumDataGridViewTextBoxColumn.DataPropertyName = "OgrDogum";
            this.ogrDogumDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.ogrDogumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrDogumDataGridViewTextBoxColumn.Name = "ogrDogumDataGridViewTextBoxColumn";
            this.ogrDogumDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrBolumDataGridViewTextBoxColumn
            // 
            this.ogrBolumDataGridViewTextBoxColumn.DataPropertyName = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            this.ogrBolumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrBolumDataGridViewTextBoxColumn.Name = "ogrBolumDataGridViewTextBoxColumn";
            this.ogrBolumDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrMailDataGridViewTextBoxColumn
            // 
            this.ogrMailDataGridViewTextBoxColumn.DataPropertyName = "OgrMail";
            this.ogrMailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.ogrMailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrMailDataGridViewTextBoxColumn.Name = "ogrMailDataGridViewTextBoxColumn";
            this.ogrMailDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.HeaderText = "Oda Numarası";
            this.ogrOdaNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrOdaNoDataGridViewTextBoxColumn.Name = "ogrOdaNoDataGridViewTextBoxColumn";
            this.ogrOdaNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdSoyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "Veli Ad-Soyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.Name = "ogrVeliAdSoyadDataGridViewTextBoxColumn";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ogrVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliTelefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.HeaderText = "Veli Telefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrVeliTelefonDataGridViewTextBoxColumn.Name = "ogrVeliTelefonDataGridViewTextBoxColumn";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1039, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form3";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtProjeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erişimKolaylığıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİstatistiğiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtProjeDataSet3 yurtProjeDataSet3;
        private System.Windows.Forms.BindingSource tblOgrenciBindingSource;
        private YurtProjeDataSet3TableAdapters.TblOgrenciTableAdapter tblOgrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliTelefonDataGridViewTextBoxColumn;
    }
}