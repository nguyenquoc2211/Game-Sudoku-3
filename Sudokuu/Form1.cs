using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudokuu
{
    public partial class Form1 : Form
    {
        int hour, minute, second;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            Menu.Font = new Font(Menu.Font, FontStyle.Italic | FontStyle.Bold);
            
        }
        Timer t = new Timer();
        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            Menu.Font = new Font(Menu.Font, FontStyle.Bold);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Shutdown", "-s -t 10");
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        sdfsdf

        // timer EventHandler
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            minute += second / 60; second %= 60;
            hour += minute / 60; minute %= 60;
            Time.Text = (hour / 10).ToString() + (hour % 10).ToString() + ":" + (minute / 10).ToString()
                + (minute % 10).ToString() + ":" + (second / 10).ToString() + (second % 10).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Time.Text = "00:00:00";
            hour = 0;
            minute = 0;
            second = 0;
        }
    }
}
