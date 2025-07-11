﻿namespace FaceEmotionDetectApp.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.button_Config_Connect = new System.Windows.Forms.Button();
            this.label_Ip = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Ip = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Config_Connect
            // 
            this.button_Config_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Config_Connect.BackColor = System.Drawing.Color.Lavender;
            this.button_Config_Connect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Config_Connect.FlatAppearance.BorderSize = 0;
            this.button_Config_Connect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Config_Connect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Config_Connect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Config_Connect.Location = new System.Drawing.Point(280, 122);
            this.button_Config_Connect.Margin = new System.Windows.Forms.Padding(5);
            this.button_Config_Connect.Name = "button_Config_Connect";
            this.button_Config_Connect.Size = new System.Drawing.Size(90, 30);
            this.button_Config_Connect.TabIndex = 0;
            this.button_Config_Connect.Text = "🔗 Connect";
            this.button_Config_Connect.UseVisualStyleBackColor = false;
            this.button_Config_Connect.Click += new System.EventHandler(this.button_Config_Connect_Click);
            // 
            // label_Ip
            // 
            this.label_Ip.AutoSize = true;
            this.label_Ip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Ip.Location = new System.Drawing.Point(14, 10);
            this.label_Ip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Ip.Name = "label_Ip";
            this.label_Ip.Size = new System.Drawing.Size(27, 19);
            this.label_Ip.TabIndex = 1;
            this.label_Ip.Text = "ip: ";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Login.Location = new System.Drawing.Point(14, 51);
            this.label_Login.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(44, 19);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "login: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "password: ";
            // 
            // textBox_Ip
            // 
            this.textBox_Ip.BackColor = System.Drawing.Color.White;
            this.textBox_Ip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ip.Location = new System.Drawing.Point(109, 6);
            this.textBox_Ip.Name = "textBox_Ip";
            this.textBox_Ip.Size = new System.Drawing.Size(140, 33);
            this.textBox_Ip.TabIndex = 4;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.White;
            this.textBox_Username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(109, 45);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(261, 33);
            this.textBox_Username.TabIndex = 5;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.White;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(109, 85);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(261, 33);
            this.textBox_Password.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(109, 124);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(163, 27);
            this.progressBar1.TabIndex = 7;
            // 
            // textBox_Port
            // 
            this.textBox_Port.BackColor = System.Drawing.Color.White;
            this.textBox_Port.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Port.Location = new System.Drawing.Point(307, 6);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(63, 33);
            this.textBox_Port.TabIndex = 8;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Port.Location = new System.Drawing.Point(257, 9);
            this.label_Port.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(41, 19);
            this.label_Port.TabIndex = 9;
            this.label_Port.Text = "port: ";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Ip);
            this.Controls.Add(this.button_Config_Connect);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Config_Connect;
        private System.Windows.Forms.Label label_Ip;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label_Port;
    }
}