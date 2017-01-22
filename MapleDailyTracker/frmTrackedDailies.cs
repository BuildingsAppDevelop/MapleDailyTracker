using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleDailyTracker
{
    public partial class frmTrackedDailies : Form
    {
        public frmTrackedDailies()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private static String resetTimeString = "19:00:00";
        private static DateTime resetTime = Convert.ToDateTime(resetTimeString);
        private static int j;
        private static TimeSpan TimeRemaining;

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeRemaining = resetTime - DateTime.Now;
            label1.Text = TimeRemaining.Hours + " : " + TimeRemaining.Minutes + " : " + TimeRemaining.Seconds;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (listOfDailies.Items.Count == 0)
            {
                this.Close();
            }
            if (listOfDailies.Items.Count != 0)
            {
                MessageBox.Show("You still have dailies to do!", "Meme");
            }
        }

        private void btnDailyCheck_Click(object sender, EventArgs e)
        {
            j = listOfDailies.SelectedIndex;
            if (j != -1)
            {
                Form1.finalDailyList -= Form1.finalDailyList[j];
                listOfDailies.Items.RemoveAt(j);
            }
           
        }

        private void frmTrackedDailies_Load(object sender, EventArgs e)
        {
            listOfDailies.Items.Clear();
            for (int i = 0; i < Form1.finalDailyList.Count; i++)
            {
                Daily d = Form1.finalDailyList[i];
                listOfDailies.Items.Add(d.GetDisplayText());
            }
        }
    }
}
