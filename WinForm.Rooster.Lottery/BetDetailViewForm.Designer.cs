namespace WinForm.Rooster.Lottery
{
    partial class BetDetailViewForm
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
            this.dtg_BetDetail = new System.Windows.Forms.DataGridView();
            this.btn_ViewLottery = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BetDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_BetDetail
            // 
            this.dtg_BetDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BetDetail.Location = new System.Drawing.Point(60, 52);
            this.dtg_BetDetail.Name = "dtg_BetDetail";
            this.dtg_BetDetail.Size = new System.Drawing.Size(408, 238);
            this.dtg_BetDetail.TabIndex = 0;
            // 
            // btn_ViewLottery
            // 
            this.btn_ViewLottery.Location = new System.Drawing.Point(393, 296);
            this.btn_ViewLottery.Name = "btn_ViewLottery";
            this.btn_ViewLottery.Size = new System.Drawing.Size(75, 23);
            this.btn_ViewLottery.TabIndex = 1;
            this.btn_ViewLottery.Text = "View Lottery";
            this.btn_ViewLottery.UseVisualStyleBackColor = true;
            this.btn_ViewLottery.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Draw Lottery";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Draw Lottery History";
            // 
            // BetDetailViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ViewLottery);
            this.Controls.Add(this.dtg_BetDetail);
            this.Name = "BetDetailViewForm";
            this.Text = "BetDetailViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BetDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_BetDetail;
        private System.Windows.Forms.Button btn_ViewLottery;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}