namespace ImageProccessing
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBinariz2 = new System.Windows.Forms.Button();
            this.btnBinariz = new System.Windows.Forms.Button();
            this.btnSolyariz = new System.Windows.Forms.Button();
            this.btnLineContr = new System.Windows.Forms.Button();
            this.btnOkontur = new System.Windows.Forms.Button();
            this.bntRezkost = new System.Windows.Forms.Button();
            this.btnTisn = new System.Windows.Forms.Button();
            this.btnBlure = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnReloadImg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(153, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 629);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(12, 12);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(87, 25);
            this.btnOpenImage.TabIndex = 0;
            this.btnOpenImage.Text = "Открыть";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(12, 43);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(135, 24);
            this.btnSaveFile.TabIndex = 1;
            this.btnSaveFile.Text = "Схоронить";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnBinariz2);
            this.groupBox1.Controls.Add(this.btnBinariz);
            this.groupBox1.Controls.Add(this.btnSolyariz);
            this.groupBox1.Controls.Add(this.btnLineContr);
            this.groupBox1.Controls.Add(this.btnOkontur);
            this.groupBox1.Controls.Add(this.bntRezkost);
            this.groupBox1.Controls.Add(this.btnTisn);
            this.groupBox1.Controls.Add(this.btnBlure);
            this.groupBox1.Controls.Add(this.btnNegative);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 443);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции";
            // 
            // btnBinariz2
            // 
            this.btnBinariz2.Location = new System.Drawing.Point(6, 251);
            this.btnBinariz2.Name = "btnBinariz2";
            this.btnBinariz2.Size = new System.Drawing.Size(69, 23);
            this.btnBinariz2.TabIndex = 7;
            this.btnBinariz2.Text = "Binariz2";
            this.btnBinariz2.UseVisualStyleBackColor = true;
            this.btnBinariz2.Click += new System.EventHandler(this.btnBinariz2_Click);
            // 
            // btnBinariz
            // 
            this.btnBinariz.Location = new System.Drawing.Point(6, 222);
            this.btnBinariz.Name = "btnBinariz";
            this.btnBinariz.Size = new System.Drawing.Size(69, 23);
            this.btnBinariz.TabIndex = 6;
            this.btnBinariz.Text = "Binariz";
            this.btnBinariz.UseVisualStyleBackColor = true;
            this.btnBinariz.Click += new System.EventHandler(this.btnBinariz_Click);
            // 
            // btnSolyariz
            // 
            this.btnSolyariz.Location = new System.Drawing.Point(6, 193);
            this.btnSolyariz.Name = "btnSolyariz";
            this.btnSolyariz.Size = new System.Drawing.Size(69, 23);
            this.btnSolyariz.TabIndex = 5;
            this.btnSolyariz.Text = "Solyariz";
            this.btnSolyariz.UseVisualStyleBackColor = true;
            this.btnSolyariz.Click += new System.EventHandler(this.btnSolyariz_Click);
            // 
            // btnLineContr
            // 
            this.btnLineContr.Location = new System.Drawing.Point(6, 164);
            this.btnLineContr.Name = "btnLineContr";
            this.btnLineContr.Size = new System.Drawing.Size(69, 23);
            this.btnLineContr.TabIndex = 4;
            this.btnLineContr.Text = "LineContr";
            this.btnLineContr.UseVisualStyleBackColor = true;
            this.btnLineContr.Click += new System.EventHandler(this.btnLineContr_Click);
            // 
            // btnOkontur
            // 
            this.btnOkontur.Location = new System.Drawing.Point(6, 135);
            this.btnOkontur.Name = "btnOkontur";
            this.btnOkontur.Size = new System.Drawing.Size(69, 23);
            this.btnOkontur.TabIndex = 4;
            this.btnOkontur.Text = "Okontur";
            this.btnOkontur.UseVisualStyleBackColor = true;
            this.btnOkontur.Click += new System.EventHandler(this.btnOkontur_Click);
            // 
            // bntRezkost
            // 
            this.bntRezkost.Location = new System.Drawing.Point(6, 106);
            this.bntRezkost.Name = "bntRezkost";
            this.bntRezkost.Size = new System.Drawing.Size(69, 23);
            this.bntRezkost.TabIndex = 3;
            this.bntRezkost.Text = "Rezkost";
            this.bntRezkost.UseVisualStyleBackColor = true;
            this.bntRezkost.Click += new System.EventHandler(this.bntRezkost_Click);
            // 
            // btnTisn
            // 
            this.btnTisn.Location = new System.Drawing.Point(6, 77);
            this.btnTisn.Name = "btnTisn";
            this.btnTisn.Size = new System.Drawing.Size(69, 23);
            this.btnTisn.TabIndex = 2;
            this.btnTisn.Text = "Tisn";
            this.btnTisn.UseVisualStyleBackColor = true;
            this.btnTisn.Click += new System.EventHandler(this.btnTisn_Click);
            // 
            // btnBlure
            // 
            this.btnBlure.Location = new System.Drawing.Point(6, 48);
            this.btnBlure.Name = "btnBlure";
            this.btnBlure.Size = new System.Drawing.Size(69, 23);
            this.btnBlure.TabIndex = 1;
            this.btnBlure.Text = "Blur";
            this.btnBlure.UseVisualStyleBackColor = true;
            this.btnBlure.Click += new System.EventHandler(this.btnBlure_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNegative.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNegative.Location = new System.Drawing.Point(6, 19);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(69, 23);
            this.btnNegative.TabIndex = 0;
            this.btnNegative.Tag = "";
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnReloadImg
            // 
            this.btnReloadImg.Location = new System.Drawing.Point(105, 13);
            this.btnReloadImg.Name = "btnReloadImg";
            this.btnReloadImg.Size = new System.Drawing.Size(42, 23);
            this.btnReloadImg.TabIndex = 4;
            this.btnReloadImg.Text = "←";
            this.btnReloadImg.UseVisualStyleBackColor = true;
            this.btnReloadImg.Click += new System.EventHandler(this.btnReloadImg_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "resize/2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 640);
            this.Controls.Add(this.btnReloadImg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "ImageProccessing by Mihaylovsky Maxim in 2010 ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnBlure;
        private System.Windows.Forms.Button btnTisn;
        private System.Windows.Forms.Button bntRezkost;
        private System.Windows.Forms.Button btnOkontur;
        private System.Windows.Forms.Button btnLineContr;
        private System.Windows.Forms.Button btnSolyariz;
        private System.Windows.Forms.Button btnBinariz;
        private System.Windows.Forms.Button btnBinariz2;
        private System.Windows.Forms.Button btnReloadImg;
        private System.Windows.Forms.Button button1;
    }
}

