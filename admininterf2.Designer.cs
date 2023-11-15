namespace Asm2DB
{
    partial class admininterf2
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
            this.btnmngbook = new System.Windows.Forms.Button();
            this.btnaddacc = new System.Windows.Forms.Button();
            this.dgvuserinf = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlogout = new System.Windows.Forms.Button();
            this.txtuphone = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnstaffacc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserinf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmngbook
            // 
            this.btnmngbook.Location = new System.Drawing.Point(66, 21);
            this.btnmngbook.Name = "btnmngbook";
            this.btnmngbook.Size = new System.Drawing.Size(178, 70);
            this.btnmngbook.TabIndex = 4;
            this.btnmngbook.Text = "Change to manage book";
            this.btnmngbook.UseVisualStyleBackColor = true;
            this.btnmngbook.Click += new System.EventHandler(this.btnmngbook_Click);
            // 
            // btnaddacc
            // 
            this.btnaddacc.Location = new System.Drawing.Point(66, 168);
            this.btnaddacc.Name = "btnaddacc";
            this.btnaddacc.Size = new System.Drawing.Size(139, 47);
            this.btnaddacc.TabIndex = 5;
            this.btnaddacc.Text = "Add account";
            this.btnaddacc.UseVisualStyleBackColor = true;
            this.btnaddacc.Click += new System.EventHandler(this.btnaddacc_Click);
            // 
            // dgvuserinf
            // 
            this.dgvuserinf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvuserinf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuserinf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.UserPhone,
            this.UserEmail});
            this.dgvuserinf.Location = new System.Drawing.Point(66, 240);
            this.dgvuserinf.MultiSelect = false;
            this.dgvuserinf.Name = "dgvuserinf";
            this.dgvuserinf.ReadOnly = true;
            this.dgvuserinf.RowHeadersWidth = 62;
            this.dgvuserinf.RowTemplate.Height = 28;
            this.dgvuserinf.Size = new System.Drawing.Size(934, 208);
            this.dgvuserinf.TabIndex = 29;
            this.dgvuserinf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvuserinf_CellClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserPhone
            // 
            this.UserPhone.DataPropertyName = "UserPhone";
            this.UserPhone.HeaderText = "UserPhone";
            this.UserPhone.MinimumWidth = 8;
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            // 
            // UserEmail
            // 
            this.UserEmail.DataPropertyName = "UserEmail";
            this.UserEmail.HeaderText = "UserEmail";
            this.UserEmail.MinimumWidth = 8;
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(884, 173);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(116, 42);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // txtuphone
            // 
            this.txtuphone.Location = new System.Drawing.Point(816, 99);
            this.txtuphone.Name = "txtuphone";
            this.txtuphone.Size = new System.Drawing.Size(184, 30);
            this.txtuphone.TabIndex = 3;
            this.txtuphone.TextChanged += new System.EventHandler(this.txtuphone_TextChanged);
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(816, 61);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(184, 30);
            this.txtuname.TabIndex = 2;
            this.txtuname.TextChanged += new System.EventHandler(this.txtuname_TextChanged);
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(816, 21);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(184, 30);
            this.txtuid.TabIndex = 1;
            this.txtuid.TextChanged += new System.EventHandler(this.txtuid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "User Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "User Phone: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "User ID: ";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(695, 180);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(115, 35);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnstaffacc
            // 
            this.btnstaffacc.Location = new System.Drawing.Point(473, 24);
            this.btnstaffacc.Name = "btnstaffacc";
            this.btnstaffacc.Size = new System.Drawing.Size(144, 75);
            this.btnstaffacc.TabIndex = 30;
            this.btnstaffacc.Text = "Manage staff account";
            this.btnstaffacc.UseVisualStyleBackColor = true;
            this.btnstaffacc.Visible = false;
            this.btnstaffacc.Click += new System.EventHandler(this.btnstaffacc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total users: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "int";
            // 
            // admininterf2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnstaffacc);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnmngbook);
            this.Controls.Add(this.btnaddacc);
            this.Controls.Add(this.dgvuserinf);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.txtuphone);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admininterf2";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.admininterf2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserinf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmngbook;
        private System.Windows.Forms.Button btnaddacc;
        private System.Windows.Forms.DataGridView dgvuserinf;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.TextBox txtuphone;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnstaffacc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}