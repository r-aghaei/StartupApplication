using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace StartupApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            IsInStartup();
            checkBox1.Checked = IsInStartup();
        }
        bool IsInStartup()
        {
            var startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            var exeFilePath = Application.ExecutablePath;
            var appName = Path.GetFileNameWithoutExtension(exeFilePath);
            var lnkFilePath = Path.Combine(startupPath, $"{appName}.lnk");
            if (File.Exists(lnkFilePath))
                return true;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            var exeFilePath = Application.ExecutablePath;
            var appName = Path.GetFileNameWithoutExtension(exeFilePath);
            var lnkFilePath = Path.Combine(startupPath, $"{appName}.lnk");
            if (checkBox1.Checked)
            {
                if (File.Exists(lnkFilePath))
                    return;
                var lnk = (IShellLinkW)new ShellLink();
                lnk.SetPath(exeFilePath);
                lnk.SetIconLocation(exeFilePath, 0);
                var file = (IPersistFile)lnk;
                file.Save(lnkFilePath, false);
            }
            else
            {
                if (File.Exists(lnkFilePath))
                    File.Delete(lnkFilePath);
            }

        }
    }
}
