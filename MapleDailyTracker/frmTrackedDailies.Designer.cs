namespace MapleDailyTracker
{
    partial class frmTrackedDailies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listOfDailies = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDailyCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfDailies
            // 
            this.listOfDailies.FormattingEnabled = true;
            this.listOfDailies.Location = new System.Drawing.Point(12, 12);
            this.listOfDailies.Name = "listOfDailies";
            this.listOfDailies.ScrollAlwaysVisible = true;
            this.listOfDailies.Size = new System.Drawing.Size(426, 121);
            this.listOfDailies.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(363, 222);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "&Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time until reset: ";
            // 
            // btnDailyCheck
            // 
            this.btnDailyCheck.Location = new System.Drawing.Point(363, 139);
            this.btnDailyCheck.Name = "btnDailyCheck";
            this.btnDailyCheck.Size = new System.Drawing.Size(75, 23);
            this.btnDailyCheck.TabIndex = 4;
            this.btnDailyCheck.Text = "Clear Daily";
            this.btnDailyCheck.UseVisualStyleBackColor = true;
            this.btnDailyCheck.Click += new System.EventHandler(this.btnDailyCheck_Click);
            // 
            // frmTrackedDailies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 257);
            this.Controls.Add(this.btnDailyCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfDailies);
            this.Name = "frmTrackedDailies";
            this.Text = "Daily Tracker";
            this.Load += new System.EventHandler(this.frmTrackedDailies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfDailies;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDailyCheck;
    }
}