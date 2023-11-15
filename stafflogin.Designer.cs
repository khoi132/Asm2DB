namespace Asm2DB
{
    partial class stafflogin
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
            this.txtaccount1 = new System.Windows.Forms.TextBox();
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin\'s login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Account";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtaccount1
            // 
            this.txtaccount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccount1.Location = new System.Drawing.Point(274, 214);
            this.txtaccount1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtaccount1.Name = "txtaccount1";
            this.txtaccount1.Size = new System.Drawing.Size(258, 39);
            this.txtaccount1.TabIndex = 0;
            this.txtaccount1.TextChanged += new System.EventHandler(this.txtaccount1_TextChanged);
            // 
            // txtpassword1
            // 
            this.txtpassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword1.Location = new System.Drawing.Point(274, 261);
            this.txtpassword1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.PasswordChar = '*';
            this.txtpassword1.Size = new System.Drawing.Size(258, 39);
            this.txtpassword1.TabIndex = 1;
            this.txtpassword1.TextChanged += new System.EventHandler(this.txtpassword1_TextChanged);
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(588, 261);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(108, 39);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(588, 214);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(108, 39);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "&Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // stafflogin
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(894, 398);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtpassword1);
            this.Controls.Add(this.txtaccount1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "stafflogin";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.stafflogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaccount1;
        private System.Windows.Forms.TextBox txtpassword1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;
    }
}