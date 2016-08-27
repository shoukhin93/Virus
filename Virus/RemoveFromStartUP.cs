using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Virus
{
    public static class RemoveFromStartUP
    {
        public static void RemoveApplicationFromStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\windows\\CurrentVersion\\Run", true))
            {
                key.DeleteValue("VIRUS", false);
            }
        }
    }
}
