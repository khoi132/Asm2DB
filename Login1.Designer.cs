namespace Asm2DB
{
    partial class Login1
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
            this.btnguest = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btnstaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnguest
            // 
            this.btnguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguest.Location = new System.Drawing.Point(622, 275);
            this.btnguest.Name = "btnguest";
            this.btnguest.Size = new System.Drawing.Size(134, 83);
            this.btnguest.TabIndex = 2;
            this.btnguest.Text = "&Guest";
            this.btnguest.UseVisualStyleBackColor = true;
            this.btnguest.Click += new System.EventHandler(this.btnguest_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.Location = new System.Drawing.Point(364, 275);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(134, 83);
            this.btnstudent.TabIndex = 1;
            this.btnstudent.Text = "&Student";
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaff.Location = new System.Drawing.Point(108, 275);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(134, 83);
            this.btnstaff.TabIndex = 0;
            this.btnstaff.Text = "&Library staff";
            this.btnstaff.UseVisualStyleBackColor = true;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is your role?";
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Location = new System.Drawing.Point(796, 450);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(97, 37);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(905, 499);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstaff);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.btnguest);
            this.Name = "Login1";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.Login1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguest;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
    }
}

