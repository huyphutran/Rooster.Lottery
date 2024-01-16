namespace WinForm.Rooster.Lottery
{
    partial class BetForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtpBettingTime = new System.Windows.Forms.DateTimePicker();
            this.cbSelectedNumber = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Lottery";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpBettingTime
            // 
            this.dtpBettingTime.Location = new System.Drawing.Point(131, 169);
            this.dtpBettingTime.Name = "dtpBettingTime";
            this.dtpBettingTime.Size = new System.Drawing.Size(213, 20);
            this.dtpBettingTime.TabIndex = 1;
            this.dtpBettingTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbSelectedNumber
            // 
            this.cbSelectedNumber.FormattingEnabled = true;
            this.cbSelectedNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbSelectedNumber.Location = new System.Drawing.Point(131, 107);
            this.cbSelectedNumber.Name = "cbSelectedNumber";
            this.cbSelectedNumber.Size = new System.Drawing.Size(213, 21);
            this.cbSelectedNumber.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lottery History";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lottery Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Drawing Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(125, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Draw Lottery";
            // 
            // BetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbSelectedNumber);
            this.Controls.Add(this.dtpBettingTime);
            this.Controls.Add(this.button1);
            this.Name = "BetForm";
            this.Text = "BetForm";
            this.Load += new System.EventHandler(this.BetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpBettingTime;
        private System.Windows.Forms.ComboBox cbSelectedNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}