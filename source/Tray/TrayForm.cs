using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tray
{
    using Microsoft.Owin.Host.HttpListener;
    using Microsoft.Owin.Hosting;
    using SourceCodeProxy;
    using SourceCodeProxy.Tray.Properties;

    public partial class TrayForm : Form
    {
        private bool _visible;
        private static IDisposable _webApp;
        private SettingsConfigurationProxy _settingsConfigurationProxy;

        public TrayForm()
        {
            InitializeComponent();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!_visible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        private void TrayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            _visible = false;
            e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _visible = true;
            Show();
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();

            if (_webApp == null)
            {
                _webApp = WebApp.Start(new StartOptions(Settings.Default.proxyAddress), app =>
                {
                    app.UseSourceCodeProxy(new SourceCodeProxyOptions
                    {
                        ProxyConfiguration = _settingsConfigurationProxy
                    });
                });
                startStopButton.Text = "Stop";
            }
            else
            {
                _webApp.Dispose();
                startStopButton.Text = "Start";
            }
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }
    }

    internal class SettingsConfigurationProxy : IProxyConfiguration
    {
        public string StashBaseUrl => Settings.Default.stashBaseUrl;

        public string StashUser => Settings.Default.stashUser;

        public string StashPassword => Settings.Default.stashPassword;
    }
}
