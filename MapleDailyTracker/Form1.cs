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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool pqOnly;
        public static bool pqBoss;
        public static bool pqQuest;
        public static bool pqBossQuest;
        public static bool bossOnly;
        public static bool bossQuest;
        public static bool questONly;
        public static DailyList finalDailyList = new DailyList();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxBoss.Checked == true &&
                checkBoxPQ.Checked == true &&
                checkBoxQuests.Checked == true)
            {
                pqBossQuest = true;
                this.Hide();
                frmPQ pqForm = new frmPQ();
                pqForm.ShowDialog();
                this.Close();
            }
            if (checkBoxBoss.Checked == false &&
                checkBoxPQ.Checked == false &&
                checkBoxQuests.Checked == false)
            {
                MessageBox.Show("Please select at least one of the three options. \n"
                    + "Why even use this tracker if you aren't going to select anything?", "Fucking idiot");
            }
            if (checkBoxBoss.Checked == true &&
                checkBoxPQ.Checked == false &&
                checkBoxQuests.Checked == false)
            {
                this.Hide();
                bossOnly = true;
                frmBoss bossForm = new frmBoss();
                bossForm.ShowDialog();
                this.Close();

            }
            if (checkBoxBoss.Checked == true &&
                checkBoxPQ.Checked == true &&
                checkBoxQuests.Checked == false)
            {
                this.Hide();
                pqBoss = true;
                frmPQ PQform = new frmPQ();
                PQform.ShowDialog();
                this.Close();

            } 
            if (checkBoxBoss.Checked == false &&
                checkBoxPQ.Checked == true &&
                checkBoxQuests.Checked == false)
            {
                this.Hide();
                pqOnly = true;
                frmPQ PQform = new frmPQ();
                PQform.ShowDialog();
                this.Close();
            }
            if (checkBoxBoss.Checked == false &&
                checkBoxPQ.Checked == true &&
                checkBoxQuests.Checked == true)
            {
                this.Hide();
                pqQuest = true;
                frmPQ pqForm = new frmPQ();
                pqForm.ShowDialog();
                this.Close();
            }
            if (checkBoxBoss.Checked == false &&
                checkBoxPQ.Checked == false &&
                checkBoxQuests.Checked == true)
            {
                this.Hide();
                questONly = true;
                frmQuest questForm = new frmQuest();
                questForm.ShowDialog();
                this.Close();
            }
            if (checkBoxBoss.Checked == true &&
                checkBoxPQ.Checked == false &&
                checkBoxQuests.Checked == true)
            {
                this.Hide();
                bossQuest = true;
                frmBoss bossForm = new frmBoss();
                bossForm.ShowDialog();
                this.Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
