namespace Image_encoder
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            cybuttonOpenFile = new ReaLTaiizor.Controls.CyberButton();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            txbFilePath = new ReaLTaiizor.Controls.AloneTextBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            btnGenerateKey = new ReaLTaiizor.Controls.Button();
            label1 = new Label();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            txbKey = new ReaLTaiizor.Controls.AloneTextBox();
            hopePictureBox3 = new ReaLTaiizor.Controls.HopePictureBox();
            hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            cybuttonDecrypt = new ReaLTaiizor.Controls.CyberButton();
            cybuttonEncrypt = new ReaLTaiizor.Controls.CyberButton();
            errorProvider1 = new ErrorProvider(components);
            hopePictureBox4 = new ReaLTaiizor.Controls.HopePictureBox();
            label2 = new Label();
            cyberGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            cyberGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox4).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cybuttonOpenFile
            // 
            cybuttonOpenFile.Alpha = 20;
            cybuttonOpenFile.BackColor = Color.Transparent;
            cybuttonOpenFile.Background = true;
            cybuttonOpenFile.Background_WidthPen = 4F;
            cybuttonOpenFile.BackgroundPen = true;
            cybuttonOpenFile.ColorBackground = Color.FromArgb(37, 52, 68);
            cybuttonOpenFile.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cybuttonOpenFile.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cybuttonOpenFile.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cybuttonOpenFile.ColorLighting = Color.FromArgb(29, 200, 238);
            cybuttonOpenFile.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cybuttonOpenFile.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cybuttonOpenFile.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cybuttonOpenFile.Effect_1 = true;
            cybuttonOpenFile.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cybuttonOpenFile.Effect_1_Transparency = 25;
            cybuttonOpenFile.Effect_2 = true;
            cybuttonOpenFile.Effect_2_ColorBackground = Color.White;
            cybuttonOpenFile.Effect_2_Transparency = 20;
            cybuttonOpenFile.Font = new Font("Arial", 11F);
            cybuttonOpenFile.ForeColor = Color.FromArgb(245, 245, 245);
            cybuttonOpenFile.Lighting = false;
            cybuttonOpenFile.LinearGradient_Background = false;
            cybuttonOpenFile.LinearGradientPen = false;
            cybuttonOpenFile.Location = new Point(160, 138);
            cybuttonOpenFile.Name = "cybuttonOpenFile";
            cybuttonOpenFile.PenWidth = 15;
            cybuttonOpenFile.Rounding = true;
            cybuttonOpenFile.RoundingInt = 70;
            cybuttonOpenFile.Size = new Size(120, 44);
            cybuttonOpenFile.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cybuttonOpenFile.TabIndex = 0;
            cybuttonOpenFile.Tag = "Cyber";
            cybuttonOpenFile.TextButton = "Open File";
            cybuttonOpenFile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cybuttonOpenFile.Timer_Effect_1 = 5;
            cybuttonOpenFile.Timer_RGB = 300;
            cybuttonOpenFile.Click += cybuttenOpenFile_Click;
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 3F;
            cyberGroupBox1.BackgroundPen = true;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(txbFilePath);
            cyberGroupBox1.Controls.Add(hopePictureBox1);
            cyberGroupBox1.Controls.Add(cybuttonOpenFile);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(12, 12);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(432, 211);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 1;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // txbFilePath
            // 
            txbFilePath.BackColor = Color.Transparent;
            txbFilePath.EnabledCalc = true;
            txbFilePath.Font = new Font("Segoe UI", 9F);
            txbFilePath.ForeColor = Color.Black;
            txbFilePath.Location = new Point(31, 83);
            txbFilePath.MaxLength = 32767;
            txbFilePath.MultiLine = false;
            txbFilePath.Name = "txbFilePath";
            txbFilePath.ReadOnly = true;
            txbFilePath.Size = new Size(374, 37);
            txbFilePath.TabIndex = 8;
            txbFilePath.Text = "File Path";
            txbFilePath.TextAlign = HorizontalAlignment.Left;
            txbFilePath.UseSystemPasswordChar = false;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Location = new Point(160, 14);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(120, 50);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 1;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // cyberGroupBox2
            // 
            cyberGroupBox2.Alpha = 20;
            cyberGroupBox2.BackColor = Color.Transparent;
            cyberGroupBox2.Background = true;
            cyberGroupBox2.Background_WidthPen = 3F;
            cyberGroupBox2.BackgroundPen = true;
            cyberGroupBox2.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.Controls.Add(btnGenerateKey);
            cyberGroupBox2.Controls.Add(label1);
            cyberGroupBox2.Controls.Add(crownLabel2);
            cyberGroupBox2.Controls.Add(crownLabel1);
            cyberGroupBox2.Controls.Add(txbKey);
            cyberGroupBox2.Controls.Add(hopePictureBox3);
            cyberGroupBox2.Controls.Add(hopePictureBox2);
            cyberGroupBox2.Controls.Add(cybuttonDecrypt);
            cyberGroupBox2.Controls.Add(cybuttonEncrypt);
            cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox2.Lighting = false;
            cyberGroupBox2.LinearGradient_Background = false;
            cyberGroupBox2.LinearGradientPen = false;
            cyberGroupBox2.Location = new Point(462, 12);
            cyberGroupBox2.Name = "cyberGroupBox2";
            cyberGroupBox2.PenWidth = 15;
            cyberGroupBox2.RGB = false;
            cyberGroupBox2.Rounding = true;
            cyberGroupBox2.RoundingInt = 60;
            cyberGroupBox2.Size = new Size(365, 453);
            cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox2.TabIndex = 2;
            cyberGroupBox2.Tag = "Cyber";
            cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox2.Timer_RGB = 300;
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.BackColor = Color.Transparent;
            btnGenerateKey.BorderColor = Color.FromArgb(32, 34, 37);
            btnGenerateKey.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnGenerateKey.EnteredColor = Color.FromArgb(32, 34, 37);
            btnGenerateKey.Font = new Font("Microsoft Sans Serif", 12F);
            btnGenerateKey.Image = null;
            btnGenerateKey.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerateKey.InactiveColor = Color.FromArgb(32, 34, 37);
            btnGenerateKey.Location = new Point(115, 183);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnGenerateKey.PressedColor = Color.FromArgb(165, 37, 37);
            btnGenerateKey.Size = new Size(151, 28);
            btnGenerateKey.TabIndex = 10;
            btnGenerateKey.Text = "Generate Key";
            btnGenerateKey.TextAlignment = StringAlignment.Center;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 386);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 10;
            label1.Text = "Be Safe : )";
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.ForeColor = Color.FromArgb(255, 255, 128);
            crownLabel2.Location = new Point(143, 138);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(111, 15);
            crownLabel2.TabIndex = 9;
            crownLabel2.Text = "it must be \"16 char\"";
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel1.Location = new Point(148, 47);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(106, 17);
            crownLabel1.TabIndex = 8;
            crownLabel1.Text = "Key / Password ";
            // 
            // txbKey
            // 
            txbKey.BackColor = Color.Transparent;
            txbKey.EnabledCalc = true;
            txbKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbKey.ForeColor = Color.Black;
            txbKey.Location = new Point(93, 83);
            txbKey.MaxLength = 16;
            txbKey.MultiLine = false;
            txbKey.Name = "txbKey";
            txbKey.ReadOnly = false;
            txbKey.Size = new Size(203, 29);
            txbKey.TabIndex = 7;
            txbKey.TextAlign = HorizontalAlignment.Left;
            txbKey.UseSystemPasswordChar = false;
            txbKey.Validating += txbKey_Validating;
            // 
            // hopePictureBox3
            // 
            hopePictureBox3.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox3.Image = Resource.unlocked24;
            hopePictureBox3.Location = new Point(310, 288);
            hopePictureBox3.Name = "hopePictureBox3";
            hopePictureBox3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox3.Size = new Size(24, 24);
            hopePictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            hopePictureBox3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox3.TabIndex = 6;
            hopePictureBox3.TabStop = false;
            hopePictureBox3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // hopePictureBox2
            // 
            hopePictureBox2.BackColor = Color.Transparent;
            hopePictureBox2.Image = Resource.locked24;
            hopePictureBox2.Location = new Point(125, 288);
            hopePictureBox2.Name = "hopePictureBox2";
            hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox2.Size = new Size(24, 24);
            hopePictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox2.TabIndex = 5;
            hopePictureBox2.TabStop = false;
            hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // cybuttonDecrypt
            // 
            cybuttonDecrypt.Alpha = 20;
            cybuttonDecrypt.BackColor = Color.Transparent;
            cybuttonDecrypt.Background = true;
            cybuttonDecrypt.Background_WidthPen = 4F;
            cybuttonDecrypt.BackgroundPen = true;
            cybuttonDecrypt.ColorBackground = Color.FromArgb(37, 52, 68);
            cybuttonDecrypt.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cybuttonDecrypt.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cybuttonDecrypt.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cybuttonDecrypt.ColorLighting = Color.FromArgb(29, 200, 238);
            cybuttonDecrypt.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cybuttonDecrypt.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cybuttonDecrypt.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cybuttonDecrypt.Effect_1 = true;
            cybuttonDecrypt.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cybuttonDecrypt.Effect_1_Transparency = 25;
            cybuttonDecrypt.Effect_2 = true;
            cybuttonDecrypt.Effect_2_ColorBackground = Color.White;
            cybuttonDecrypt.Effect_2_Transparency = 20;
            cybuttonDecrypt.Font = new Font("Arial", 11F);
            cybuttonDecrypt.ForeColor = Color.FromArgb(245, 245, 245);
            cybuttonDecrypt.Lighting = false;
            cybuttonDecrypt.LinearGradient_Background = false;
            cybuttonDecrypt.LinearGradientPen = false;
            cybuttonDecrypt.Location = new Point(213, 276);
            cybuttonDecrypt.Name = "cybuttonDecrypt";
            cybuttonDecrypt.PenWidth = 15;
            cybuttonDecrypt.Rounding = true;
            cybuttonDecrypt.RoundingInt = 70;
            cybuttonDecrypt.Size = new Size(130, 50);
            cybuttonDecrypt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cybuttonDecrypt.TabIndex = 4;
            cybuttonDecrypt.Tag = "Cyber";
            cybuttonDecrypt.TextButton = "Dectypt";
            cybuttonDecrypt.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cybuttonDecrypt.Timer_Effect_1 = 5;
            cybuttonDecrypt.Timer_RGB = 300;
            cybuttonDecrypt.Click += cybuttonDecrypt_Click;
            // 
            // cybuttonEncrypt
            // 
            cybuttonEncrypt.Alpha = 20;
            cybuttonEncrypt.BackColor = Color.Transparent;
            cybuttonEncrypt.Background = true;
            cybuttonEncrypt.Background_WidthPen = 4F;
            cybuttonEncrypt.BackgroundPen = true;
            cybuttonEncrypt.ColorBackground = Color.FromArgb(37, 52, 68);
            cybuttonEncrypt.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cybuttonEncrypt.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cybuttonEncrypt.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cybuttonEncrypt.ColorLighting = Color.FromArgb(29, 200, 238);
            cybuttonEncrypt.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cybuttonEncrypt.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cybuttonEncrypt.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cybuttonEncrypt.Effect_1 = true;
            cybuttonEncrypt.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cybuttonEncrypt.Effect_1_Transparency = 25;
            cybuttonEncrypt.Effect_2 = true;
            cybuttonEncrypt.Effect_2_ColorBackground = Color.White;
            cybuttonEncrypt.Effect_2_Transparency = 20;
            cybuttonEncrypt.Font = new Font("Arial", 11F);
            cybuttonEncrypt.ForeColor = Color.FromArgb(245, 245, 245);
            cybuttonEncrypt.Lighting = false;
            cybuttonEncrypt.LinearGradient_Background = false;
            cybuttonEncrypt.LinearGradientPen = false;
            cybuttonEncrypt.Location = new Point(29, 276);
            cybuttonEncrypt.Name = "cybuttonEncrypt";
            cybuttonEncrypt.PenWidth = 15;
            cybuttonEncrypt.Rounding = true;
            cybuttonEncrypt.RoundingInt = 70;
            cybuttonEncrypt.Size = new Size(130, 50);
            cybuttonEncrypt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cybuttonEncrypt.TabIndex = 3;
            cybuttonEncrypt.Tag = "Cyber";
            cybuttonEncrypt.TextButton = "Encrypt";
            cybuttonEncrypt.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cybuttonEncrypt.Timer_Effect_1 = 5;
            cybuttonEncrypt.Timer_RGB = 300;
            cybuttonEncrypt.Click += cybuttonEncrypt_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // hopePictureBox4
            // 
            hopePictureBox4.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox4.Image = Resource.strongbox256;
            hopePictureBox4.Location = new Point(136, 239);
            hopePictureBox4.Name = "hopePictureBox4";
            hopePictureBox4.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox4.Size = new Size(219, 216);
            hopePictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox4.TabIndex = 3;
            hopePictureBox4.TabStop = false;
            hopePictureBox4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 465);
            label2.Name = "label2";
            label2.Size = new Size(183, 15);
            label2.TabIndex = 11;
            label2.Text = " beghdadiahmed756@gmail.com";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(828, 489);
            Controls.Add(label2);
            Controls.Add(hopePictureBox4);
            Controls.Add(cyberGroupBox2);
            Controls.Add(cyberGroupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            this.Icon = new Icon(new MemoryStream(Resource.icons8_lock_48));
            Name = "MainForm";
            Text = "Image Encoder";
            cyberGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            cyberGroupBox2.ResumeLayout(false);
            cyberGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ReaLTaiizor.Controls.CyberButton cybuttonOpenFile;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
        private ReaLTaiizor.Controls.CyberButton cybuttonDecrypt;
        private ReaLTaiizor.Controls.CyberButton cybuttonEncrypt;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox3;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox2;
        private ReaLTaiizor.Controls.AloneTextBox txbKey;
        private ReaLTaiizor.Controls.AloneTextBox txbFilePath;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ErrorProvider errorProvider1;
        private ReaLTaiizor.Controls.Button btnGenerateKey;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox4;
        private Label label1;
        private Label label2;
    }
}