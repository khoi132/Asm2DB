namespace Asm2DB
{
    partial class register1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtuemail = new System.Windows.Forms.TextBox();
            this.txtuphone = new System.Windows.Forms.TextBox();
            this.txtupass = new System.Windows.Forms.TextBox();
            this.txtconfpass = new System.Windows.Forms.TextBox();
            this.rdrobot1 = new System.Windows.Forms.RadioButton();
            this.rdrobot2 = new System.Windows.Forms.RadioButton();
            this.btnback = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.lbcheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "User email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "User phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Not a robot?";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(227, 90);
            this.txtuname.MaxLength = 20;
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(228, 23);
            this.txtuname.TabIndex = 2;
            this.txtuname.Leave += new System.EventHandler(this.txtuname_Leave);
            // 
            // txtuemail
            // 
            this.txtuemail.Location = new System.Drawing.Point(227, 126);
            this.txtuemail.MaxLength = 50;
            this.txtuemail.Name = "txtuemail";
            this.txtuemail.Size = new System.Drawing.Size(228, 23);
            this.txtuemail.TabIndex = 3;
            // 
            // txtuphone
            // 
            this.txtuphone.Location = new System.Drawing.Point(227, 162);
            this.txtuphone.MaxLength = 20;
            this.txtuphone.Name = "txtuphone";
            this.txtuphone.Size = new System.Drawing.Size(228, 23);
            this.txtuphone.TabIndex = 4;
            // 
            // txtupass
            // 
            this.txtupass.Location = new System.Drawing.Point(227, 198);
            this.txtupass.MaxLength = 20;
            this.txtupass.Name = "txtupass";
            this.txtupass.PasswordChar = '*';
            this.txtupass.Size = new System.Drawing.Size(228, 23);
            this.txtupass.TabIndex = 5;
            // 
            // txtconfpass
            // 
            this.txtconfpass.Location = new System.Drawing.Point(227, 234);
            this.txtconfpass.MaxLength = 20;
            this.txtconfpass.Name = "txtconfpass";
            this.txtconfpass.PasswordChar = '*';
            this.txtconfpass.Size = new System.Drawing.Size(228, 23);
            this.txtconfpass.TabIndex = 6;
            this.txtconfpass.Leave += new System.EventHandler(this.txtconfpass_Leave);
            // 
            // rdrobot1
            // 
            this.rdrobot1.AutoSize = true;
            this.rdrobot1.Location = new System.Drawing.Point(227, 296);
            this.rdrobot1.Name = "rdrobot1";
            this.rdrobot1.Size = new System.Drawing.Size(50, 21);
            this.rdrobot1.TabIndex = 8;
            this.rdrobot1.Text = "Yes";
            this.rdrobot1.UseVisualStyleBackColor = true;
            // 
            // rdrobot2
            // 
            this.rdrobot2.AutoSize = true;
            this.rdrobot2.Checked = true;
            this.rdrobot2.Location = new System.Drawing.Point(326, 296);
            this.rdrobot2.Name = "rdrobot2";
            this.rdrobot2.Size = new System.Drawing.Size(44, 21);
            this.rdrobot2.TabIndex = 7;
            this.rdrobot2.TabStop = true;
            this.rdrobot2.Text = "No";
            this.rdrobot2.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(257, 342);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(87, 39);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "&Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(368, 342);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(87, 39);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "&OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student ID";
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(227, 54);
            this.txtuid.MaxLength = 7;
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(228, 23);
            this.txtuid.TabIndex = 1;
            this.txtuid.Leave += new System.EventHandler(this.txtuid_Leave);
            // 
            // lbcheck
            // 
            this.lbcheck.AutoSize = true;
            this.lbcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcheck.ForeColor = System.Drawing.Color.Red;
            this.lbcheck.Location = new System.Drawing.Point(253, 267);
            this.lbcheck.Name = "lbcheck";
            this.lbcheck.Size = new System.Drawing.Size(0, 13);
            this.lbcheck.TabIndex = 0;
            // 
            // register1
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(512, 412);
            this.Controls.Add(this.lbcheck);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.rdrobot2);
            this.Controls.Add(this.rdrobot1);
            this.Controls.Add(this.txtconfpass);
            this.Controls.Add(this.txtupass);
            this.Controls.Add(this.txtuphone);
            this.Controls.Add(this.txtuemail);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "register1";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.register1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtuemail;
        private System.Windows.Forms.TextBox txtuphone;
        private System.Windows.Forms.TextBox txtupass;
        private System.Windows.Forms.TextBox txtconfpass;
        private System.Windows.Forms.RadioButton rdrobot1;
        private System.Windows.Forms.RadioButton rdrobot2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.Label lbcheck;
    }
}