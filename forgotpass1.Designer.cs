namespace Asm2DB
{
    partial class forgotpass1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtuemail = new System.Windows.Forms.TextBox();
            this.txtuphone = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "User email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "User phone";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(209, 67);
            this.txtuname.MaxLength = 20;
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(236, 23);
            this.txtuname.TabIndex = 1;
            // 
            // txtuemail
            // 
            this.txtuemail.Location = new System.Drawing.Point(209, 113);
            this.txtuemail.MaxLength = 50;
            this.txtuemail.Name = "txtuemail";
            this.txtuemail.Size = new System.Drawing.Size(236, 23);
            this.txtuemail.TabIndex = 2;
            this.txtuemail.TextChanged += new System.EventHandler(this.txtuemail_TextChanged);
            // 
            // txtuphone
            // 
            this.txtuphone.Location = new System.Drawing.Point(209, 160);
            this.txtuphone.MaxLength = 20;
            this.txtuphone.Name = "txtuphone";
            this.txtuphone.Size = new System.Drawing.Size(236, 23);
            this.txtuphone.TabIndex = 3;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(504, 231);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(87, 34);
            this.btnnext.TabIndex = 5;
            this.btnnext.Text = "&Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(386, 231);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(87, 34);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "&Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forgot Password";
            // 
            // forgotpass1
            // 
            this.AcceptButton = this.btnnext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(612, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txtuphone);
            this.Controls.Add(this.txtuemail);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "forgotpass1";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.forgotpass1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtuemail;
        private System.Windows.Forms.TextBox txtuphone;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label4;
    }
}