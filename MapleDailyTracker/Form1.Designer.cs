namespace MapleDailyTracker
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxBoss = new System.Windows.Forms.CheckBox();
            this.checkBoxPQ = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxQuests = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxQuests);
            this.groupBox1.Controls.Add(this.checkBoxBoss);
            this.groupBox1.Controls.Add(this.checkBoxPQ);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What kind of Dailies are you tracking?";
            // 
            // checkBoxBoss
            // 
            this.checkBoxBoss.AutoSize = true;
            this.checkBoxBoss.Location = new System.Drawing.Point(87, 45);
            this.checkBoxBoss.Name = "checkBoxBoss";
            this.checkBoxBoss.Size = new System.Drawing.Size(60, 17);
            this.checkBoxBoss.TabIndex = 1;
            this.checkBoxBoss.Text = "Bosses";
            this.checkBoxBoss.UseVisualStyleBackColor = true;
            // 
            // checkBoxPQ
            // 
            this.checkBoxPQ.AutoSize = true;
            this.checkBoxPQ.Location = new System.Drawing.Point(23, 45);
            this.checkBoxPQ.Name = "checkBoxPQ";
            this.checkBoxPQ.Size = new System.Drawing.Size(41, 17);
            this.checkBoxPQ.TabIndex = 0;
            this.checkBoxPQ.Text = "PQ";
            this.checkBoxPQ.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(99, 135);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(203, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxQuests
            // 
            this.checkBoxQuests.AutoSize = true;
            this.checkBoxQuests.Location = new System.Drawing.Point(166, 45);
            this.checkBoxQuests.Name = "checkBoxQuests";
            this.checkBoxQuests.Size = new System.Drawing.Size(59, 17);
            this.checkBoxQuests.TabIndex = 2;
            this.checkBoxQuests.Text = "Quests";
            this.checkBoxQuests.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Maple Daily Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxBoss;
        private System.Windows.Forms.CheckBox checkBoxPQ;
        private System.Windows.Forms.CheckBox checkBoxQuests;
    }
}

