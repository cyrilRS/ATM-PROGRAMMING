namespace atm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            textbox = new Guna.UI2.WinForms.Guna2TextBox();
            enter = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(-3, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(231, 210);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.UseTransparentBackground = true;
            guna2PictureBox1.Click += guna2PictureBox1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Perpetua Titling MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(234, 50);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(232, 25);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "ENTER CARD NUMBER";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // textbox
            // 
            textbox.BackColor = Color.Transparent;
            textbox.BorderRadius = 16;
            textbox.CustomizableEdges = customizableEdges3;
            textbox.DefaultText = "";
            textbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textbox.FillColor = Color.WhiteSmoke;
            textbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox.Font = new Font("Segoe UI", 9F);
            textbox.ForeColor = Color.Black;
            textbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox.Location = new Point(234, 91);
            textbox.Name = "textbox";
            textbox.PasswordChar = '●';
            textbox.PlaceholderText = "";
            textbox.SelectedText = "";
            textbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textbox.Size = new Size(232, 36);
            textbox.TabIndex = 2;
            textbox.UseSystemPasswordChar = true;
            textbox.TextChanged += guna2TextBox1_TextChanged;
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
            enter.Location = new Point(234, 155);
            enter.Name = "enter";
            enter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            enter.Size = new Size(97, 30);
            enter.TabIndex = 3;
            enter.Text = "ENTER";
            enter.Click += enter_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderRadius = 15;
            guna2Button2.CustomizableEdges = customizableEdges7;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.IndianRed;
            guna2Button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(369, 155);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button2.Size = new Size(97, 30);
            guna2Button2.TabIndex = 4;
            guna2Button2.Text = "CANCEL";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ombree;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 227);
            Controls.Add(guna2Button2);
            Controls.Add(enter);
            Controls.Add(textbox);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2PictureBox1);
            Name = "Form2";
            Text = "CARD NUMBER";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox textbox;
        private Guna.UI2.WinForms.Guna2Button enter;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}