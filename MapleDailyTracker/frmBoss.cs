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
    public partial class frmBoss : Form
    {
        public frmBoss()
        {
            InitializeComponent();
        }

        private List<bool> bossList = new List<bool>();

        private void frmBoss_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            checkBosses();
            if (Form1.bossOnly == true || Form1.pqBoss == true)
            {
                this.Hide();
                frmTrackedDailies trackedDailiesForm = new frmTrackedDailies();
                trackedDailiesForm.ShowDialog();
                this.Close();
            }
            if (Form1.pqBossQuest == true ||
                Form1.bossQuest == true)
            {
                this.Hide();
                frmQuest questForm = new frmQuest();
                questForm.ShowDialog();
                this.Close();
            }
        }

        private void checkBosses()
        {
            if (zakumYes.Checked == true)
            {
                String zakum = "Zakum";
                Daily zak = new Daily(zakumYes.Checked, zakum);
                Form1.finalDailyList.Add(zak);
            }
            if (nhtYes.Checked == true)
            {
                String normalHT = "Normal Horntail";
                Daily nht = new Daily(nhtYes.Checked, normalHT);
                Form1.finalDailyList.Add(nht);
            }
            if (chtYes.Checked == true)
            {
                String chaosHT = "Chaos Horntail";
                Daily cht = new Daily(chtYes.Checked, chaosHT);
                Form1.finalDailyList.Add(cht);
            }
            if (nhillaYes.Checked == true)
            {
                String normalHilla = "Normal Hilla";
                Daily nhilla = new Daily(nhillaYes.Checked, normalHilla);
                Form1.finalDailyList.Add(nhilla);
            }
            if (hhillaYes.Checked == true)
            {
                String hardHilla = "Hard Hilla";
                Daily hhilla = new Daily(hhillaYes.Checked, hardHilla);
                Form1.finalDailyList.Add(hhilla);
            }
            if (nranmaruYes.Checked == true)
            {
                String moriRanmaru = "Mori Ranmaru";
                Daily nRanmaru = new Daily(nranmaruYes.Checked, moriRanmaru);
                Form1.finalDailyList.Add(nRanmaru);
            }
            if (mranmaruYes.Checked == true)
            {
                String madmanRanmaru = "Madman Ranmaru";
                Daily mRanmaru = new Daily(mranmaruYes.Checked, madmanRanmaru);
                Form1.finalDailyList.Add(mRanmaru); ;
            }
            if (narkariumYes.Checked == true)
            {
                String normalArk = "Normal Arkarium";
                Daily nArk = new Daily(narkariumYes.Checked, normalArk);
                Form1.finalDailyList.Add(nArk);
            }
            if (harkariumYes.Checked == true)
            {
                String hardArk = "Hard Arkarium";
                Daily hArk = new Daily(harkariumYes.Checked, hardArk);
                Form1.finalDailyList.Add(hArk);
            }
            if (npbYes.Checked == true)
            {
                String normalPB = "Normal Pink Bean";
                Daily npb = new Daily(npbYes.Checked, normalPB);
                Form1.finalDailyList.Add(npb);
            }
            if (cpbYes.Checked == true)
            {
                String chaosPB = "Chaos Pink Bean";
                Daily cpb = new Daily(cpbYes.Checked, chaosPB);
                Form1.finalDailyList.Add(cpb);
            }
            if (raYes.Checked == true)
            {
                String rootAbyss = "Root Abyss";
                Daily ra = new Daily(raYes.Checked, rootAbyss);
                Form1.finalDailyList.Add(ra);
            }
            if (krexelYes.Checked == true)
            {
                String krex = "Krexel";
                Daily krexel = new Daily(krexelYes.Checked, krex);
                Form1.finalDailyList.Add(krexel);
            }
            if (evlYes.Checked == true)
            {
                String easyVonLeon = "Easy Von Leon";
                Daily evl = new Daily(evlYes.Checked, easyVonLeon);
                Form1.finalDailyList.Add(evl);
            }
            if (nvlYes.Checked == true)
            {
                String normalVonLeon = "Normal Von Leon";
                Daily nvl = new Daily(nvlYes.Checked, normalVonLeon);
                Form1.finalDailyList.Add(nvl);
            }
            if (golluxYes.Checked == true)
            {
                String gollux = "Gollux";
                Daily golluxMeme = new MapleDailyTracker.Daily(golluxYes.Checked, gollux);
                Form1.finalDailyList.Add(golluxMeme);
            }
            if (ecygYes.Checked == true)
            {
                String easyCygnus = "Easy Empress";
                Daily eCyg = new Daily(ecygYes.Checked, easyCygnus);
                Form1.finalDailyList.Add(eCyg);
            }
            if (ncygYes.Checked == true)
            {
                String normalCygnus = "Normal Empress";
                Daily nCyg = new Daily(ncygYes.Checked, normalCygnus);
                Form1.finalDailyList.Add(nCyg);
            }
            if (hmagYes.Checked == true)
            {
                String hardMagnus = "Hard Magnus";
                Daily hmag = new Daily(hmagYes.Checked, hardMagnus);
                Form1.finalDailyList.Add(hmag);
            }
            if (dojoYes.Checked == true)
            {
                String dojo = "Dojo";
                Daily dojoMeme = new Daily(dojoYes.Checked, dojo);
                Form1.finalDailyList.Add(dojoMeme);
            }
            if (cqueenYes.Checked == true)
            {
                String chaosQueen = "Chaos Queen";
                Daily cQueen = new Daily(cqueenYes.Checked, chaosQueen);
                Form1.finalDailyList.Add(cQueen);
            }
            if (cclownYes.Checked == true)
            {
                String chaosClown = "Chaos Pierre";
                Daily cClown = new Daily(cclownYes.Checked, chaosClown);
                Form1.finalDailyList.Add(cClown);
            }
            if (cchickenYes.Checked == true)
            {
                String chaosChicken = "Chaos Von Bon";
                Daily cChicken = new Daily(cchickenYes.Checked, chaosChicken);
                Form1.finalDailyList.Add(cChicken);
            }
            if (csnekYes.Checked == true)
            {
                String chaosSnek = "Chaos Vellum";
                Daily cSnek = new Daily(csnekYes.Checked, chaosSnek);
                Form1.finalDailyList.Add(cSnek);
            }
        }
    }
}
