namespace Asm2DB
{
    partial class admininterf
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
            this.dgvbookinf = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlogout = new System.Windows.Forms.Button();
            this.txttopic = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntaginu = new System.Windows.Forms.Button();
            this.btntagdated = new System.Windows.Forms.Button();
            this.btnaddb = new System.Windows.Forms.Button();
            this.btnmngacc = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btncurtag = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbookinf
            // 
            this.dgvbookinf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbookinf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbookinf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.TopicName,
            this.AuthorName,
            this.Descriptions});
            this.dgvbookinf.Location = new System.Drawing.Point(73, 245);
            this.dgvbookinf.MultiSelect = false;
            this.dgvbookinf.Name = "dgvbookinf";
            this.dgvbookinf.ReadOnly = true;
            this.dgvbookinf.RowHeadersWidth = 62;
            this.dgvbookinf.RowTemplate.Height = 28;
            this.dgvbookinf.Size = new System.Drawing.Size(934, 208);
            this.dgvbookinf.TabIndex = 17;
            this.dgvbookinf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbookinf_CellClick);
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "BookName";
            this.BookName.MinimumWidth = 8;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // TopicName
            // 
            this.TopicName.DataPropertyName = "TopicName";
            this.TopicName.HeaderText = "TopicName";
            this.TopicName.MinimumWidth = 8;
            this.TopicName.Name = "TopicName";
            this.TopicName.ReadOnly = true;
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "AuthorName";
            this.AuthorName.MinimumWidth = 8;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // Descriptions
            // 
            this.Descriptions.DataPropertyName = "Descriptions";
            this.Descriptions.HeaderText = "Descriptions";
            this.Descriptions.MinimumWidth = 8;
            this.Descriptions.Name = "Descriptions";
            this.Descriptions.ReadOnly = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(882, 180);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(116, 42);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // txttopic
            // 
            this.txttopic.Location = new System.Drawing.Point(814, 106);
            this.txttopic.Name = "txttopic";
            this.txttopic.Size = new System.Drawing.Size(184, 30);
            this.txttopic.TabIndex = 3;
            this.txttopic.TextChanged += new System.EventHandler(this.txttopic_TextChanged);
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(814, 68);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(184, 30);
            this.txtauthor.TabIndex = 2;
            this.txtauthor.TextChanged += new System.EventHandler(this.txtauthor_TextChanged);
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(814, 28);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(184, 30);
            this.txtbname.TabIndex = 1;
            this.txtbname.TextChanged += new System.EventHandler(this.txtbname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "AuthorName: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "TopicName: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "BookName: ";
            // 
            // btntaginu
            // 
            this.btntaginu.Location = new System.Drawing.Point(216, 173);
            this.btntaginu.Name = "btntaginu";
            this.btntaginu.Size = new System.Drawing.Size(156, 49);
            this.btntaginu.TabIndex = 6;
            this.btntaginu.Text = "Tags in use";
            this.btntaginu.UseVisualStyleBackColor = true;
            this.btntaginu.Click += new System.EventHandler(this.btntaginu_Click);
            // 
            // btntagdated
            // 
            this.btntagdated.Location = new System.Drawing.Point(397, 175);
            this.btntagdated.Name = "btntagdated";
            this.btntagdated.Size = new System.Drawing.Size(170, 47);
            this.btntagdated.TabIndex = 7;
            this.btntagdated.Text = "Tags dated";
            this.btntagdated.UseVisualStyleBackColor = true;
            this.btntagdated.Click += new System.EventHandler(this.btntagdated_Click);
            // 
            // btnaddb
            // 
            this.btnaddb.Location = new System.Drawing.Point(64, 175);
            this.btnaddb.Name = "btnaddb";
            this.btnaddb.Size = new System.Drawing.Size(112, 47);
            this.btnaddb.TabIndex = 5;
            this.btnaddb.Text = "Add book";
            this.btnaddb.UseVisualStyleBackColor = true;
            this.btnaddb.Click += new System.EventHandler(this.btnaddb_Click);
            // 
            // btnmngacc
            // 
            this.btnmngacc.Location = new System.Drawing.Point(64, 28);
            this.btnmngacc.Name = "btnmngacc";
            this.btnmngacc.Size = new System.Drawing.Size(178, 70);
            this.btnmngacc.TabIndex = 4;
            this.btnmngacc.Text = "Change to manage account";
            this.btnmngacc.UseVisualStyleBackColor = true;
            this.btnmngacc.Click += new System.EventHandler(this.btnmngacc_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(623, 180);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(110, 41);
            this.btnrefresh.TabIndex = 8;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btncurtag
            // 
            this.btncurtag.Location = new System.Drawing.Point(216, 109);
            this.btncurtag.Name = "btncurtag";
            this.btncurtag.Size = new System.Drawing.Size(156, 48);
            this.btncurtag.TabIndex = 18;
            this.btncurtag.Text = "Current tag";
            this.btncurtag.UseVisualStyleBackColor = true;
            this.btncurtag.Click += new System.EventHandler(this.btncurtag_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total books: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "int";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "int";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total topic";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(767, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "int";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(648, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total author:";
            // 
            // admininterf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 477);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncurtag);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnmngacc);
            this.Controls.Add(this.btnaddb);
            this.Controls.Add(this.dgvbookinf);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.txttopic);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntaginu);
            this.Controls.Add(this.btntagdated);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admininterf";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.admininterf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbookinf;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.TextBox txttopic;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntaginu;
        private System.Windows.Forms.Button btntagdated;
        private System.Windows.Forms.Button btnaddb;
        private System.Windows.Forms.Button btnmngacc;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptions;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btncurtag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}