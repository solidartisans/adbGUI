using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace adbGUI.Forms
{


    public partial class Scrcpy : Form
    {
        private static string scrcpyPath = @"extTools\scrcpy.exe";
        public Scrcpy()
        {
            InitializeComponent();
        }

        private void scrcpyDefaultLaunch_Click(object sender, EventArgs e)
        {

            // Initialize a new ProcessStartInfo instance
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = scrcpyPath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = false
            };

            // Start the process
            Process process = new Process() { StartInfo = psi };
            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., executable not found)
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void scrcpyfullScreenLaunch_Click(object sender, EventArgs e)
        {
            // Initialize a new ProcessStartInfo instance
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = scrcpyPath,
                Arguments = "--fullscreen",  // Launch in full-screen mode
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            // Start the process
            Process process = new Process() { StartInfo = psi };
            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., executable not found)
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        

       
    }
}
