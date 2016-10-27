namespace Tray
{
    partial class TrayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stashPasswordTextBox = new System.Windows.Forms.TextBox();
            this.stashUserTextBox = new System.Windows.Forms.TextBox();
            this.stashBaseUrlTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.proxyAddressTextBox = new System.Windows.Forms.TextBox();
            this.trayMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "SourceCodeProxy";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayMenuStrip.Name = "trayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(113, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit!";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(341, 175);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stash Base URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stash User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stash Password:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 201);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(428, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.Text = "Ready.";
            // 
            // stashPasswordTextBox
            // 
            this.stashPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SourceCodeProxy.Tray.Properties.Settings.Default, "stashPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stashPasswordTextBox.Location = new System.Drawing.Point(12, 142);
            this.stashPasswordTextBox.Name = "stashPasswordTextBox";
            this.stashPasswordTextBox.Size = new System.Drawing.Size(134, 20);
            this.stashPasswordTextBox.TabIndex = 4;
            this.stashPasswordTextBox.Text = global::SourceCodeProxy.Tray.Properties.Settings.Default.stashPassword;
            this.stashPasswordTextBox.UseSystemPasswordChar = true;
            this.stashPasswordTextBox.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // stashUserTextBox
            // 
            this.stashUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SourceCodeProxy.Tray.Properties.Settings.Default, "stashUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stashUserTextBox.Location = new System.Drawing.Point(12, 103);
            this.stashUserTextBox.Name = "stashUserTextBox";
            this.stashUserTextBox.Size = new System.Drawing.Size(134, 20);
            this.stashUserTextBox.TabIndex = 3;
            this.stashUserTextBox.Text = global::SourceCodeProxy.Tray.Properties.Settings.Default.stashUser;
            this.stashUserTextBox.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // stashBaseUrlTextBox
            // 
            this.stashBaseUrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SourceCodeProxy.Tray.Properties.Settings.Default, "stashBaseUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stashBaseUrlTextBox.Location = new System.Drawing.Point(12, 64);
            this.stashBaseUrlTextBox.Name = "stashBaseUrlTextBox";
            this.stashBaseUrlTextBox.Size = new System.Drawing.Size(273, 20);
            this.stashBaseUrlTextBox.TabIndex = 2;
            this.stashBaseUrlTextBox.Text = global::SourceCodeProxy.Tray.Properties.Settings.Default.stashBaseUrl;
            this.stashBaseUrlTextBox.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Proxy Address:";
            // 
            // proxyAddressTextBox
            // 
            this.proxyAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SourceCodeProxy.Tray.Properties.Settings.Default, "proxyAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.proxyAddressTextBox.Location = new System.Drawing.Point(12, 25);
            this.proxyAddressTextBox.Name = "proxyAddressTextBox";
            this.proxyAddressTextBox.Size = new System.Drawing.Size(273, 20);
            this.proxyAddressTextBox.TabIndex = 10;
            this.proxyAddressTextBox.Text = global::SourceCodeProxy.Tray.Properties.Settings.Default.proxyAddress;
            // 
            // TrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 223);
            this.Controls.Add(this.proxyAddressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stashPasswordTextBox);
            this.Controls.Add(this.stashUserTextBox);
            this.Controls.Add(this.stashBaseUrlTextBox);
            this.Controls.Add(this.startStopButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Source Code Proxy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrayForm_FormClosing);
            this.trayMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.TextBox stashBaseUrlTextBox;
        private System.Windows.Forms.TextBox stashUserTextBox;
        private System.Windows.Forms.TextBox stashPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox proxyAddressTextBox;
    }
}

