namespace Asm2DB
{
    partial class forgotpass2
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
            this.btnok = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconfpass = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.lbcheckpass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(518, 193);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(99, 44);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "&OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(399, 193);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(93, 44);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "&Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Confirm Password";
            // 
            // txtconfpass
            // 
            this.txtconfpass.Location = new System.Drawing.Point(247, 114);
            this.txtconfpass.MaxLength = 20;
            this.txtconfpass.Name = "txtconfpass";
            this.txtconfpass.PasswordChar = '*';
            this.txtconfpass.Size = new System.Drawing.Size(245, 23);
            this.txtconfpass.TabIndex = 2;
            this.txtconfpass.TextChanged += new System.EventHandler(this.txtconfpass_TextChanged);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(247, 60);
            this.txtnewpass.MaxLength = 20;
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '*';
            this.txtnewpass.Size = new System.Drawing.Size(245, 23);
            this.txtnewpass.TabIndex = 1;
            this.txtnewpass.Leave += new System.EventHandler(this.txtnewpass_Leave);
            // 
            // lbcheckpass
            // 
            this.lbcheckpass.AutoSize = true;
            this.lbcheckpass.Location = new System.Drawing.Point(513, 117);
            this.lbcheckpass.Name = "lbcheckpass";
            this.lbcheckpass.Size = new System.Drawing.Size(20, 17);
            this.lbcheckpass.TabIndex = 7;
            this.lbcheckpass.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "New Password";
            // 
            // forgotpass2
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(654, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbcheckpass);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtconfpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "forgotpass2";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.forgotpass2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconfpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Label lbcheckpass;
        private System.Windows.Forms.Label label1;
    }
}