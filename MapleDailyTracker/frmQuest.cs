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
    public partial class frmQuest : Form
    {
        public frmQuest()
        {
            InitializeComponent();
        }

        private List<bool> questList = new List<bool>();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkQuests();
            frmTrackedDailies trackedDailiesForm = new frmTrackedDailies();
            trackedDailiesForm.ShowDialog();
            this.Close(); 
        }

        private void checkQuests()
        {
            if (vanishingYes.Checked == true)
            {
                String vanishingJourney = "Vanishing Journey Dailies";
                Daily vjQuest = new Daily(vanishingYes.Checked, vanishingJourney);
                Form1.finalDailyList.Add(vjQuest);
            }
            if (kritiasYes.Checked == true)
            {
                String kritias = "Kritias Dailies";
                Daily krit = new Daily(kritiasYes.Checked, kritias);
                Form1.finalDailyList.Add(krit);
            }
            if (scrapYes.Checked == true)
            {
                String scrapyard = "Scrapyard Dailies";
                Daily scrap = new Daily(scrapYes.Checked, scrapyard);
                Form1.finalDailyList.Add(scrap);
            }
            if (empresskeyYes.Checked == true)
            {
                String empresskey = "Empress Keys";
                Daily empkey = new Daily(empresskeyYes.Checked, empresskey);
                Form1.finalDailyList.Add(empkey);
            }
            if (yugardenYes.Checked == true)
            {
                String yugarden = "Yu Garden Dailies";
                Daily yug = new Daily(yugardenYes.Checked, yugarden);
                Form1.finalDailyList.Add(yug);
            }
            if (dwtYes.Checked == true)
            {
                String dwtmeme = "Dark World Tree Dailies";
                Daily dwt = new Daily(dwtYes.Checked, dwtmeme);
                Form1.finalDailyList.Add(dwt);
            }
        }
    }
}
