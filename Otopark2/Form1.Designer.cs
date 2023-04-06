namespace Otopark2
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
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBilgi = new System.Windows.Forms.GroupBox();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.txtGirişSaati = new System.Windows.Forms.TextBox();
            this.lblGirişSaati = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtYer = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblYer = new System.Windows.Forms.Label();
            this.txtCikisTarihi = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblKalınanSüre = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN5 = new System.Windows.Forms.Label();
            this.lblN6 = new System.Windows.Forms.Label();
            this.lblN7 = new System.Windows.Forms.Label();
            this.lblN8 = new System.Windows.Forms.Label();
            this.lblN9 = new System.Windows.Forms.Label();
            this.lblN10 = new System.Windows.Forms.Label();
            this.lblN11 = new System.Windows.Forms.Label();
            this.lblN12 = new System.Windows.Forms.Label();
            this.lblN13 = new System.Windows.Forms.Label();
            this.lblN14 = new System.Windows.Forms.Label();
            this.lblN15 = new System.Windows.Forms.Label();
            this.lblN16 = new System.Windows.Forms.Label();
            this.lblN17 = new System.Windows.Forms.Label();
            this.lblN18 = new System.Windows.Forms.Label();
            this.lblN19 = new System.Windows.Forms.Label();
            this.lblN20 = new System.Windows.Forms.Label();
            this.grpBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 37);
            this.label2.TabIndex = 40;
            this.label2.Text = "Araç Sorgula";
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.Location = new System.Drawing.Point(12, 81);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(80, 25);
            this.lblAra.TabIndex = 39;
            this.lblAra.Text = "Arama:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(98, 87);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(458, 20);
            this.txtAra.TabIndex = 38;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(778, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "Araç Ekle";
            // 
            // grpBilgi
            // 
            this.grpBilgi.Controls.Add(this.dtpGirisTarihi);
            this.grpBilgi.Controls.Add(this.btnSil);
            this.grpBilgi.Controls.Add(this.lblGirisTarihi);
            this.grpBilgi.Controls.Add(this.txtGirişSaati);
            this.grpBilgi.Controls.Add(this.lblGirişSaati);
            this.grpBilgi.Controls.Add(this.btnGüncelle);
            this.grpBilgi.Controls.Add(this.txtYer);
            this.grpBilgi.Controls.Add(this.btnCikis);
            this.grpBilgi.Controls.Add(this.btnEkle);
            this.grpBilgi.Controls.Add(this.lblYer);
            this.grpBilgi.Controls.Add(this.txtCikisTarihi);
            this.grpBilgi.Controls.Add(this.txtUcret);
            this.grpBilgi.Controls.Add(this.lblCikisTarihi);
            this.grpBilgi.Controls.Add(this.lblUcret);
            this.grpBilgi.Controls.Add(this.txtTelefon);
            this.grpBilgi.Controls.Add(this.lblTelefon);
            this.grpBilgi.Controls.Add(this.txtRenk);
            this.grpBilgi.Controls.Add(this.lblRenk);
            this.grpBilgi.Controls.Add(this.txtMarka);
            this.grpBilgi.Controls.Add(this.lblMarka);
            this.grpBilgi.Controls.Add(this.txtPlaka);
            this.grpBilgi.Controls.Add(this.lblPlaka);
            this.grpBilgi.Controls.Add(this.txtAdSoyad);
            this.grpBilgi.Controls.Add(this.lblAdSoyad);
            this.grpBilgi.Location = new System.Drawing.Point(757, 81);
            this.grpBilgi.Name = "grpBilgi";
            this.grpBilgi.Size = new System.Drawing.Size(370, 571);
            this.grpBilgi.TabIndex = 36;
            this.grpBilgi.TabStop = false;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(155, 245);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpGirisTarihi.TabIndex = 40;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(135, 534);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(116, 31);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisTarihi.Location = new System.Drawing.Point(9, 247);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(86, 19);
            this.lblGirisTarihi.TabIndex = 35;
            this.lblGirisTarihi.Text = "Giriş Tarihi :";
            // 
            // txtGirişSaati
            // 
            this.txtGirişSaati.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtGirişSaati.Location = new System.Drawing.Point(158, 292);
            this.txtGirişSaati.Name = "txtGirişSaati";
            this.txtGirişSaati.Size = new System.Drawing.Size(197, 21);
            this.txtGirişSaati.TabIndex = 36;
            // 
            // lblGirişSaati
            // 
            this.lblGirişSaati.AutoSize = true;
            this.lblGirişSaati.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirişSaati.Location = new System.Drawing.Point(9, 294);
            this.lblGirişSaati.Name = "lblGirişSaati";
            this.lblGirişSaati.Size = new System.Drawing.Size(84, 19);
            this.lblGirişSaati.TabIndex = 35;
            this.lblGirişSaati.Text = "Giriş Saati :";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.LightBlue;
            this.btnGüncelle.Location = new System.Drawing.Point(135, 497);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(116, 31);
            this.btnGüncelle.TabIndex = 32;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtYer
            // 
            this.txtYer.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtYer.Location = new System.Drawing.Point(158, 424);
            this.txtYer.Name = "txtYer";
            this.txtYer.Size = new System.Drawing.Size(197, 21);
            this.txtYer.TabIndex = 31;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCikis.Location = new System.Drawing.Point(13, 534);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(116, 31);
            this.btnCikis.TabIndex = 29;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Location = new System.Drawing.Point(13, 497);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(116, 31);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Giriş";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblYer
            // 
            this.lblYer.AutoSize = true;
            this.lblYer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYer.Location = new System.Drawing.Point(9, 426);
            this.lblYer.Name = "lblYer";
            this.lblYer.Size = new System.Drawing.Size(35, 19);
            this.lblYer.TabIndex = 26;
            this.lblYer.Text = "Yer:";
            // 
            // txtCikisTarihi
            // 
            this.txtCikisTarihi.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtCikisTarihi.Location = new System.Drawing.Point(158, 335);
            this.txtCikisTarihi.Name = "txtCikisTarihi";
            this.txtCikisTarihi.Size = new System.Drawing.Size(197, 21);
            this.txtCikisTarihi.TabIndex = 25;
            // 
            // txtUcret
            // 
            this.txtUcret.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtUcret.Location = new System.Drawing.Point(158, 380);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(197, 21);
            this.txtUcret.TabIndex = 25;
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisTarihi.Location = new System.Drawing.Point(6, 337);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(87, 19);
            this.lblCikisTarihi.TabIndex = 24;
            this.lblCikisTarihi.Text = "Çıkış Tarihi :";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.Location = new System.Drawing.Point(6, 382);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(103, 19);
            this.lblUcret.TabIndex = 24;
            this.lblUcret.Text = "Saatlik Ücret :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtTelefon.Location = new System.Drawing.Point(158, 198);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(197, 21);
            this.txtTelefon.TabIndex = 19;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(9, 200);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(102, 19);
            this.lblTelefon.TabIndex = 18;
            this.lblTelefon.Text = "Cep Telefonu :";
            // 
            // txtRenk
            // 
            this.txtRenk.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtRenk.Location = new System.Drawing.Point(155, 150);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(197, 21);
            this.txtRenk.TabIndex = 17;
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.Location = new System.Drawing.Point(6, 152);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(49, 19);
            this.lblRenk.TabIndex = 16;
            this.lblRenk.Text = "Renk :";
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtMarka.Location = new System.Drawing.Point(155, 102);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(197, 21);
            this.txtMarka.TabIndex = 15;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(6, 104);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(58, 19);
            this.lblMarka.TabIndex = 14;
            this.lblMarka.Text = "Marka :";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtPlaka.Location = new System.Drawing.Point(155, 56);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(197, 21);
            this.txtPlaka.TabIndex = 13;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.Location = new System.Drawing.Point(6, 58);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(53, 19);
            this.lblPlaka.TabIndex = 12;
            this.lblPlaka.Text = "Plaka :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtAdSoyad.Location = new System.Drawing.Point(155, 14);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(197, 21);
            this.txtAdSoyad.TabIndex = 11;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(6, 16);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(135, 19);
            this.lblAdSoyad.TabIndex = 10;
            this.lblAdSoyad.Text = "Müşteri Ad-Soyad :";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(4, 115);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(552, 544);
            this.dgwProducts.TabIndex = 35;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // lblKalınanSüre
            // 
            this.lblKalınanSüre.AutoSize = true;
            this.lblKalınanSüre.Location = new System.Drawing.Point(562, 592);
            this.lblKalınanSüre.Name = "lblKalınanSüre";
            this.lblKalınanSüre.Size = new System.Drawing.Size(73, 13);
            this.lblKalınanSüre.TabIndex = 41;
            this.lblKalınanSüre.Text = "Kalınan Süre :";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.BackColor = System.Drawing.Color.Green;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN1.Location = new System.Drawing.Point(576, 115);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(46, 29);
            this.lblN1.TabIndex = 42;
            this.lblN1.Text = "N1";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.BackColor = System.Drawing.Color.Green;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN2.Location = new System.Drawing.Point(576, 160);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(46, 29);
            this.lblN2.TabIndex = 42;
            this.lblN2.Text = "N2";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.BackColor = System.Drawing.Color.Green;
            this.lblN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN3.Location = new System.Drawing.Point(576, 207);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(46, 29);
            this.lblN3.TabIndex = 42;
            this.lblN3.Text = "N3";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.BackColor = System.Drawing.Color.Green;
            this.lblN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN4.Location = new System.Drawing.Point(576, 257);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(46, 29);
            this.lblN4.TabIndex = 42;
            this.lblN4.Text = "N4";
            // 
            // lblN5
            // 
            this.lblN5.AutoSize = true;
            this.lblN5.BackColor = System.Drawing.Color.Green;
            this.lblN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN5.Location = new System.Drawing.Point(576, 309);
            this.lblN5.Name = "lblN5";
            this.lblN5.Size = new System.Drawing.Size(46, 29);
            this.lblN5.TabIndex = 42;
            this.lblN5.Text = "N5";
            // 
            // lblN6
            // 
            this.lblN6.AutoSize = true;
            this.lblN6.BackColor = System.Drawing.Color.Green;
            this.lblN6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN6.Location = new System.Drawing.Point(576, 359);
            this.lblN6.Name = "lblN6";
            this.lblN6.Size = new System.Drawing.Size(46, 29);
            this.lblN6.TabIndex = 42;
            this.lblN6.Text = "N6";
            // 
            // lblN7
            // 
            this.lblN7.AutoSize = true;
            this.lblN7.BackColor = System.Drawing.Color.Green;
            this.lblN7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN7.Location = new System.Drawing.Point(576, 407);
            this.lblN7.Name = "lblN7";
            this.lblN7.Size = new System.Drawing.Size(46, 29);
            this.lblN7.TabIndex = 42;
            this.lblN7.Text = "N7";
            // 
            // lblN8
            // 
            this.lblN8.AutoSize = true;
            this.lblN8.BackColor = System.Drawing.Color.Green;
            this.lblN8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN8.Location = new System.Drawing.Point(576, 457);
            this.lblN8.Name = "lblN8";
            this.lblN8.Size = new System.Drawing.Size(46, 29);
            this.lblN8.TabIndex = 42;
            this.lblN8.Text = "N8";
            // 
            // lblN9
            // 
            this.lblN9.AutoSize = true;
            this.lblN9.BackColor = System.Drawing.Color.Green;
            this.lblN9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN9.Location = new System.Drawing.Point(576, 506);
            this.lblN9.Name = "lblN9";
            this.lblN9.Size = new System.Drawing.Size(46, 29);
            this.lblN9.TabIndex = 42;
            this.lblN9.Text = "N9";
            // 
            // lblN10
            // 
            this.lblN10.AutoSize = true;
            this.lblN10.BackColor = System.Drawing.Color.Green;
            this.lblN10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN10.Location = new System.Drawing.Point(576, 552);
            this.lblN10.Name = "lblN10";
            this.lblN10.Size = new System.Drawing.Size(60, 29);
            this.lblN10.TabIndex = 42;
            this.lblN10.Text = "N10";
            // 
            // lblN11
            // 
            this.lblN11.AutoSize = true;
            this.lblN11.BackColor = System.Drawing.Color.Green;
            this.lblN11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN11.Location = new System.Drawing.Point(669, 115);
            this.lblN11.Name = "lblN11";
            this.lblN11.Size = new System.Drawing.Size(60, 29);
            this.lblN11.TabIndex = 42;
            this.lblN11.Text = "N11";
            // 
            // lblN12
            // 
            this.lblN12.AutoSize = true;
            this.lblN12.BackColor = System.Drawing.Color.Green;
            this.lblN12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN12.Location = new System.Drawing.Point(669, 160);
            this.lblN12.Name = "lblN12";
            this.lblN12.Size = new System.Drawing.Size(60, 29);
            this.lblN12.TabIndex = 42;
            this.lblN12.Text = "N12";
            // 
            // lblN13
            // 
            this.lblN13.AutoSize = true;
            this.lblN13.BackColor = System.Drawing.Color.Green;
            this.lblN13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN13.Location = new System.Drawing.Point(669, 207);
            this.lblN13.Name = "lblN13";
            this.lblN13.Size = new System.Drawing.Size(60, 29);
            this.lblN13.TabIndex = 42;
            this.lblN13.Text = "N13";
            // 
            // lblN14
            // 
            this.lblN14.AutoSize = true;
            this.lblN14.BackColor = System.Drawing.Color.Green;
            this.lblN14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN14.Location = new System.Drawing.Point(669, 257);
            this.lblN14.Name = "lblN14";
            this.lblN14.Size = new System.Drawing.Size(60, 29);
            this.lblN14.TabIndex = 42;
            this.lblN14.Text = "N14";
            // 
            // lblN15
            // 
            this.lblN15.AutoSize = true;
            this.lblN15.BackColor = System.Drawing.Color.Green;
            this.lblN15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN15.Location = new System.Drawing.Point(669, 309);
            this.lblN15.Name = "lblN15";
            this.lblN15.Size = new System.Drawing.Size(60, 29);
            this.lblN15.TabIndex = 42;
            this.lblN15.Text = "N15";
            // 
            // lblN16
            // 
            this.lblN16.AutoSize = true;
            this.lblN16.BackColor = System.Drawing.Color.Green;
            this.lblN16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN16.Location = new System.Drawing.Point(669, 359);
            this.lblN16.Name = "lblN16";
            this.lblN16.Size = new System.Drawing.Size(60, 29);
            this.lblN16.TabIndex = 42;
            this.lblN16.Text = "N16";
            // 
            // lblN17
            // 
            this.lblN17.AutoSize = true;
            this.lblN17.BackColor = System.Drawing.Color.Green;
            this.lblN17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN17.Location = new System.Drawing.Point(669, 407);
            this.lblN17.Name = "lblN17";
            this.lblN17.Size = new System.Drawing.Size(60, 29);
            this.lblN17.TabIndex = 42;
            this.lblN17.Text = "N17";
            // 
            // lblN18
            // 
            this.lblN18.AutoSize = true;
            this.lblN18.BackColor = System.Drawing.Color.Green;
            this.lblN18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN18.Location = new System.Drawing.Point(669, 457);
            this.lblN18.Name = "lblN18";
            this.lblN18.Size = new System.Drawing.Size(60, 29);
            this.lblN18.TabIndex = 42;
            this.lblN18.Text = "N18";
            // 
            // lblN19
            // 
            this.lblN19.AutoSize = true;
            this.lblN19.BackColor = System.Drawing.Color.Green;
            this.lblN19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN19.Location = new System.Drawing.Point(669, 506);
            this.lblN19.Name = "lblN19";
            this.lblN19.Size = new System.Drawing.Size(60, 29);
            this.lblN19.TabIndex = 42;
            this.lblN19.Text = "N19";
            // 
            // lblN20
            // 
            this.lblN20.AutoSize = true;
            this.lblN20.BackColor = System.Drawing.Color.Green;
            this.lblN20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN20.Location = new System.Drawing.Point(669, 552);
            this.lblN20.Name = "lblN20";
            this.lblN20.Size = new System.Drawing.Size(60, 29);
            this.lblN20.TabIndex = 42;
            this.lblN20.Text = "N20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 777);
            this.Controls.Add(this.lblN20);
            this.Controls.Add(this.lblN10);
            this.Controls.Add(this.lblN19);
            this.Controls.Add(this.lblN9);
            this.Controls.Add(this.lblN18);
            this.Controls.Add(this.lblN8);
            this.Controls.Add(this.lblN17);
            this.Controls.Add(this.lblN7);
            this.Controls.Add(this.lblN16);
            this.Controls.Add(this.lblN6);
            this.Controls.Add(this.lblN15);
            this.Controls.Add(this.lblN5);
            this.Controls.Add(this.lblN14);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblN13);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN12);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN11);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblKalınanSüre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBilgi);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBilgi.ResumeLayout(false);
            this.grpBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBilgi;
        private System.Windows.Forms.TextBox txtYer;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblYer;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtGirişSaati;
        private System.Windows.Forms.Label lblGirişSaati;
        private System.Windows.Forms.Label lblKalınanSüre;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN5;
        private System.Windows.Forms.Label lblN6;
        private System.Windows.Forms.Label lblN7;
        private System.Windows.Forms.Label lblN8;
        private System.Windows.Forms.Label lblN9;
        private System.Windows.Forms.Label lblN10;
        private System.Windows.Forms.Label lblN11;
        private System.Windows.Forms.Label lblN12;
        private System.Windows.Forms.Label lblN13;
        private System.Windows.Forms.Label lblN14;
        private System.Windows.Forms.Label lblN15;
        private System.Windows.Forms.Label lblN16;
        private System.Windows.Forms.Label lblN17;
        private System.Windows.Forms.Label lblN18;
        private System.Windows.Forms.Label lblN19;
        private System.Windows.Forms.Label lblN20;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.TextBox txtCikisTarihi;
        private System.Windows.Forms.Label lblCikisTarihi;
    }
}

