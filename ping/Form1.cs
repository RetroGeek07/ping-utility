using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void First_Octet_TextChanged(object sender, EventArgs e)
        {
            First_Octet.MaxLength = 3;
            First_Octet.TabIndex = 1;
            First_Octet.TabStop = true;
            if (First_Octet.TextLength == 3)
                Second_Octet.Focus();
        }

        private void Second_Octet_TextChanged(object sender, EventArgs e)
        {
            Second_Octet.MaxLength = 3;
            Second_Octet.TabIndex = 2;
            Second_Octet.TabStop = true;
            if (Second_Octet.TextLength == 3)
                Third_Octet.Focus();
        }

        private void Third_Octet_TextChanged(object sender, EventArgs e)
        {
            Third_Octet.MaxLength = 3;
            Third_Octet.TabIndex = 3;
            Third_Octet.TabStop = true;
                if(Third_Octet.TextLength==3)
                    Fourth_Octet.Focus();
        }

        private void Fourth_Octet_TextChanged(object sender, EventArgs e)
        {
            Fourth_Octet.MaxLength = 3;
            Fourth_Octet.TabIndex = 4;
            Fourth_Octet.TabStop = true;
            if (Fourth_Octet.TextLength == 3)
                Ping_button.Focus();
           
        }

        private void Ping_button_Click(object sender, EventArgs e)
        {
            if (First_Octet.Text == "" || Second_Octet.Text == "" || Third_Octet.Text == "" || Fourth_Octet.Text == "")
            {
                MessageBox.Show("Empty Octet/s");
                Ping_button.Focus();
            }
            else
            {
                int number1;
                number1 = Convert.ToInt32(First_Octet.Text);
                //--------------------------------------------
                int number2;
                number2 = Convert.ToInt32(Second_Octet.Text);
                //----------------------------------------------
                int number3;
                number3 = Convert.ToInt32(Third_Octet.Text);
                //----------------------------------------------
                int number4;
                number4 = Convert.ToInt32(Fourth_Octet.Text);
                //------------------------------------------------
                if (number1 > 256 || number2 > 256 || number3 > 256 || number4 > 256)
                {
                    MessageBox.Show("Invalid IP Address");
                    Ping_button.Focus();

                }
                //-------------------------------------------

                else
                {
                    var proc1 = new ProcessStartInfo();
                    proc1.UseShellExecute = true;
                    proc1.WorkingDirectory = @"C:\Windows\System32";
                    proc1.FileName = @"C:\Windows\System32\cmd.exe";
                    proc1.Arguments = "/k ping " + First_Octet.Text + First_Dot.Text + Second_Octet.Text + Second_Dot.Text + Third_Octet.Text + Third_Dot.Text + Fourth_Octet.Text;
                    proc1.WindowStyle = ProcessWindowStyle.Normal;
                    Process.Start(proc1);
                }
            }

        }

//------------------------------------------------------------------------------------------------
        //------------------------------------------------------------
        //-----Code haye ipconfig


        private void IPConfig_Button_Click(object sender, EventArgs e)
        {
            if (Parameters.SelectedItem=="All")
            {
                var proc2 = new ProcessStartInfo();
                proc2.UseShellExecute = true;
                proc2.WorkingDirectory = @"C:\Windows\System32";
                proc2.FileName = @"C:\Windows\System32\cmd.exe";
                proc2.Arguments = "/k IPConfig /all ";
                proc2.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(proc2);
            }
            else if(Parameters.SelectedItem=="Renew"){
                var proc2 = new ProcessStartInfo();
                proc2.UseShellExecute = true;
                proc2.WorkingDirectory = @"C:\Windows\System32";
                proc2.FileName = @"C:\Windows\System32\cmd.exe";
                proc2.Arguments = "/k IPConfig /renew";
                proc2.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(proc2);

        }else if(Parameters.SelectedItem=="Release")
            {
              var proc2 = new ProcessStartInfo();
                proc2.UseShellExecute = true;
                proc2.WorkingDirectory = @"C:\Windows\System32";
                proc2.FileName = @"C:\Windows\System32\cmd.exe";
                proc2.Arguments = "/k IPConfig /release";
                proc2.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(proc2);
        }else
            {
              var proc2 = new ProcessStartInfo();
                proc2.UseShellExecute = true;
                proc2.WorkingDirectory = @"C:\Windows\System32";
                proc2.FileName = @"C:\Windows\System32\cmd.exe";
                proc2.Arguments = "/k IPConfig";
                proc2.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(proc2);
        }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Parameters.Items.Add("None");
            Parameters.SelectedItem = "None";
            Parameters.Items.Add("All");
            Parameters.Items.Add("Release");
            Parameters.Items.Add("Renew");
        }

        private void Parameters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        }
}
