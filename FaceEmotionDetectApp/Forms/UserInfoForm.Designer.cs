namespace FaceEmotionDetectApp.Forms
{
    partial class UserInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            this.label_Info_Percent = new System.Windows.Forms.Label();
            this.label_FName_Static = new System.Windows.Forms.Label();
            this.label_LName_Static = new System.Windows.Forms.Label();
            this.label_Age_Static = new System.Windows.Forms.Label();
            this.label_Sex_Static = new System.Windows.Forms.Label();
            this.label_Sex = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_LName = new System.Windows.Forms.Label();
            this.label_FName = new System.Windows.Forms.Label();
            this.pictureBox_Panorama = new System.Windows.Forms.PictureBox();
            this.pictureBox_PTZ = new System.Windows.Forms.PictureBox();
            this.pictureBox_Panorama_Live_Info = new System.Windows.Forms.PictureBox();
            this.pictureBox_PTZ_Live_Info = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Panorama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PTZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Panorama_Live_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PTZ_Live_Info)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Info_Percent
            // 
            this.label_Info_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Info_Percent.AutoSize = true;
            this.label_Info_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Info_Percent.Location = new System.Drawing.Point(424, 181);
            this.label_Info_Percent.Name = "label_Info_Percent";
            this.label_Info_Percent.Size = new System.Drawing.Size(161, 55);
            this.label_Info_Percent.TabIndex = 4;
            this.label_Info_Percent.Text = "100 %";
            // 
            // label_FName_Static
            // 
            this.label_FName_Static.AutoSize = true;
            this.label_FName_Static.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FName_Static.Location = new System.Drawing.Point(17, 482);
            this.label_FName_Static.Name = "label_FName_Static";
            this.label_FName_Static.Size = new System.Drawing.Size(65, 25);
            this.label_FName_Static.TabIndex = 5;
            this.label_FName_Static.Text = "Имя: ";
            // 
            // label_LName_Static
            // 
            this.label_LName_Static.AutoSize = true;
            this.label_LName_Static.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LName_Static.Location = new System.Drawing.Point(17, 533);
            this.label_LName_Static.Name = "label_LName_Static";
            this.label_LName_Static.Size = new System.Drawing.Size(116, 25);
            this.label_LName_Static.TabIndex = 6;
            this.label_LName_Static.Text = "Фамилия: ";
            // 
            // label_Age_Static
            // 
            this.label_Age_Static.AutoSize = true;
            this.label_Age_Static.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Age_Static.Location = new System.Drawing.Point(17, 579);
            this.label_Age_Static.Name = "label_Age_Static";
            this.label_Age_Static.Size = new System.Drawing.Size(106, 25);
            this.label_Age_Static.TabIndex = 7;
            this.label_Age_Static.Text = "Возраст: ";
            // 
            // label_Sex_Static
            // 
            this.label_Sex_Static.AutoSize = true;
            this.label_Sex_Static.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sex_Static.Location = new System.Drawing.Point(17, 632);
            this.label_Sex_Static.Name = "label_Sex_Static";
            this.label_Sex_Static.Size = new System.Drawing.Size(63, 25);
            this.label_Sex_Static.TabIndex = 8;
            this.label_Sex_Static.Text = "Пол: ";
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sex.Location = new System.Drawing.Point(647, 632);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Sex.Size = new System.Drawing.Size(31, 25);
            this.label_Sex.TabIndex = 12;
            this.label_Sex.Text = " - ";
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Age.Location = new System.Drawing.Point(647, 579);
            this.label_Age.Name = "label_Age";
            this.label_Age.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Age.Size = new System.Drawing.Size(31, 25);
            this.label_Age.TabIndex = 11;
            this.label_Age.Text = " - ";
            // 
            // label_LName
            // 
            this.label_LName.AutoSize = true;
            this.label_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LName.Location = new System.Drawing.Point(647, 533);
            this.label_LName.Name = "label_LName";
            this.label_LName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_LName.Size = new System.Drawing.Size(31, 25);
            this.label_LName.TabIndex = 10;
            this.label_LName.Text = " - ";
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FName.Location = new System.Drawing.Point(647, 482);
            this.label_FName.Name = "label_FName";
            this.label_FName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_FName.Size = new System.Drawing.Size(31, 25);
            this.label_FName.TabIndex = 9;
            this.label_FName.Text = " - ";
            // 
            // pictureBox_Panorama
            // 
            this.pictureBox_Panorama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Panorama.BackColor = System.Drawing.Color.White;
            this.pictureBox_Panorama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Panorama.Location = new System.Drawing.Point(647, 19);
            this.pictureBox_Panorama.Name = "pictureBox_Panorama";
            this.pictureBox_Panorama.Size = new System.Drawing.Size(310, 418);
            this.pictureBox_Panorama.TabIndex = 3;
            this.pictureBox_Panorama.TabStop = false;
            // 
            // pictureBox_PTZ
            // 
            this.pictureBox_PTZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_PTZ.BackColor = System.Drawing.Color.White;
            this.pictureBox_PTZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_PTZ.Location = new System.Drawing.Point(22, 19);
            this.pictureBox_PTZ.Name = "pictureBox_PTZ";
            this.pictureBox_PTZ.Size = new System.Drawing.Size(310, 418);
            this.pictureBox_PTZ.TabIndex = 2;
            this.pictureBox_PTZ.TabStop = false;
            // 
            // pictureBox_Panorama_Live_Info
            // 
            this.pictureBox_Panorama_Live_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Panorama_Live_Info.BackColor = System.Drawing.Color.White;
            this.pictureBox_Panorama_Live_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Panorama_Live_Info.Image = global::FaceEmotionDetectApp.Properties.Resources.Sample_User_Icon_345x345;
            this.pictureBox_Panorama_Live_Info.Location = new System.Drawing.Point(1022, 525);
            this.pictureBox_Panorama_Live_Info.Name = "pictureBox_Panorama_Live_Info";
            this.pictureBox_Panorama_Live_Info.Size = new System.Drawing.Size(870, 490);
            this.pictureBox_Panorama_Live_Info.TabIndex = 1;
            this.pictureBox_Panorama_Live_Info.TabStop = false;
            // 
            // pictureBox_PTZ_Live_Info
            // 
            this.pictureBox_PTZ_Live_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_PTZ_Live_Info.BackColor = System.Drawing.Color.White;
            this.pictureBox_PTZ_Live_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_PTZ_Live_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_PTZ_Live_Info.Image = global::FaceEmotionDetectApp.Properties.Resources.Sample_User_Icon_345x345;
            this.pictureBox_PTZ_Live_Info.Location = new System.Drawing.Point(1022, 15);
            this.pictureBox_PTZ_Live_Info.Name = "pictureBox_PTZ_Live_Info";
            this.pictureBox_PTZ_Live_Info.Size = new System.Drawing.Size(870, 490);
            this.pictureBox_PTZ_Live_Info.TabIndex = 0;
            this.pictureBox_PTZ_Live_Info.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox_PTZ);
            this.panel1.Controls.Add(this.label_Sex);
            this.panel1.Controls.Add(this.pictureBox_Panorama);
            this.panel1.Controls.Add(this.label_Age);
            this.panel1.Controls.Add(this.label_Info_Percent);
            this.panel1.Controls.Add(this.label_LName);
            this.panel1.Controls.Add(this.label_FName);
            this.panel1.Controls.Add(this.label_FName_Static);
            this.panel1.Controls.Add(this.label_Sex_Static);
            this.panel1.Controls.Add(this.label_LName_Static);
            this.panel1.Controls.Add(this.label_Age_Static);
            this.panel1.Location = new System.Drawing.Point(25, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 1002);
            this.panel1.TabIndex = 13;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Panorama_Live_Info);
            this.Controls.Add(this.pictureBox_PTZ_Live_Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Panorama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PTZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Panorama_Live_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PTZ_Live_Info)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_PTZ_Live_Info;
        private System.Windows.Forms.PictureBox pictureBox_Panorama_Live_Info;
        private System.Windows.Forms.PictureBox pictureBox_PTZ;
        private System.Windows.Forms.PictureBox pictureBox_Panorama;
        private System.Windows.Forms.Label label_Info_Percent;
        private System.Windows.Forms.Label label_FName_Static;
        private System.Windows.Forms.Label label_LName_Static;
        private System.Windows.Forms.Label label_Age_Static;
        private System.Windows.Forms.Label label_Sex_Static;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_LName;
        private System.Windows.Forms.Label label_FName;
        private System.Windows.Forms.Panel panel1;
    }
}