using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace yağmur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isChecked = false;

        #region Selected Folder
        private void selectedFolderBTN_Click(object sender, EventArgs e)
        {

            if (klasörRad.Checked)
            {
                using (var dialog = new FolderBrowserDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pathText.Text = dialog.SelectedPath;
                        isChecked = true;
                    }
                }
            }
            else if (fileRad.Checked)
            {
                // Sonradan Doldur.

                //OpenFileDialog InputFileDialog = new OpenFileDialog();

                //InputFileDialog.Filter = "Tüm Dosyalar  (*.*)|*.*|PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|TXT (*.txt)|*.txt";
                //InputFileDialog.ShowDialog();

                //if (InputFileDialog.FileName != "") pathText.Text = InputFileDialog.FileName;

                //isChecked = true;
            }
        }
        #endregion

        #region EncryptBTN
        private void EncryptBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (isChecked)
                {
                    this.Cursor = Cursors.WaitCursor;

                    byte[] key = new byte[16];
                    using (var rng = new RNGCryptoServiceProvider())
                    {
                        rng.GetBytes(key);
                    }

                    // Oluşturulan anahtarın hex (onaltılık) formatında bir temsilini gösterme
                    string hexKey = BitConverter.ToString(key).Replace("-", "");
                    keyText.Text = hexKey;

                    using (Aes aesAlg = Aes.Create())
                    {
                        aesAlg.Key = Encoding.UTF8.GetBytes(hexKey);
                        aesAlg.GenerateIV();

                        copy_Key.Enabled = true;

                        // Klasör adını şifreleyin ve yeni bir klasör oluşturun
                        string encryptedFolderName = Convert.ToBase64String(aesAlg.IV);
                        string encryptedFolderPath = Path.Combine(Path.GetDirectoryName(pathText.Text), encryptedFolderName);
                        Directory.CreateDirectory(encryptedFolderPath);

                        // Klasör içeriğini Şifreleme
                        foreach (string filePath in Directory.GetFiles(pathText.Text))
                        {
                            string fileName = Path.GetFileName(filePath);
                            string encryptedFilePath = Path.Combine(encryptedFolderPath, fileName);

                            using (FileStream inputStream = new FileStream(filePath, FileMode.Open))
                            using (FileStream outputStream = new FileStream(encryptedFilePath, FileMode.Create))
                            using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                            using (CryptoStream cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                            {
                                byte[] buffer = new byte[4096];
                                int bytesRead;

                                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    cryptoStream.Write(buffer, 0, bytesRead);                                  
                                }
                            }
                        }
                        this.Cursor = Cursors.Arrow;
                        pathText.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Üzgünüm bi şeyler ters gitti.");
            }
        }
        #endregion

        #region DecryptPasswd
        private void DecryptPasswordBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (isChecked && decryptText.Text != "")
                {
                    using (Aes aesAlg = Aes.Create())
                    {
                        aesAlg.Key = Encoding.UTF8.GetBytes(decryptText.Text);

                        // Şifrelenmiş klasör adından IV'yi alın
                        string encryptedFolderName = Path.GetFileName(pathText.Text);
                        byte[] iv = Convert.FromBase64String(encryptedFolderName);
                        aesAlg.IV = iv;

                        // Klasörü çöz
                        string originalFolderPath = Path.Combine(Path.GetDirectoryName(pathText.Text), "DecryptedFolder");
                        Directory.CreateDirectory(originalFolderPath);

                        // Klasör içeriğini çöz
                        foreach (string filePath in Directory.GetFiles(pathText.Text))
                        {
                            string fileName = Path.GetFileName(filePath);
                            string originalFilePath = Path.Combine(originalFolderPath, fileName);

                            using (FileStream inputStream = new FileStream(filePath, FileMode.Open))
                            using (FileStream outputStream = new FileStream(originalFilePath, FileMode.Create))
                            using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                            using (CryptoStream cryptoStream = new CryptoStream(outputStream, decryptor, CryptoStreamMode.Write))
                            {
                                byte[] buffer = new byte[4096];
                                int bytesRead;

                                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    cryptoStream.Write(buffer, 0, bytesRead);
                                }
                            }
                        }
                        pathText.Text = "";
                        decryptText.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Üzgünüm bi şeyler ters gitti.");
            }        
        }
        #endregion

        #region CopyBTN
        private void copy_Key_Click(object sender, EventArgs e)
        {
            string originalText = keyText.Text;
            string copyText = originalText;

            Clipboard.SetText(copyText);

            keyText.Text = "";
        }
        #endregion

        #region tabPage2
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tabPage1
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
               
            
         
                
