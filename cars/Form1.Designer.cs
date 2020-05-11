namespace cars
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKiloMetre = new System.Windows.Forms.TextBox();
            this.lblBagajHacmi = new System.Windows.Forms.Label();
            this.lblYakitHacmi = new System.Windows.Forms.Label();
            this.lblMotorGucu = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblAracTipi = new System.Windows.Forms.Label();
            this.lblYakitTuru = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 452);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::cars.Properties.Resources.Galeri_EA;
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Bahnschrift", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seçim";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Bahnschrift", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ItemHeight = 22;
            this.comboBox4.Location = new System.Drawing.Point(562, 312);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(145, 30);
            this.comboBox4.TabIndex = 23;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Bahnschrift", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 22;
            this.comboBox3.Items.AddRange(new object[] {
            "1.4",
            "1.6",
            "1.8",
            "2.0"});
            this.comboBox3.Location = new System.Drawing.Point(283, 263);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(145, 30);
            this.comboBox3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 40);
            this.label6.TabIndex = 22;
            this.label6.Text = "Motor Gücü (lt) :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 16.30189F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Turquoise;
            this.button2.Location = new System.Drawing.Point(499, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Araç Oluştur";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14.26415F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(471, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bütçene Uygun Arabayı Bul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(283, 388);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(283, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 29);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Bahnschrift", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Hybrid"});
            this.comboBox2.Location = new System.Drawing.Point(283, 345);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 30);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 22;
            this.comboBox1.Location = new System.Drawing.Point(283, 303);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 30);
            this.comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 18.33962F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(66, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Lütfen kriterlerinizi giriniz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bagaj Hacmi (lt) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Yakıt Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Araç Tipi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(482, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bütçenize Uygun Markalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bütçe :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::cars.Properties.Resources.Galeri_EA;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtKiloMetre);
            this.tabPage2.Controls.Add(this.lblBagajHacmi);
            this.tabPage2.Controls.Add(this.lblYakitHacmi);
            this.tabPage2.Controls.Add(this.lblMotorGucu);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.lblAracTipi);
            this.tabPage2.Controls.Add(this.lblYakitTuru);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.lblMarka);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sonuç";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 35);
            this.label10.TabIndex = 25;
            this.label10.Text = "Bagaj Hacmi (lt)  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 35);
            this.label11.TabIndex = 26;
            this.label11.Text = "Motor Gücü (lt) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 35);
            this.label12.TabIndex = 24;
            this.label12.Text = "Araç Tipi :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 35);
            this.label14.TabIndex = 23;
            this.label14.Text = "Yakıt Türü :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 35);
            this.label15.TabIndex = 22;
            this.label15.Text = "Marka :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(467, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 35);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ortalama Yakıt Tüketimi";
            // 
            // txtKiloMetre
            // 
            this.txtKiloMetre.Font = new System.Drawing.Font("Bahnschrift", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKiloMetre.Location = new System.Drawing.Point(639, 258);
            this.txtKiloMetre.Name = "txtKiloMetre";
            this.txtKiloMetre.Size = new System.Drawing.Size(145, 29);
            this.txtKiloMetre.TabIndex = 20;
            this.txtKiloMetre.Text = "0";
            // 
            // lblBagajHacmi
            // 
            this.lblBagajHacmi.AutoSize = true;
            this.lblBagajHacmi.BackColor = System.Drawing.Color.Black;
            this.lblBagajHacmi.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBagajHacmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBagajHacmi.Location = new System.Drawing.Point(259, 306);
            this.lblBagajHacmi.Name = "lblBagajHacmi";
            this.lblBagajHacmi.Size = new System.Drawing.Size(177, 35);
            this.lblBagajHacmi.TabIndex = 10;
            this.lblBagajHacmi.Text = "Bagaj Hacmi";
            // 
            // lblYakitHacmi
            // 
            this.lblYakitHacmi.AutoSize = true;
            this.lblYakitHacmi.BackColor = System.Drawing.Color.Black;
            this.lblYakitHacmi.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYakitHacmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblYakitHacmi.Location = new System.Drawing.Point(571, 350);
            this.lblYakitHacmi.Name = "lblYakitHacmi";
            this.lblYakitHacmi.Size = new System.Drawing.Size(116, 35);
            this.lblYakitHacmi.TabIndex = 10;
            this.lblYakitHacmi.Text = "Tüketim";
            // 
            // lblMotorGucu
            // 
            this.lblMotorGucu.AutoSize = true;
            this.lblMotorGucu.BackColor = System.Drawing.Color.Black;
            this.lblMotorGucu.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMotorGucu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMotorGucu.Location = new System.Drawing.Point(236, 271);
            this.lblMotorGucu.Name = "lblMotorGucu";
            this.lblMotorGucu.Size = new System.Drawing.Size(164, 35);
            this.lblMotorGucu.TabIndex = 10;
            this.lblMotorGucu.Text = "Motor Gücü";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(473, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "HESAPLA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblAracTipi
            // 
            this.lblAracTipi.AutoSize = true;
            this.lblAracTipi.BackColor = System.Drawing.Color.Black;
            this.lblAracTipi.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracTipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAracTipi.Location = new System.Drawing.Point(156, 236);
            this.lblAracTipi.Name = "lblAracTipi";
            this.lblAracTipi.Size = new System.Drawing.Size(127, 35);
            this.lblAracTipi.TabIndex = 6;
            this.lblAracTipi.Text = "Araç Tipi";
            // 
            // lblYakitTuru
            // 
            this.lblYakitTuru.AutoSize = true;
            this.lblYakitTuru.BackColor = System.Drawing.Color.Black;
            this.lblYakitTuru.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYakitTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblYakitTuru.Location = new System.Drawing.Point(169, 341);
            this.lblYakitTuru.Name = "lblYakitTuru";
            this.lblYakitTuru.Size = new System.Drawing.Size(140, 35);
            this.lblYakitTuru.TabIndex = 3;
            this.lblYakitTuru.Text = "Yakıt Türü";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 18.33962F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(571, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 33);
            this.label13.TabIndex = 2;
            this.label13.Text = "KM";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.BackColor = System.Drawing.Color.Black;
            this.lblMarka.Font = new System.Drawing.Font("Bahnschrift", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMarka.Location = new System.Drawing.Point(135, 201);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(95, 35);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "Marka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 21.73585F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(6, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "Özellikler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ArabamıBul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtKiloMetre;
        private System.Windows.Forms.Label lblBagajHacmi;
        private System.Windows.Forms.Label lblYakitHacmi;
        private System.Windows.Forms.Label lblMotorGucu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblAracTipi;
        private System.Windows.Forms.Label lblYakitTuru;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

