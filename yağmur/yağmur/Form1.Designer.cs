
namespace yağmur
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.klasörRad = new System.Windows.Forms.RadioButton();
            this.fileRad = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.klasörUzantı = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.klasörName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EncryptBTN = new System.Windows.Forms.Button();
            this.keyText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DecryptBTN = new System.Windows.Forms.Button();
            this.decryptText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bytes_text = new System.Windows.Forms.Label();
            this.selectedFolderBTN = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.copy_Key = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::yağmur.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klasör - Dosya Şifreleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(238, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "_coderpsycho";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 10);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(259, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya - Klasör";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.klasörRad);
            this.groupBox3.Controls.Add(this.fileRad);
            this.groupBox3.Location = new System.Drawing.Point(74, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 36);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // klasörRad
            // 
            this.klasörRad.AutoSize = true;
            this.klasörRad.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.klasörRad.Location = new System.Drawing.Point(120, 9);
            this.klasörRad.Name = "klasörRad";
            this.klasörRad.Size = new System.Drawing.Size(74, 21);
            this.klasörRad.TabIndex = 8;
            this.klasörRad.TabStop = true;
            this.klasörRad.Text = "Klasör";
            this.klasörRad.UseVisualStyleBackColor = true;
            // 
            // fileRad
            // 
            this.fileRad.AutoSize = true;
            this.fileRad.Enabled = false;
            this.fileRad.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileRad.Location = new System.Drawing.Point(6, 9);
            this.fileRad.Name = "fileRad";
            this.fileRad.Size = new System.Drawing.Size(66, 21);
            this.fileRad.TabIndex = 7;
            this.fileRad.TabStop = true;
            this.fileRad.Text = "Dosya";
            this.fileRad.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(4, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 330);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Şifreleme";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.klasörUzantı);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.klasörName);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(6, 103);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(364, 77);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Klasör isim - uzantı";
            // 
            // klasörUzantı
            // 
            this.klasörUzantı.Enabled = false;
            this.klasörUzantı.Location = new System.Drawing.Point(109, 45);
            this.klasörUzantı.Name = "klasörUzantı";
            this.klasörUzantı.Size = new System.Drawing.Size(193, 20);
            this.klasörUzantı.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Klasör Uzantı:";
            // 
            // klasörName
            // 
            this.klasörName.Enabled = false;
            this.klasörName.Location = new System.Drawing.Point(109, 19);
            this.klasörName.Name = "klasörName";
            this.klasörName.Size = new System.Drawing.Size(193, 20);
            this.klasörName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Klasör İsim:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tabControl1);
            this.groupBox6.Location = new System.Drawing.Point(6, 186);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(364, 138);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Şifreleme - Çözme";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 107);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Tan;
            this.tabPage1.Controls.Add(this.copy_Key);
            this.tabPage1.Controls.Add(this.EncryptBTN);
            this.tabPage1.Controls.Add(this.keyText);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 80);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Şifrele";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // EncryptBTN
            // 
            this.EncryptBTN.BackColor = System.Drawing.Color.Brown;
            this.EncryptBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptBTN.FlatAppearance.BorderSize = 0;
            this.EncryptBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptBTN.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EncryptBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EncryptBTN.Location = new System.Drawing.Point(221, 45);
            this.EncryptBTN.Name = "EncryptBTN";
            this.EncryptBTN.Size = new System.Drawing.Size(78, 29);
            this.EncryptBTN.TabIndex = 2;
            this.EncryptBTN.Text = "Şifrele";
            this.EncryptBTN.UseVisualStyleBackColor = false;
            this.EncryptBTN.Click += new System.EventHandler(this.EncryptBTN_Click);
            // 
            // keyText
            // 
            this.keyText.Enabled = false;
            this.keyText.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyText.Location = new System.Drawing.Point(79, 16);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(220, 23);
            this.keyText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifreniz:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tan;
            this.tabPage2.Controls.Add(this.DecryptBTN);
            this.tabPage2.Controls.Add(this.decryptText);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(344, 80);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Şifreyi Çöz";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // DecryptBTN
            // 
            this.DecryptBTN.BackColor = System.Drawing.Color.Brown;
            this.DecryptBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptBTN.FlatAppearance.BorderSize = 0;
            this.DecryptBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptBTN.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DecryptBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DecryptBTN.Location = new System.Drawing.Point(225, 45);
            this.DecryptBTN.Name = "DecryptBTN";
            this.DecryptBTN.Size = new System.Drawing.Size(78, 29);
            this.DecryptBTN.TabIndex = 5;
            this.DecryptBTN.Text = "Çöz";
            this.DecryptBTN.UseVisualStyleBackColor = false;
            this.DecryptBTN.Click += new System.EventHandler(this.DecryptPasswordBTN_Click);
            // 
            // decryptText
            // 
            this.decryptText.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptText.Location = new System.Drawing.Point(83, 16);
            this.decryptText.Name = "decryptText";
            this.decryptText.PasswordChar = '*';
            this.decryptText.Size = new System.Drawing.Size(220, 23);
            this.decryptText.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Şifreniz:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bytes_text);
            this.groupBox5.Controls.Add(this.selectedFolderBTN);
            this.groupBox5.Controls.Add(this.pathText);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 74);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Şifrelemek İstediğin Klasörü - Dosyayı Seç";
            // 
            // bytes_text
            // 
            this.bytes_text.AutoSize = true;
            this.bytes_text.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bytes_text.Location = new System.Drawing.Point(198, 43);
            this.bytes_text.Name = "bytes_text";
            this.bytes_text.Size = new System.Drawing.Size(77, 15);
            this.bytes_text.TabIndex = 2;
            this.bytes_text.Text = "0/00 Bytes";
            // 
            // selectedFolderBTN
            // 
            this.selectedFolderBTN.BackColor = System.Drawing.Color.Brown;
            this.selectedFolderBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectedFolderBTN.FlatAppearance.BorderSize = 0;
            this.selectedFolderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedFolderBTN.Font = new System.Drawing.Font("Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.selectedFolderBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectedFolderBTN.Location = new System.Drawing.Point(295, 18);
            this.selectedFolderBTN.Name = "selectedFolderBTN";
            this.selectedFolderBTN.Size = new System.Drawing.Size(44, 23);
            this.selectedFolderBTN.TabIndex = 1;
            this.selectedFolderBTN.Text = "...";
            this.selectedFolderBTN.UseVisualStyleBackColor = false;
            this.selectedFolderBTN.Click += new System.EventHandler(this.selectedFolderBTN_Click);
            // 
            // pathText
            // 
            this.pathText.Enabled = false;
            this.pathText.Location = new System.Drawing.Point(78, 20);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(211, 20);
            this.pathText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yolu Seç:";
            // 
            // copy_Key
            // 
            this.copy_Key.BackColor = System.Drawing.Color.Brown;
            this.copy_Key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy_Key.Enabled = false;
            this.copy_Key.FlatAppearance.BorderSize = 0;
            this.copy_Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy_Key.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.copy_Key.ForeColor = System.Drawing.SystemColors.ControlText;
            this.copy_Key.Location = new System.Drawing.Point(137, 45);
            this.copy_Key.Name = "copy_Key";
            this.copy_Key.Size = new System.Drawing.Size(78, 29);
            this.copy_Key.TabIndex = 3;
            this.copy_Key.Text = "Kopyala";
            this.copy_Key.UseVisualStyleBackColor = false;
            this.copy_Key.Click += new System.EventHandler(this.copy_Key_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(383, 494);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yağmur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton fileRad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton klasörRad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectedFolderBTN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Button EncryptBTN;
        private System.Windows.Forms.Button DecryptBTN;
        private System.Windows.Forms.TextBox decryptText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox klasörName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox klasörUzantı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bytes_text;
        private System.Windows.Forms.Button copy_Key;
    }
}

