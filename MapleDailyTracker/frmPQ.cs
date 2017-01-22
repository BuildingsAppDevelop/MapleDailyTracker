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
    public partial class frmPQ : Form
    {
        public frmPQ()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            checkPQs();
            if (Form1.pqOnly == true)
            {
                this.Hide();
                frmTrackedDailies trackedDailiesForm = new frmTrackedDailies();
                trackedDailiesForm.ShowDialog();
                this.Close();
            }
            if (Form1.pqBoss == true || Form1.pqBossQuest == true)
            {
                this.Hide();
                frmBoss bossForm = new frmBoss();
                bossForm.ShowDialog();
                this.Close();
            }
            if (Form1.pqQuest == true)
            {
                this.Hide();
                frmQuest questForm = new frmQuest();
                questForm.ShowDialog();
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void checkPQs()
        {
           if (mutoYes.Checked == true)
            {
                String mutoPQ = "Hungry Muto PQ";
                Daily muto = new Daily(mutoYes.Checked, mutoPQ);
                Form1.finalDailyList.Add(muto);
            }
           if (mpYes.Checked == true)
            {
                String monsterPQ = "Monster Park";
                Daily monsterPark = new Daily(mpYes.Checked, monsterPQ);
                Form1.finalDailyList.Add(monsterPark);
            }
           if (cpqYes.Checked == true)
            {
                String commerciPQ = "Commerci PQ";
                Daily cpq = new Daily(cpqYes.Checked, commerciPQ);
                Form1.finalDailyList.Add(cpq);
            }
           if (commerciYes.Checked == true)
            {
                String commerciSolo = "Commerci Solo Voyage";
                Daily commerci = new Daily(commerciYes.Checked, commerciSolo);
                Form1.finalDailyList.Add(commerci);
            }
           if (dimensionYes.Checked == true)
            {
                String diPQ = "Dimension Invasion PQ";
                Daily dimensionInvasion = new Daily(dimensionYes.Checked, diPQ);
                Form1.finalDailyList.Add(dimensionInvasion);
            }
        }
    }
}
