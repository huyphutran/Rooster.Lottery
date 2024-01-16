namespace WinForm.Rooster.Lottery
{
    partial class Resgiter
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // txt_username
            // 
            this.txt_username.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.txt_username.Location = new System.Drawing.Point(142, 87);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(200, 20);
            this.txt_username.TabIndex = 3;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(142, 129);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(200, 20);
            this.txt_phone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Register";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(360, 87);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(142, 170);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(200, 20);
            this.dtp_dob.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name";
            // 
            // Resgiter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Resgiter";
            this.Size = new System.Drawing.Size(466, 217);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Label label1;
    }
}
