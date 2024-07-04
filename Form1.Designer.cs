namespace unblockIP_forIPBan
{
    partial class App
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
            this.myComboBox = new System.Windows.Forms.ComboBox();
            this.buttonReadFirewall = new System.Windows.Forms.Button();
            this.buttonUnblockIP = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // myComboBox
            // 
            this.myComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.myComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myComboBox.FormattingEnabled = true;
            this.myComboBox.Location = new System.Drawing.Point(9, 10);
            this.myComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.myComboBox.Name = "myComboBox";
            this.myComboBox.Size = new System.Drawing.Size(259, 357);
            this.myComboBox.TabIndex = 2;
            // 
            // buttonReadFirewall
            // 
            this.buttonReadFirewall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadFirewall.Location = new System.Drawing.Point(272, 43);
            this.buttonReadFirewall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReadFirewall.Name = "buttonReadFirewall";
            this.buttonReadFirewall.Size = new System.Drawing.Size(107, 26);
            this.buttonReadFirewall.TabIndex = 3;
            this.buttonReadFirewall.Text = "Read Firewall";
            this.buttonReadFirewall.UseVisualStyleBackColor = true;
            this.buttonReadFirewall.Click += new System.EventHandler(this.buttonReadFirewall_Click);
            // 
            // buttonUnblockIP
            // 
            this.buttonUnblockIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnblockIP.Location = new System.Drawing.Point(272, 10);
            this.buttonUnblockIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUnblockIP.Name = "buttonUnblockIP";
            this.buttonUnblockIP.Size = new System.Drawing.Size(107, 28);
            this.buttonUnblockIP.TabIndex = 4;
            this.buttonUnblockIP.Text = "Unblock IP";
            this.buttonUnblockIP.UseVisualStyleBackColor = true;
            this.buttonUnblockIP.Click += new System.EventHandler(this.buttonUnblockIP_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(272, 74);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 26);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 366);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUnblockIP);
            this.Controls.Add(this.buttonReadFirewall);
            this.Controls.Add(this.myComboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "App";
            this.Text = "Unblock IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox myComboBox;
        private System.Windows.Forms.Button buttonReadFirewall;
        private System.Windows.Forms.Button buttonUnblockIP;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
    }
}
