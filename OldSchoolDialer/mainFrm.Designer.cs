namespace OldSchoolDialer
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dividerImg = new System.Windows.Forms.PictureBox();
            this.saveChkbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPic
            // 
            this.logoPic.Image = global::OldSchoolDialer.Properties.Resources.internetlogo;
            this.logoPic.Location = new System.Drawing.Point(-3, -1);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(105, 69);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPic.TabIndex = 0;
            this.logoPic.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(14, 107);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 15);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(17, 136);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // userTextbox
            // 
            this.userTextbox.Location = new System.Drawing.Point(121, 104);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(177, 23);
            this.userTextbox.TabIndex = 3;
            this.userTextbox.Text = "turboman1";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(121, 133);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(177, 23);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.Text = "hunter2";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(176, 292);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 5;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(257, 292);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "SuperstarISP";
            // 
            // dividerImg
            // 
            this.dividerImg.Image = global::OldSchoolDialer.Properties.Resources.divider;
            this.dividerImg.Location = new System.Drawing.Point(17, 74);
            this.dividerImg.Name = "dividerImg";
            this.dividerImg.Size = new System.Drawing.Size(337, 10);
            this.dividerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dividerImg.TabIndex = 8;
            this.dividerImg.TabStop = false;
            // 
            // saveChkbox
            // 
            this.saveChkbox.AutoSize = true;
            this.saveChkbox.Checked = true;
            this.saveChkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveChkbox.Location = new System.Drawing.Point(83, 169);
            this.saveChkbox.Name = "saveChkbox";
            this.saveChkbox.Size = new System.Drawing.Size(103, 19);
            this.saveChkbox.TabIndex = 9;
            this.saveChkbox.Text = "Save password";
            this.saveChkbox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OldSchoolDialer.Properties.Resources.divider;
            this.pictureBox1.Location = new System.Drawing.Point(19, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phone number";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(121, 217);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(127, 23);
            this.phoneTextbox.TabIndex = 12;
            this.phoneTextbox.Text = "5559874312";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(19, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dialing from";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "New location"});
            this.comboBox1.Location = new System.Drawing.Point(122, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 23);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "New location";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(257, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Dial properties";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(397, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveChkbox);
            this.Controls.Add(this.dividerImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.logoPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Connect to";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logoPic;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox userTextbox;
        private TextBox passwordTextbox;
        private Button connectBtn;
        private Button cancelBtn;
        private System.Windows.Forms.Timer progressTimer;
        private Label label1;
        private PictureBox dividerImg;
        private CheckBox saveChkbox;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox phoneTextbox;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
    }
}