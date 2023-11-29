namespace Asm2DB
{
    partial class addaccount
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
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtupass = new System.Windows.Forms.TextBox();
            this.txtuphone = new System.Windows.Forms.TextBox();
            this.txtuemail = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnaddu = new System.Windows.Forms.Button();
            this.dgvregister = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txturoleid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregister)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "UserPhone: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "UserEmail: ";
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(155, 45);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(176, 23);
            this.txtuid.TabIndex = 1;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(155, 85);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(176, 23);
            this.txtuname.TabIndex = 2;
            // 
            // txtupass
            // 
            this.txtupass.Location = new System.Drawing.Point(155, 223);
            this.txtupass.Name = "txtupass";
            this.txtupass.Size = new System.Drawing.Size(176, 23);
            this.txtupass.TabIndex = 5;
            // 
            // txtuphone
            // 
            this.txtuphone.Location = new System.Drawing.Point(155, 131);
            this.txtuphone.Name = "txtuphone";
            this.txtuphone.Size = new System.Drawing.Size(176, 23);
            this.txtuphone.TabIndex = 3;
            // 
            // txtuemail
            // 
            this.txtuemail.Location = new System.Drawing.Point(155, 176);
            this.txtuemail.Name = "txtuemail";
            this.txtuemail.Size = new System.Drawing.Size(176, 23);
            this.txtuemail.TabIndex = 4;
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(79, 288);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(93, 51);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "&Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnaddu
            // 
            this.btnaddu.Location = new System.Drawing.Point(211, 288);
            this.btnaddu.Name = "btnaddu";
            this.btnaddu.Size = new System.Drawing.Size(93, 51);
            this.btnaddu.TabIndex = 6;
            this.btnaddu.Text = "&Add";
            this.btnaddu.UseVisualStyleBackColor = true;
            this.btnaddu.Click += new System.EventHandler(this.btnaddu_Click);
            // 
            // dgvregister
            // 
            this.dgvregister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvregister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.UserPhone,
            this.UserEmail,
            this.UserPass,
            this.RoleID});
            this.dgvregister.Location = new System.Drawing.Point(478, 50);
            this.dgvregister.Name = "dgvregister";
            this.dgvregister.ReadOnly = true;
            this.dgvregister.RowHeadersWidth = 62;
            this.dgvregister.RowTemplate.Height = 28;
            this.dgvregister.Size = new System.Drawing.Size(559, 256);
            this.dgvregister.TabIndex = 3;
            this.dgvregister.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvregister_CellClick);
            this.dgvregister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvregister_CellContentClick);
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
            // UserPass
            // 
            this.UserPass.DataPropertyName = "UserPass";
            this.UserPass.HeaderText = "UserPass";
            this.UserPass.MinimumWidth = 8;
            this.UserPass.Name = "UserPass";
            this.UserPass.ReadOnly = true;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "RoleID";
            this.RoleID.Name = "RoleID";
            this.RoleID.ReadOnly = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(345, 288);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(93, 51);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(211, 357);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(93, 51);
            this.btndel.TabIndex = 7;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(478, 357);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(93, 51);
            this.btnrefresh.TabIndex = 9;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "RoleID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txturoleid
            // 
            this.txturoleid.Location = new System.Drawing.Point(155, 255);
            this.txturoleid.Name = "txturoleid";
            this.txturoleid.Size = new System.Drawing.Size(176, 23);
            this.txturoleid.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Manage Account";
            // 
            // addaccount
            // 
            this.AcceptButton = this.btnaddu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(1118, 444);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvregister);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnaddu);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtuemail);
            this.Controls.Add(this.txturoleid);
            this.Controls.Add(this.txtuphone);
            this.Controls.Add(this.txtupass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addaccount";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.addaccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvregister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtupass;
        private System.Windows.Forms.TextBox txtuphone;
        private System.Windows.Forms.TextBox txtuemail;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnaddu;
        private System.Windows.Forms.DataGridView dgvregister;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txturoleid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.Label label7;
    }
}