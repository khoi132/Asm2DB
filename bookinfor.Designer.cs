namespace Asm2DB
{
    partial class bookinfor
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
            this.lbbid = new System.Windows.Forms.Label();
            this.lbbname = new System.Windows.Forms.Label();
            this.lbbtopic = new System.Windows.Forms.Label();
            this.lbbauthor = new System.Windows.Forms.Label();
            this.lbbdes = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Topic: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Author: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description: ";
            // 
            // lbbid
            // 
            this.lbbid.AutoSize = true;
            this.lbbid.Location = new System.Drawing.Point(265, 97);
            this.lbbid.Name = "lbbid";
            this.lbbid.Size = new System.Drawing.Size(27, 17);
            this.lbbid.TabIndex = 0;
            this.lbbid.Text = "bid";
            // 
            // lbbname
            // 
            this.lbbname.AutoSize = true;
            this.lbbname.Location = new System.Drawing.Point(265, 138);
            this.lbbname.Name = "lbbname";
            this.lbbname.Size = new System.Drawing.Size(51, 17);
            this.lbbname.TabIndex = 0;
            this.lbbname.Text = "bname";
            this.lbbname.Click += new System.EventHandler(this.lbbname_Click);
            // 
            // lbbtopic
            // 
            this.lbbtopic.AutoSize = true;
            this.lbbtopic.Location = new System.Drawing.Point(265, 182);
            this.lbbtopic.Name = "lbbtopic";
            this.lbbtopic.Size = new System.Drawing.Size(46, 17);
            this.lbbtopic.TabIndex = 0;
            this.lbbtopic.Text = "btopic";
            // 
            // lbbauthor
            // 
            this.lbbauthor.AutoSize = true;
            this.lbbauthor.Location = new System.Drawing.Point(265, 228);
            this.lbbauthor.Name = "lbbauthor";
            this.lbbauthor.Size = new System.Drawing.Size(57, 17);
            this.lbbauthor.TabIndex = 0;
            this.lbbauthor.Text = "bauthor";
            // 
            // lbbdes
            // 
            this.lbbdes.AutoSize = true;
            this.lbbdes.Location = new System.Drawing.Point(265, 274);
            this.lbbdes.Name = "lbbdes";
            this.lbbdes.Size = new System.Drawing.Size(39, 17);
            this.lbbdes.TabIndex = 0;
            this.lbbdes.Text = "bdes";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(94, 366);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 53);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "&Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(237, 366);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 53);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "&Add to tag";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Book Information";
            // 
            // bookinfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lbbdes);
            this.Controls.Add(this.lbbauthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbbtopic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbbid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bookinfor";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.bookinfor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbbid;
        private System.Windows.Forms.Label lbbname;
        private System.Windows.Forms.Label lbbtopic;
        private System.Windows.Forms.Label lbbauthor;
        private System.Windows.Forms.Label lbbdes;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label6;
    }
}