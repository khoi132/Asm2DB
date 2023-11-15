namespace Asm2DB
{
    partial class edittopicauthor
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
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.lbid = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbvalueid = new System.Windows.Forms.Label();
            this.lbvaluename = new System.Windows.Forms.Label();
            this.txteditname = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(46, 237);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(88, 45);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(173, 237);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(88, 45);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(46, 297);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(88, 45);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(78, 64);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(51, 17);
            this.lbid.TabIndex = 1;
            this.lbid.Text = "tp/auid";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(44, 110);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(75, 17);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "tp/auname";
            // 
            // lbvalueid
            // 
            this.lbvalueid.AutoSize = true;
            this.lbvalueid.Location = new System.Drawing.Point(168, 64);
            this.lbvalueid.Name = "lbvalueid";
            this.lbvalueid.Size = new System.Drawing.Size(46, 17);
            this.lbvalueid.TabIndex = 1;
            this.lbvalueid.Text = "label1";
            // 
            // lbvaluename
            // 
            this.lbvaluename.AutoSize = true;
            this.lbvaluename.Location = new System.Drawing.Point(168, 110);
            this.lbvaluename.Name = "lbvaluename";
            this.lbvaluename.Size = new System.Drawing.Size(46, 17);
            this.lbvaluename.TabIndex = 1;
            this.lbvaluename.Text = "label1";
            // 
            // txteditname
            // 
            this.txteditname.Location = new System.Drawing.Point(264, 109);
            this.txteditname.MaxLength = 20;
            this.txteditname.Name = "txteditname";
            this.txteditname.Size = new System.Drawing.Size(152, 23);
            this.txteditname.TabIndex = 3;
            this.txteditname.Visible = false;
            this.txteditname.TextChanged += new System.EventHandler(this.txteditname_TextChanged);
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(264, 145);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(85, 37);
            this.btncal.TabIndex = 5;
            this.btncal.Text = "Cancel";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Visible = false;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(355, 145);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(61, 37);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Visible = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // edittopicauthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 369);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txteditname);
            this.Controls.Add(this.lbvaluename);
            this.Controls.Add(this.lbvalueid);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "edittopicauthor";
            this.Text = "edittopicauthor";
            this.Load += new System.EventHandler(this.edittopicauthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbvalueid;
        private System.Windows.Forms.Label lbvaluename;
        private System.Windows.Forms.TextBox txteditname;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btnok;
    }
}