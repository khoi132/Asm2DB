namespace Asm2DB
{
    partial class guestinterf
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.txttopic = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbregister = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblogin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvbookinf = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(884, 195);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(116, 42);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // txttopic
            // 
            this.txttopic.Location = new System.Drawing.Point(816, 155);
            this.txttopic.Name = "txttopic";
            this.txttopic.Size = new System.Drawing.Size(184, 23);
            this.txttopic.TabIndex = 3;
            this.txttopic.TextChanged += new System.EventHandler(this.txttopic_TextChanged);
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(816, 117);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(184, 23);
            this.txtauthor.TabIndex = 2;
            this.txtauthor.TextChanged += new System.EventHandler(this.txtauthor_TextChanged);
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(816, 77);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(184, 23);
            this.txtbname.TabIndex = 1;
            this.txtbname.TextChanged += new System.EventHandler(this.txtbname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Topic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Book name";
            // 
            // lbregister
            // 
            this.lbregister.AutoSize = true;
            this.lbregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbregister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbregister.Location = new System.Drawing.Point(285, 124);
            this.lbregister.Name = "lbregister";
            this.lbregister.Size = new System.Drawing.Size(61, 17);
            this.lbregister.TabIndex = 5;
            this.lbregister.Text = "Register";
            this.lbregister.Click += new System.EventHandler(this.lbregister_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "or";
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblogin.Location = new System.Drawing.Point(184, 124);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(43, 17);
            this.lblogin.TabIndex = 4;
            this.lblogin.Text = "Login";
            this.lblogin.Click += new System.EventHandler(this.lblogin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Please";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "If you want to borrow book";
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
            this.dgvbookinf.Location = new System.Drawing.Point(66, 249);
            this.dgvbookinf.MultiSelect = false;
            this.dgvbookinf.Name = "dgvbookinf";
            this.dgvbookinf.ReadOnly = true;
            this.dgvbookinf.RowHeadersWidth = 62;
            this.dgvbookinf.RowTemplate.Height = 28;
            this.dgvbookinf.Size = new System.Drawing.Size(934, 208);
            this.dgvbookinf.TabIndex = 25;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Welcome to the BTEC library";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(877, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Search";
            // 
            // guestinterf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 481);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvbookinf);
            this.Controls.Add(this.lbregister);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.txttopic);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "guestinterf";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.guestinterf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.TextBox txttopic;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbregister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvbookinf;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}