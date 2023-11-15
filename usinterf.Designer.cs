namespace Asm2DB
{
    partial class usinterf
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txttopic = new System.Windows.Forms.TextBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.dgvbookinf = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbuid = new System.Windows.Forms.Label();
            this.lbuname = new System.Windows.Forms.Label();
            this.btncurrtag = new System.Windows.Forms.Button();
            this.btnmoreinf = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinf)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "UserID: ";
            this.label7.Click += new System.EventHandler(this.userid_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "UserName: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "BookName: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TopicName: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "AuthorName: ";
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(785, 46);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(184, 30);
            this.txtbname.TabIndex = 1;
            this.txtbname.TextChanged += new System.EventHandler(this.txtbname_TextChanged);
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(785, 86);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(184, 30);
            this.txtauthor.TabIndex = 2;
            this.txtauthor.TextChanged += new System.EventHandler(this.txtauthor_TextChanged);
            // 
            // txttopic
            // 
            this.txttopic.Location = new System.Drawing.Point(785, 124);
            this.txttopic.Name = "txttopic";
            this.txttopic.Size = new System.Drawing.Size(184, 30);
            this.txttopic.TabIndex = 3;
            this.txttopic.TextChanged += new System.EventHandler(this.txttopic_TextChanged);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(853, 198);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(116, 42);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
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
            this.dgvbookinf.Location = new System.Drawing.Point(65, 265);
            this.dgvbookinf.MultiSelect = false;
            this.dgvbookinf.Name = "dgvbookinf";
            this.dgvbookinf.ReadOnly = true;
            this.dgvbookinf.RowHeadersWidth = 62;
            this.dgvbookinf.RowTemplate.Height = 28;
            this.dgvbookinf.Size = new System.Drawing.Size(934, 208);
            this.dgvbookinf.TabIndex = 5;
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
            // lbuid
            // 
            this.lbuid.AutoSize = true;
            this.lbuid.Location = new System.Drawing.Point(293, 51);
            this.lbuid.Name = "lbuid";
            this.lbuid.Size = new System.Drawing.Size(64, 25);
            this.lbuid.TabIndex = 6;
            this.lbuid.Text = "Guest";
            // 
            // lbuname
            // 
            this.lbuname.AutoSize = true;
            this.lbuname.Location = new System.Drawing.Point(293, 86);
            this.lbuname.Name = "lbuname";
            this.lbuname.Size = new System.Drawing.Size(64, 25);
            this.lbuname.TabIndex = 6;
            this.lbuname.Text = "Guest";
            // 
            // btncurrtag
            // 
            this.btncurrtag.Location = new System.Drawing.Point(187, 201);
            this.btncurrtag.Name = "btncurrtag";
            this.btncurrtag.Size = new System.Drawing.Size(156, 49);
            this.btncurrtag.TabIndex = 5;
            this.btncurrtag.Text = "Current tag";
            this.btncurrtag.UseVisualStyleBackColor = true;
            this.btncurrtag.Click += new System.EventHandler(this.btncurrtag_Click_1);
            // 
            // btnmoreinf
            // 
            this.btnmoreinf.Location = new System.Drawing.Point(187, 134);
            this.btnmoreinf.Name = "btnmoreinf";
            this.btnmoreinf.Size = new System.Drawing.Size(199, 47);
            this.btnmoreinf.TabIndex = 4;
            this.btnmoreinf.Text = "More information";
            this.btnmoreinf.UseVisualStyleBackColor = true;
            this.btnmoreinf.Click += new System.EventHandler(this.btnmoreinf_Click_1);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(698, 205);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(93, 45);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // usinterf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 485);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btncurrtag);
            this.Controls.Add(this.btnmoreinf);
            this.Controls.Add(this.lbuname);
            this.Controls.Add(this.lbuid);
            this.Controls.Add(this.dgvbookinf);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.txttopic);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usinterf";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.usinterf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txttopic;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.DataGridView dgvbookinf;
        private System.Windows.Forms.Label lbuid;
        private System.Windows.Forms.Label lbuname;
        private System.Windows.Forms.Button btncurrtag;
        private System.Windows.Forms.Button btnmoreinf;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptions;
        private System.Windows.Forms.Button btnrefresh;
    }
}