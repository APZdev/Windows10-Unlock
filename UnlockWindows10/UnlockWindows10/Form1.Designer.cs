namespace UnlockWindows10
{
    partial class windowForm
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
            this.activateButton = new System.Windows.Forms.Button();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.infomationText = new System.Windows.Forms.Label();
            this.movingBar = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.movingBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // activateButton
            // 
            this.activateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(44)))));
            this.activateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.activateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(214)))), ((int)(((byte)(178)))));
            this.activateButton.FlatAppearance.BorderSize = 5;
            this.activateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.activateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(214)))), ((int)(((byte)(178)))));
            this.activateButton.Location = new System.Drawing.Point(207, 97);
            this.activateButton.Name = "activateButton";
            this.activateButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.activateButton.Size = new System.Drawing.Size(155, 71);
            this.activateButton.TabIndex = 0;
            this.activateButton.Text = "Activate";
            this.activateButton.UseVisualStyleBackColor = false;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // dropDown
            // 
            this.dropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(44)))));
            this.dropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(195)))), ((int)(((byte)(201)))));
            this.dropDown.FormattingEnabled = true;
            this.dropDown.IntegralHeight = false;
            this.dropDown.Items.AddRange(new object[] {
            "Profesionnal",
            "Home",
            "Education",
            "Enterprise\t"});
            this.dropDown.Location = new System.Drawing.Point(207, 53);
            this.dropDown.MaxDropDownItems = 4;
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(155, 28);
            this.dropDown.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(195)))), ((int)(((byte)(201)))));
            this.nameLabel.Location = new System.Drawing.Point(36, 195);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Username";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userImage
            // 
            this.userImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userImage.Location = new System.Drawing.Point(5, 5);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(125, 125);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 3;
            this.userImage.TabStop = false;
            // 
            // infomationText
            // 
            this.infomationText.AutoSize = true;
            this.infomationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infomationText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(195)))), ((int)(((byte)(201)))));
            this.infomationText.Location = new System.Drawing.Point(204, 174);
            this.infomationText.Name = "infomationText";
            this.infomationText.Size = new System.Drawing.Size(78, 17);
            this.infomationText.TabIndex = 5;
            this.infomationText.Text = "Information";
            // 
            // movingBar
            // 
            this.movingBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(33)))));
            this.movingBar.Controls.Add(this.closeButton);
            this.movingBar.Location = new System.Drawing.Point(-4, -2);
            this.movingBar.Name = "movingBar";
            this.movingBar.Size = new System.Drawing.Size(409, 32);
            this.movingBar.TabIndex = 6;
            this.movingBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movingBar_MouseDown);
            this.movingBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movingBar_MouseMove);
            this.movingBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.movingBar_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(381, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(15, 15);
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(113)))), ((int)(((byte)(145)))));
            this.panel2.Controls.Add(this.userImage);
            this.panel2.Location = new System.Drawing.Point(40, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 135);
            this.panel2.TabIndex = 7;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Miriam CLM", 10F, System.Drawing.FontStyle.Bold);
            this.statusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(195)))), ((int)(((byte)(201)))));
            this.statusText.Location = new System.Drawing.Point(37, 220);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(48, 16);
            this.statusText.TabIndex = 8;
            this.statusText.Text = "Status";
            // 
            // windowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.ControlBox = false;
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.movingBar);
            this.Controls.Add(this.infomationText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dropDown);
            this.Controls.Add(this.activateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "windowForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.movingBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Label infomationText;
        private System.Windows.Forms.Panel movingBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label statusText;
    }
}

