namespace myFirstApp
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lableName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTxt_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTxt_ID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuPictureBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuLable_topic = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(123, 214);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(139, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // textPassword
            // 
            this.textPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Location = new System.Drawing.Point(123, 254);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(139, 20);
            this.textPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lableName
            // 
            this.lableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lableName.AutoSize = true;
            this.lableName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lableName.Location = new System.Drawing.Point(142, 36);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(184, 31);
            this.lableName.TabIndex = 3;
            this.lableName.Text = "MECHANIST";
            this.lableName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(169, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(76, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginPictureBox.Image = global::myFirstApp.Properties.Resources.download;
            this.loginPictureBox.Location = new System.Drawing.Point(186, 97);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(89, 90);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPictureBox.TabIndex = 6;
            this.loginPictureBox.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton21);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTxt_Password);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTxt_ID);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLable_topic);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(499, 12);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(452, 493);
            this.bunifuGradientPanel1.TabIndex = 7;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 50;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "LOGIN";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Gold;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(111, 372);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(235, 49);
            this.bunifuThinButton21.TabIndex = 14;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuTxt_Password
            // 
            this.bunifuTxt_Password.BackColor = System.Drawing.Color.White;
            this.bunifuTxt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTxt_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuTxt_Password.ForeColor = System.Drawing.Color.Black;
            this.bunifuTxt_Password.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuTxt_Password.HintText = "";
            this.bunifuTxt_Password.isPassword = false;
            this.bunifuTxt_Password.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuTxt_Password.LineIdleColor = System.Drawing.Color.Black;
            this.bunifuTxt_Password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuTxt_Password.LineThickness = 3;
            this.bunifuTxt_Password.Location = new System.Drawing.Point(74, 294);
            this.bunifuTxt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTxt_Password.Name = "bunifuTxt_Password";
            this.bunifuTxt_Password.Size = new System.Drawing.Size(315, 34);
            this.bunifuTxt_Password.TabIndex = 13;
            this.bunifuTxt_Password.Text = "Password";
            this.bunifuTxt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuTxt_ID
            // 
            this.bunifuTxt_ID.BackColor = System.Drawing.Color.White;
            this.bunifuTxt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTxt_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuTxt_ID.ForeColor = System.Drawing.Color.Black;
            this.bunifuTxt_ID.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuTxt_ID.HintText = "";
            this.bunifuTxt_ID.isPassword = false;
            this.bunifuTxt_ID.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuTxt_ID.LineIdleColor = System.Drawing.Color.Black;
            this.bunifuTxt_ID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuTxt_ID.LineThickness = 3;
            this.bunifuTxt_ID.Location = new System.Drawing.Point(74, 242);
            this.bunifuTxt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTxt_ID.Name = "bunifuTxt_ID";
            this.bunifuTxt_ID.Size = new System.Drawing.Size(315, 33);
            this.bunifuTxt_ID.TabIndex = 12;
            this.bunifuTxt_ID.Text = "ID";
            this.bunifuTxt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuPictureBox
            // 
            this.bunifuPictureBox.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuPictureBox.Image = global::myFirstApp.Properties.Resources.download;
            this.bunifuPictureBox.ImageActive = null;
            this.bunifuPictureBox.Location = new System.Drawing.Point(195, 25);
            this.bunifuPictureBox.Name = "bunifuPictureBox";
            this.bunifuPictureBox.Size = new System.Drawing.Size(71, 71);
            this.bunifuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox.TabIndex = 9;
            this.bunifuPictureBox.TabStop = false;
            this.bunifuPictureBox.Zoom = 10;
            // 
            // bunifuLable_topic
            // 
            this.bunifuLable_topic.AutoSize = true;
            this.bunifuLable_topic.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLable_topic.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLable_topic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuLable_topic.Location = new System.Drawing.Point(64, 117);
            this.bunifuLable_topic.Name = "bunifuLable_topic";
            this.bunifuLable_topic.Size = new System.Drawing.Size(342, 57);
            this.bunifuLable_topic.TabIndex = 8;
            this.bunifuLable_topic.Text = "ADMIN LOGIN";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.bunifuTxt_ID;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(966, 508);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lableName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.txtUserName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuLable_topic;
        private Bunifu.Framework.UI.BunifuImageButton bunifuPictureBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuTxt_ID;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuTxt_Password;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}