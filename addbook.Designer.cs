namespace Asm2DB
{
    partial class addbook
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
            this.txtbid = new System.Windows.Forms.TextBox();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.txttopicid = new System.Windows.Forms.TextBox();
            this.txtauthorname = new System.Windows.Forms.TextBox();
            this.txtbdes = new System.Windows.Forms.TextBox();
            this.btnbacktopic = new System.Windows.Forms.Button();
            this.btnaddb = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txttopicname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtauthorid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbtopicid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbauthorid = new System.Windows.Forms.TextBox();
            this.lbaddtopic = new System.Windows.Forms.Label();
            this.lbaddauthor = new System.Windows.Forms.Label();
            this.dgvtopic = new System.Windows.Forms.DataGridView();
            this.TopicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvauthor = new System.Windows.Forms.DataGridView();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddauthor = new System.Windows.Forms.Button();
            this.btnaddtopic = new System.Windows.Forms.Button();
            this.btnbackauthor = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnrefreshtp = new System.Windows.Forms.Button();
            this.btnrefreshau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauthor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "TopicID: ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "AuthorName: ";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description: ";
            // 
            // txtbid
            // 
            this.txtbid.Location = new System.Drawing.Point(154, 41);
            this.txtbid.MaxLength = 7;
            this.txtbid.Name = "txtbid";
            this.txtbid.Size = new System.Drawing.Size(175, 23);
            this.txtbid.TabIndex = 1;
            this.txtbid.Leave += new System.EventHandler(this.txtbid_Leave);
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(154, 78);
            this.txtbname.MaxLength = 40;
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(175, 23);
            this.txtbname.TabIndex = 2;
            this.txtbname.Leave += new System.EventHandler(this.txtbname_Leave);
            // 
            // txttopicid
            // 
            this.txttopicid.Location = new System.Drawing.Point(515, 78);
            this.txttopicid.MaxLength = 7;
            this.txttopicid.Name = "txttopicid";
            this.txttopicid.Size = new System.Drawing.Size(175, 23);
            this.txttopicid.TabIndex = 9;
            this.txttopicid.Visible = false;
            this.txttopicid.TextChanged += new System.EventHandler(this.txttopicid_TextChanged);
            this.txttopicid.Leave += new System.EventHandler(this.txttopicid_Leave);
            // 
            // txtauthorname
            // 
            this.txtauthorname.Location = new System.Drawing.Point(847, 114);
            this.txtauthorname.MaxLength = 20;
            this.txtauthorname.Name = "txtauthorname";
            this.txtauthorname.Size = new System.Drawing.Size(175, 23);
            this.txtauthorname.TabIndex = 14;
            this.txtauthorname.Visible = false;
            this.txtauthorname.Leave += new System.EventHandler(this.txtauthorname_Leave);
            // 
            // txtbdes
            // 
            this.txtbdes.Location = new System.Drawing.Point(154, 186);
            this.txtbdes.MaxLength = 100;
            this.txtbdes.Name = "txtbdes";
            this.txtbdes.Size = new System.Drawing.Size(175, 23);
            this.txtbdes.TabIndex = 5;
            // 
            // btnbacktopic
            // 
            this.btnbacktopic.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnbacktopic.Location = new System.Drawing.Point(527, 150);
            this.btnbacktopic.Name = "btnbacktopic";
            this.btnbacktopic.Size = new System.Drawing.Size(79, 37);
            this.btnbacktopic.TabIndex = 12;
            this.btnbacktopic.Text = "Back";
            this.btnbacktopic.UseVisualStyleBackColor = true;
            this.btnbacktopic.Visible = false;
            this.btnbacktopic.Click += new System.EventHandler(this.btnbacktopic_Click);
            // 
            // btnaddb
            // 
            this.btnaddb.Location = new System.Drawing.Point(227, 241);
            this.btnaddb.Name = "btnaddb";
            this.btnaddb.Size = new System.Drawing.Size(102, 43);
            this.btnaddb.TabIndex = 6;
            this.btnaddb.Text = "Add";
            this.btnaddb.UseVisualStyleBackColor = true;
            this.btnaddb.Click += new System.EventHandler(this.btnaddb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "TopicName: ";
            this.label6.Visible = false;
            // 
            // txttopicname
            // 
            this.txttopicname.Location = new System.Drawing.Point(515, 114);
            this.txttopicname.MaxLength = 20;
            this.txttopicname.Name = "txttopicname";
            this.txttopicname.Size = new System.Drawing.Size(175, 23);
            this.txttopicname.TabIndex = 10;
            this.txttopicname.Visible = false;
            this.txttopicname.Leave += new System.EventHandler(this.txttopicname_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(741, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "AuthorID: ";
            this.label7.Visible = false;
            // 
            // txtauthorid
            // 
            this.txtauthorid.Location = new System.Drawing.Point(847, 78);
            this.txtauthorid.MaxLength = 7;
            this.txtauthorid.Name = "txtauthorid";
            this.txtauthorid.Size = new System.Drawing.Size(175, 23);
            this.txtauthorid.TabIndex = 13;
            this.txtauthorid.Visible = false;
            this.txtauthorid.TextChanged += new System.EventHandler(this.txtauthorid_TextChanged);
            this.txtauthorid.Leave += new System.EventHandler(this.txtauthorid_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "TopicID: ";
            // 
            // txtbtopicid
            // 
            this.txtbtopicid.Location = new System.Drawing.Point(154, 114);
            this.txtbtopicid.MaxLength = 7;
            this.txtbtopicid.Name = "txtbtopicid";
            this.txtbtopicid.Size = new System.Drawing.Size(175, 23);
            this.txtbtopicid.TabIndex = 3;
            this.txtbtopicid.Leave += new System.EventHandler(this.txtbtopicid_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "AuthorID: ";
            // 
            // txtbauthorid
            // 
            this.txtbauthorid.Location = new System.Drawing.Point(154, 150);
            this.txtbauthorid.MaxLength = 7;
            this.txtbauthorid.Name = "txtbauthorid";
            this.txtbauthorid.Size = new System.Drawing.Size(175, 23);
            this.txtbauthorid.TabIndex = 4;
            this.txtbauthorid.Leave += new System.EventHandler(this.txtbauthorid_Leave);
            // 
            // lbaddtopic
            // 
            this.lbaddtopic.AutoSize = true;
            this.lbaddtopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbaddtopic.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbaddtopic.Location = new System.Drawing.Point(510, 41);
            this.lbaddtopic.Name = "lbaddtopic";
            this.lbaddtopic.Size = new System.Drawing.Size(72, 17);
            this.lbaddtopic.TabIndex = 7;
            this.lbaddtopic.Text = "Add Topic";
            this.lbaddtopic.Click += new System.EventHandler(this.lbaddtopic_Click);
            // 
            // lbaddauthor
            // 
            this.lbaddauthor.AutoSize = true;
            this.lbaddauthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbaddauthor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbaddauthor.Location = new System.Drawing.Point(842, 41);
            this.lbaddauthor.Name = "lbaddauthor";
            this.lbaddauthor.Size = new System.Drawing.Size(79, 17);
            this.lbaddauthor.TabIndex = 8;
            this.lbaddauthor.Text = "Add Author";
            this.lbaddauthor.Click += new System.EventHandler(this.lbaddauthor_Click);
            // 
            // dgvtopic
            // 
            this.dgvtopic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtopic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TopicID,
            this.TopicName});
            this.dgvtopic.Location = new System.Drawing.Point(423, 194);
            this.dgvtopic.Name = "dgvtopic";
            this.dgvtopic.ReadOnly = true;
            this.dgvtopic.RowHeadersWidth = 62;
            this.dgvtopic.RowTemplate.Height = 28;
            this.dgvtopic.Size = new System.Drawing.Size(266, 156);
            this.dgvtopic.TabIndex = 4;
            this.dgvtopic.Visible = false;
            this.dgvtopic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtopic_CellClick);
            // 
            // TopicID
            // 
            this.TopicID.DataPropertyName = "TopicID";
            this.TopicID.HeaderText = "TopicID";
            this.TopicID.MinimumWidth = 8;
            this.TopicID.Name = "TopicID";
            this.TopicID.ReadOnly = true;
            // 
            // TopicName
            // 
            this.TopicName.DataPropertyName = "TopicName";
            this.TopicName.HeaderText = "TopicName";
            this.TopicName.MinimumWidth = 8;
            this.TopicName.Name = "TopicName";
            this.TopicName.ReadOnly = true;
            // 
            // dgvauthor
            // 
            this.dgvauthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvauthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvauthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorID,
            this.AuthorName});
            this.dgvauthor.Location = new System.Drawing.Point(746, 194);
            this.dgvauthor.Name = "dgvauthor";
            this.dgvauthor.ReadOnly = true;
            this.dgvauthor.RowHeadersWidth = 62;
            this.dgvauthor.RowTemplate.Height = 28;
            this.dgvauthor.Size = new System.Drawing.Size(276, 156);
            this.dgvauthor.TabIndex = 4;
            this.dgvauthor.Visible = false;
            this.dgvauthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvauthor_CellClick);
            // 
            // AuthorID
            // 
            this.AuthorID.DataPropertyName = "AuthorID";
            this.AuthorID.HeaderText = "AuthorID";
            this.AuthorID.MinimumWidth = 8;
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "AuthorName";
            this.AuthorName.MinimumWidth = 8;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // btnaddauthor
            // 
            this.btnaddauthor.Location = new System.Drawing.Point(944, 150);
            this.btnaddauthor.Name = "btnaddauthor";
            this.btnaddauthor.Size = new System.Drawing.Size(78, 38);
            this.btnaddauthor.TabIndex = 15;
            this.btnaddauthor.Text = "Add";
            this.btnaddauthor.UseVisualStyleBackColor = true;
            this.btnaddauthor.Visible = false;
            this.btnaddauthor.Click += new System.EventHandler(this.btnaddauthor_Click);
            // 
            // btnaddtopic
            // 
            this.btnaddtopic.Location = new System.Drawing.Point(612, 150);
            this.btnaddtopic.Name = "btnaddtopic";
            this.btnaddtopic.Size = new System.Drawing.Size(78, 38);
            this.btnaddtopic.TabIndex = 11;
            this.btnaddtopic.Text = "Add";
            this.btnaddtopic.UseVisualStyleBackColor = true;
            this.btnaddtopic.Visible = false;
            this.btnaddtopic.Click += new System.EventHandler(this.btnaddtopic_Click);
            // 
            // btnbackauthor
            // 
            this.btnbackauthor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnbackauthor.Location = new System.Drawing.Point(847, 150);
            this.btnbackauthor.Name = "btnbackauthor";
            this.btnbackauthor.Size = new System.Drawing.Size(91, 38);
            this.btnbackauthor.TabIndex = 16;
            this.btnbackauthor.Text = "Back";
            this.btnbackauthor.UseVisualStyleBackColor = true;
            this.btnbackauthor.Visible = false;
            this.btnbackauthor.Click += new System.EventHandler(this.btnbackauthor_Click);
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(92, 241);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(104, 43);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnrefreshtp
            // 
            this.btnrefreshtp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnrefreshtp.Location = new System.Drawing.Point(423, 150);
            this.btnrefreshtp.Name = "btnrefreshtp";
            this.btnrefreshtp.Size = new System.Drawing.Size(98, 37);
            this.btnrefreshtp.TabIndex = 12;
            this.btnrefreshtp.Text = "Refresh";
            this.btnrefreshtp.UseVisualStyleBackColor = true;
            this.btnrefreshtp.Visible = false;
            this.btnrefreshtp.Click += new System.EventHandler(this.btnrefreshtp_Click);
            // 
            // btnrefreshau
            // 
            this.btnrefreshau.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnrefreshau.Location = new System.Drawing.Point(746, 151);
            this.btnrefreshau.Name = "btnrefreshau";
            this.btnrefreshau.Size = new System.Drawing.Size(95, 37);
            this.btnrefreshau.TabIndex = 12;
            this.btnrefreshau.Text = "Refresh";
            this.btnrefreshau.UseVisualStyleBackColor = true;
            this.btnrefreshau.Visible = false;
            this.btnrefreshau.Click += new System.EventHandler(this.btnrefreshau_Click);
            // 
            // addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnbacktopic;
            this.ClientSize = new System.Drawing.Size(1085, 362);
            this.Controls.Add(this.dgvauthor);
            this.Controls.Add(this.dgvtopic);
            this.Controls.Add(this.lbaddauthor);
            this.Controls.Add(this.lbaddtopic);
            this.Controls.Add(this.btnaddtopic);
            this.Controls.Add(this.btnaddauthor);
            this.Controls.Add(this.btnaddb);
            this.Controls.Add(this.btnbackauthor);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnrefreshau);
            this.Controls.Add(this.btnrefreshtp);
            this.Controls.Add(this.btnbacktopic);
            this.Controls.Add(this.txtbdes);
            this.Controls.Add(this.txtbauthorid);
            this.Controls.Add(this.txtauthorid);
            this.Controls.Add(this.txtauthorname);
            this.Controls.Add(this.txttopicname);
            this.Controls.Add(this.txtbtopicid);
            this.Controls.Add(this.txttopicid);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.txtbid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addbook";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.addbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbid;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.TextBox txttopicid;
        private System.Windows.Forms.TextBox txtauthorname;
        private System.Windows.Forms.TextBox txtbdes;
        private System.Windows.Forms.Button btnbacktopic;
        private System.Windows.Forms.Button btnaddb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttopicname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtauthorid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbtopicid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbauthorid;
        private System.Windows.Forms.Label lbaddtopic;
        private System.Windows.Forms.Label lbaddauthor;
        private System.Windows.Forms.DataGridView dgvtopic;
        private System.Windows.Forms.DataGridView dgvauthor;
        private System.Windows.Forms.Button btnaddauthor;
        private System.Windows.Forms.Button btnaddtopic;
        private System.Windows.Forms.Button btnbackauthor;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.Button btnrefreshtp;
        private System.Windows.Forms.Button btnrefreshau;
    }
}