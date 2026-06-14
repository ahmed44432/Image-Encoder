using SimpleCrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Image_encoder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        string image_path;
        ImageCrypt imageCrypt;

        private void cybuttenOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select Image";
            openFileDialog.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                hopePictureBox1.ImageLocation = openFileDialog.FileName;
                txbFilePath.Text = openFileDialog.FileName;
                image_path = openFileDialog.FileName;
            }
        }

        private void cybuttonEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(image_path))
            {
                MessageBox.Show("Choose an Image First :)", "info");
                return;
            }

            if (!IsKeyValid())
            {
                MessageBox.Show("the key Length must be 16", "info");
                return;
            }


            imageCrypt = new ImageCrypt();
            imageCrypt.InputFile = image_path;
            saveFileDialog1.Title = "Save Image";
            saveFileDialog1.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            saveFileDialog1.FileName = "Encrypted_Image";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageCrypt.Key = txbKey.Text;
                if (!imageCrypt.EncryptFile(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Somthing went wrong !!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbKey_Validating(object sender, CancelEventArgs e)
        {
            IsKeyValid();
        }

        private bool IsKeyValid()
        {
            if (txbKey.Text.Length != 16)
            {
                errorProvider1.SetError(txbKey, "the key Length must be 16");
                return false;
            }

            errorProvider1.SetError(txbKey, "");
            return true;
        }

        private void cybuttonDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(image_path))
            {
                MessageBox.Show("Choose an Image First :)", "info");
                return;
            }

            if (!IsKeyValid())
            {
                MessageBox.Show("the key Length must be 16", "info");
                return;
            }


            imageCrypt = new ImageCrypt();
            imageCrypt.InputFile = image_path;
            saveFileDialog1.Title = "Save Image";
            saveFileDialog1.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            saveFileDialog1.FileName = "Decrypted_Image";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageCrypt.Key = txbKey.Text;
                if (!imageCrypt.DecryptFile(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Somthing went wrong !!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            txbKey.Text = ImageCrypt.GenerateKey16();
        }


    }





}
