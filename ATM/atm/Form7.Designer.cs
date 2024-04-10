namespace atm
{
    partial class Form7
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblBalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.BackColor = Color.Transparent;
            lblBalance.Font = new Font("Perpetua Titling MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(118, 68);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(241, 20);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "YOUR CURRENT BALANCE IS: ";
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.Transparent;
            btnDeposit.BorderRadius = 15;
            btnDeposit.CustomizableEdges = customizableEdges1;
            btnDeposit.DisabledState.BorderColor = Color.DarkGray;
            btnDeposit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeposit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeposit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeposit.FillColor = Color.DarkCyan;
            btnDeposit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(177, 150);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDeposit.Size = new Size(110, 41);
            btnDeposit.TabIndex = 7;
            btnDeposit.Text = "OKAY";
            btnDeposit.Click += btnDeposit_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Perpetua Titling MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(442, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(40, 20);
            guna2HtmlLabel1.TabIndex = 8;
            guna2HtmlLabel1.Text = "ATM";
            // 
            // guna2PictureBox4
            // 
            guna2PictureBox4.BackColor = Color.Transparent;
            guna2PictureBox4.CustomizableEdges = customizableEdges3;
            guna2PictureBox4.Image = (Image)resources.GetObject("guna2PictureBox4.Image");
            guna2PictureBox4.ImageRotate = 0F;
            guna2PictureBox4.Location = new Point(0, 2);
            guna2PictureBox4.Name = "guna2PictureBox4";
            guna2PictureBox4.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox4.Size = new Size(51, 32);
            guna2PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox4.TabIndex = 9;
            guna2PictureBox4.TabStop = false;
            guna2PictureBox4.UseTransparentBackground = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ombree;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 227);
            Controls.Add(guna2PictureBox4);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnDeposit);
            Controls.Add(lblBalance);
            Name = "Form7";
            Text = "BALANCE";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblBalance;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
    }
}