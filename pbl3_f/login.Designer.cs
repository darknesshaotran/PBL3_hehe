namespace pbl3_f
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Login_btn = new System.Windows.Forms.Button();
            this.annouce_lbl = new System.Windows.Forms.Label();
            this.User_TXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pass_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.display_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.exit_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.display_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.UseWaitCursor = true;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.Login_btn, "Login_btn");
            this.Login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.UseWaitCursor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // annouce_lbl
            // 
            resources.ApplyResources(this.annouce_lbl, "annouce_lbl");
            this.annouce_lbl.Name = "annouce_lbl";
            this.annouce_lbl.UseWaitCursor = true;
            // 
            // User_TXT
            // 
            this.User_TXT.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.User_TXT, "User_TXT");
            this.User_TXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.User_TXT.HintForeColor = System.Drawing.Color.Empty;
            this.User_TXT.HintText = "";
            this.User_TXT.isPassword = false;
            this.User_TXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.User_TXT.LineIdleColor = System.Drawing.Color.Gray;
            this.User_TXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.User_TXT.LineThickness = 3;
            this.User_TXT.Name = "User_TXT";
            this.User_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.User_TXT.UseWaitCursor = true;
            // 
            // pass_txt
            // 
            this.pass_txt.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.pass_txt, "pass_txt");
            this.pass_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass_txt.HintForeColor = System.Drawing.Color.Empty;
            this.pass_txt.HintText = "";
            this.pass_txt.isPassword = true;
            this.pass_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.pass_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.pass_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pass_txt.LineThickness = 3;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass_txt.UseWaitCursor = true;
            this.pass_txt.OnValueChanged += new System.EventHandler(this.pass_txt_OnValueChanged_1);
            // 
            // display_btn
            // 
            this.display_btn.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.display_btn, "display_btn");
            this.display_btn.Image = global::pbl3_f.Properties.Resources.eyess;
            this.display_btn.ImageActive = null;
            this.display_btn.Name = "display_btn";
            this.display_btn.TabStop = false;
            this.display_btn.UseWaitCursor = true;
            this.display_btn.Zoom = 10;
            this.display_btn.Click += new System.EventHandler(this.display_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pbl3_f.Properties.Resources.llllll;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bunifuImageButton2, "bunifuImageButton2");
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.UseWaitCursor = true;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bunifuImageButton1, "bunifuImageButton1");
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.UseWaitCursor = true;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // exit_btn
            // 
            this.exit_btn.ActiveBorderThickness = 1;
            this.exit_btn.ActiveCornerRadius = 20;
            this.exit_btn.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.exit_btn.ActiveForecolor = System.Drawing.Color.White;
            this.exit_btn.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.exit_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.exit_btn, "exit_btn");
            this.exit_btn.ButtonText = "Exit";
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.exit_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.exit_btn.IdleBorderThickness = 1;
            this.exit_btn.IdleCornerRadius = 20;
            this.exit_btn.IdleFillColor = System.Drawing.Color.White;
            this.exit_btn.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.exit_btn.IdleLineColor = System.Drawing.Color.White;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_btn.UseWaitCursor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.display_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.User_TXT);
            this.Controls.Add(this.annouce_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.display_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button Login_btn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label annouce_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox User_TXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass_txt;
        private Bunifu.Framework.UI.BunifuImageButton display_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 exit_btn;
    }
}

