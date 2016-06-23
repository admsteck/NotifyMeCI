using System;
using System.Windows;
using System.Windows.Forms;

namespace NofityMeCI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private NotifyIcon _icon;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ShutdownMode = ShutdownMode.OnExplicitShutdown;
            InitIcon();
        }

        private void InitIcon()
        {
            _icon = new NotifyIcon
            {
                Icon = new System.Drawing.Icon("Resources\\green_icon.ico"),
                ContextMenu = InitContextMenu(),
                Visible = true
            };
            _icon.DoubleClick += ShowWindow;
        }

        private ContextMenu InitContextMenu()
        {
            var cm = new ContextMenu();
            cm.MenuItems.Add("Exit", ExitClick);
            return cm;
        }

        private void ShowWindow(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            _icon.Visible = false;
            Current.Shutdown();
        }
    }
}
