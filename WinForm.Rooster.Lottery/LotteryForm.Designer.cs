namespace WinForm.Rooster.Lottery
{
    partial class LotteryForm
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
            this.lb_time = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_LotteryView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_LotteryView)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lb_time.Location = new System.Drawing.Point(6, 9);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(199, 36);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "Lottery Result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check Lottery Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtg_LotteryView
            // 
            this.dtg_LotteryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_LotteryView.Location = new System.Drawing.Point(12, 64);
            this.dtg_LotteryView.Name = "dtg_LotteryView";
            this.dtg_LotteryView.Size = new System.Drawing.Size(240, 77);
            this.dtg_LotteryView.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back to Lottery History";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LotteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 170);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtg_LotteryView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_time);
            this.Name = "LotteryForm";
            this.Text = "LotteryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_LotteryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_LotteryView;
        private System.Windows.Forms.Button button2;
    }
}