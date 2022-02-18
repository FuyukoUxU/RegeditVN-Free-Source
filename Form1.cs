using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace regeditvn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://discord.gg/KJr7tPAtf4";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false; // start without shell
            p.StartInfo.RedirectStandardInput = true; // call CMD to accept the standard input
            p.StartInfo.RedirectStandardOutput = false; // don't want to listen to CMD, so don't output
            p.StartInfo.RedirectStandardError = true; // redirects the standard error output
            p.StartInfo.CreateNoWindow = true; // do not show window
            p.Start();

            //Send the & exit after the input information to the CMD window to tell CMD to exit after running
            p.StandardInput.WriteLine("start " + url + "&exit");
            p.StandardInput.AutoFlush = true;
            p.WaitForExit(); // wait for the program to finish executing and exit the process
            p.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/channel/UCodFHez30WsDNfdGxKFUU_w";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false; // start without shell
            p.StartInfo.RedirectStandardInput = true; // call CMD to accept the standard input
            p.StartInfo.RedirectStandardOutput = false; // don't want to listen to CMD, so don't output
            p.StartInfo.RedirectStandardError = true; // redirects the standard error output
            p.StartInfo.CreateNoWindow = true; // do not show window
            p.Start();

            //Send the & exit after the input information to the CMD window to tell CMD to exit after running
            p.StandardInput.WriteLine("start " + url + "&exit");
            p.StandardInput.AutoFlush = true;
            p.WaitForExit(); // wait for the program to finish executing and exit the process
            p.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/groups/regeditvn";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false; // start without shell
            p.StartInfo.RedirectStandardInput = true; // call CMD to accept the standard input
            p.StartInfo.RedirectStandardOutput = false; // don't want to listen to CMD, so don't output
            p.StartInfo.RedirectStandardError = true; // redirects the standard error output
            p.StartInfo.CreateNoWindow = true; // do not show window
            p.Start();

            //Send the & exit after the input information to the CMD window to tell CMD to exit after running
            p.StandardInput.WriteLine("start " + url + "&exit");
            p.StandardInput.AutoFlush = true;
            p.WaitForExit(); // wait for the program to finish executing and exit the process
            p.Close();
        }

        private bool FreeEnabled = false;
        private void rjButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void rjButton2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void rjButton2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private bool Free2Enabled = false;
        private void rjButton3_MouseDown(object sender, MouseEventArgs e)
        {
            string pathToFile3 = @"C:\Windows\Temp\1.bat";
            using (var client = new System.Net.WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/869752773632213063/890230593252646962/1.bat", pathToFile3);
            }
            System.Diagnostics.Process.Start(pathToFile3);
            MessageBox.Show("Đã fix lỗi mousekeys");
            if (File.Exists(pathToFile3)) File.Delete(pathToFile3);
        }
        private void rjButton4_MouseDown(object sender, MouseEventArgs e)
        {
            string pathToFile2 = @"C:\Windows\Temp\3.bat";
            using (var client = new System.Net.WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/869752773632213063/890230674236268574/3.bat", pathToFile2);
            }

            try
            {
                System.Diagnostics.Process.Start(pathToFile2);
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
            MessageBox.Show("Đã fix double click speed!");
            if (File.Exists(pathToFile2)) File.Delete(pathToFile2);
        }

        private void rjButton5_MouseDown(object sender, MouseEventArgs e)
        {
            string pathToFile4 = @"C:\Windows\Temp\h.bat";
            using (var client = new System.Net.WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/714344012600967218/890256651003768852/h.bat", pathToFile4);
            }

            try
            {
                System.Diagnostics.Process.Start(pathToFile4);
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
            MessageBox.Show("Đã clear reg thành công!");
            if (File.Exists(pathToFile4)) File.Delete(pathToFile4);
        }

        private void rjButton6_MouseDown(object sender, MouseEventArgs e)
        {
            string pathToFile = @"C:\Windows\Temp\2.bat";
            using (var client = new System.Net.WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/869752773632213063/890232986723811378/2.bat", pathToFile);
            }
            
            
            if (FreeEnabled == true)
            {
                rjButton8.BackColor = Color.DimGray;
                MessageBox.Show("Regedit Free đã được tắt đi!");
                FreeEnabled = false;
            }
            else
            {
                rjButton8.BackColor = Color.FromArgb(100, 0, 192, 0);
                System.Diagnostics.Process.Start(pathToFile);
                MessageBox.Show("Regedit Free đã cài thành công!");
                FreeEnabled = true;
            }
            try
            {
                File.Delete(pathToFile);
            }
            catch
            {

            }
        }

        private void rjButton7_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
