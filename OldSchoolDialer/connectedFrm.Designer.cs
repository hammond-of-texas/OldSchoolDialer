namespace OldSchoolDialer
{
    partial class connectedFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectedFrm));
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.connectedLbl = new System.Windows.Forms.Label();
            this.speedLbl = new System.Windows.Forms.Label();
            this.closeBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPic
            // 
            this.logoPic.Image = global::OldSchoolDialer.Properties.Resources.internetlogo;
            this.logoPic.Location = new System.Drawing.Point(28, 12);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(105, 69);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPic.TabIndex = 3;
            this.logoPic.TabStop = false;
            // 
            // connectedLbl
            // 
            this.connectedLbl.AutoSize = true;
            this.connectedLbl.Location = new System.Drawing.Point(9, 95);
            this.connectedLbl.Name = "connectedLbl";
            this.connectedLbl.Size = new System.Drawing.Size(147, 15);
            this.connectedLbl.TabIndex = 4;
            this.connectedLbl.Text = "Connected to SuperstarISP";
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(9, 110);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(102, 15);
            this.speedLbl.TabIndex = 5;
            this.speedLbl.Text = "Speed: 128 KBits/s";
            this.speedLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // closeBttn
            // 
            this.closeBttn.Location = new System.Drawing.Point(16, 143);
            this.closeBttn.Name = "closeBttn";
            this.closeBttn.Size = new System.Drawing.Size(126, 39);
            this.closeBttn.TabIndex = 6;
            this.closeBttn.Text = "Close connection";
            this.closeBttn.UseVisualStyleBackColor = true;
            this.closeBttn.Click += new System.EventHandler(this.closeBttn_Click);
            // 
            // connectedFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 194);
            this.Controls.Add(this.closeBttn);
            this.Controls.Add(this.speedLbl);
            this.Controls.Add(this.connectedLbl);
            this.Controls.Add(this.logoPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "connectedFrm";
            this.Text = "Connected";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.connectedFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logoPic;
        private Label connectedLbl;
        private Label speedLbl;
        private Button closeBttn;
    }
}