﻿namespace atm
{
    partial class Form5
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtWithdrawAmount = new Guna.UI2.WinForms.Guna2TextBox();
            enter = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(-16, 5);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(231, 210);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Perpetua Titling MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(207, 34);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(265, 20);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "ENTER AMOUNT TO WITHDRAW";
            // 
            // txtWithdrawAmount
            // 
            txtWithdrawAmount.BackColor = Color.Transparent;
            txtWithdrawAmount.BorderRadius = 16;
            txtWithdrawAmount.CustomizableEdges = customizableEdges3;
            txtWithdrawAmount.DefaultText = "";
            txtWithdrawAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtWithdrawAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtWithdrawAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtWithdrawAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtWithdrawAmount.FillColor = Color.WhiteSmoke;
            txtWithdrawAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtWithdrawAmount.Font = new Font("Segoe UI", 9F);
            txtWithdrawAmount.ForeColor = Color.Black;
            txtWithdrawAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtWithdrawAmount.Location = new Point(207, 72);
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.PasswordChar = '\0';
            txtWithdrawAmount.PlaceholderText = "";
            txtWithdrawAmount.SelectedText = "";
            txtWithdrawAmount.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtWithdrawAmount.Size = new Size(265, 36);
            txtWithdrawAmount.TabIndex = 4;
            txtWithdrawAmount.TextChanged += txtWithdrawAmount_TextChanged;
            // 
            // enter
            // 
            enter.BackColor = Color.Transparent;
            enter.BorderRadius = 15;
            enter.CustomizableEdges = customizableEdges5;
            enter.DisabledState.BorderColor = Color.DarkGray;
            enter.DisabledState.CustomBorderColor = Color.DarkGray;
            enter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            enter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            enter.FillColor = Color.DarkCyan;
            enter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enter.ForeColor = Color.White;
            enter.Location = new Point(207, 132);
            enter.Name = "enter";
            enter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            enter.Size = new Size(110, 41);
            enter.TabIndex = 5;
            enter.Text = "WITHDRAW";
            enter.Click += enter_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.IndianRed;
            guna2Button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(362, 132);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(110, 41);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "CANCEL";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ombree;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 227);
            Controls.Add(guna2Button1);
            Controls.Add(enter);
            Controls.Add(txtWithdrawAmount);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2PictureBox1);
            Name = "Form5";
            Text = "WITHDRAW";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtWithdrawAmount;
        private Guna.UI2.WinForms.Guna2Button enter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}