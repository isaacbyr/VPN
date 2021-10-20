
namespace VPN
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
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.udpButton = new System.Windows.Forms.RadioButton();
            this.tcpButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // serverComboBox
            // 
            this.serverComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Items.AddRange(new object[] {
            "New York",
            "Singapore"});
            this.serverComboBox.Location = new System.Drawing.Point(106, 40);
            this.serverComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(226, 30);
            this.serverComboBox.TabIndex = 0;
            this.serverComboBox.Text = "Select Server";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(162, 159);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(114, 28);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(162, 206);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(114, 28);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // udpButton
            // 
            this.udpButton.AutoSize = true;
            this.udpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpButton.Location = new System.Drawing.Point(142, 95);
            this.udpButton.Margin = new System.Windows.Forms.Padding(4);
            this.udpButton.Name = "udpButton";
            this.udpButton.Size = new System.Drawing.Size(72, 32);
            this.udpButton.TabIndex = 3;
            this.udpButton.TabStop = true;
            this.udpButton.Text = "UDP";
            this.udpButton.UseVisualStyleBackColor = true;
            // 
            // tcpButton
            // 
            this.tcpButton.AutoSize = true;
            this.tcpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpButton.Location = new System.Drawing.Point(231, 95);
            this.tcpButton.Margin = new System.Windows.Forms.Padding(4);
            this.tcpButton.Name = "tcpButton";
            this.tcpButton.Size = new System.Drawing.Size(65, 32);
            this.tcpButton.TabIndex = 4;
            this.tcpButton.TabStop = true;
            this.tcpButton.Text = "TCP";
            this.tcpButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(438, 286);
            this.Controls.Add(this.tcpButton);
            this.Controls.Add(this.udpButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.serverComboBox);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Isaacs VPN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serverComboBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.RadioButton udpButton;
        private System.Windows.Forms.RadioButton tcpButton;
    }
}

