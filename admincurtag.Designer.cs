namespace Asm2DB
{
    partial class admincurtag
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
            this.dgvcurrenttag = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttagid = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtbid = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.timepickborrow = new System.Windows.Forms.DateTimePicker();
            this.timepickreturn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcurrenttag)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcurrenttag
            // 
            this.dgvcurrenttag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcurrenttag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcurrenttag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.BookID,
            this.Descriptions});
            this.dgvcurrenttag.Location = new System.Drawing.Point(514, 78);
            this.dgvcurrenttag.Name = "dgvcurrenttag";
            this.dgvcurrenttag.ReadOnly = true;
            this.dgvcurrenttag.RowHeadersWidth = 62;
            this.dgvcurrenttag.RowTemplate.Height = 28;
            this.dgvcurrenttag.Size = new System.Drawing.Size(487, 302);
            this.dgvcurrenttag.TabIndex = 0;
            this.dgvcurrenttag.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcurrenttag_CellClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // Descriptions
            // 
            this.Descriptions.DataPropertyName = "Descriptions";
            this.Descriptions.HeaderText = "Descriptions";
            this.Descriptions.MinimumWidth = 8;
            this.Descriptions.Name = "Descriptions";
            this.Descriptions.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TagID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BorrowDate: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ReturnDate: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "UserID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "BookID: ";
            // 
            // txttagid
            // 
            this.txttagid.Location = new System.Drawing.Point(188, 79);
            this.txttagid.MaxLength = 7;
            this.txttagid.Name = "txttagid";
            this.txttagid.Size = new System.Drawing.Size(200, 23);
            this.txttagid.TabIndex = 1;
            this.txttagid.TextChanged += new System.EventHandler(this.txttagid_TextChanged);
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(188, 208);
            this.txtuid.MaxLength = 7;
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(200, 23);
            this.txtuid.TabIndex = 4;
            // 
            // txtbid
            // 
            this.txtbid.Location = new System.Drawing.Point(188, 255);
            this.txtbid.MaxLength = 7;
            this.txtbid.Name = "txtbid";
            this.txtbid.Size = new System.Drawing.Size(200, 23);
            this.txtbid.TabIndex = 5;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(514, 23);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(101, 36);
            this.btnrefresh.TabIndex = 9;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(387, 335);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 45);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(41, 335);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(88, 45);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(269, 335);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(88, 45);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(157, 335);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(88, 45);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // timepickborrow
            // 
            this.timepickborrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timepickborrow.Location = new System.Drawing.Point(188, 122);
            this.timepickborrow.Name = "timepickborrow";
            this.timepickborrow.Size = new System.Drawing.Size(200, 23);
            this.timepickborrow.TabIndex = 2;
            // 
            // timepickreturn
            // 
            this.timepickreturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timepickreturn.Location = new System.Drawing.Point(188, 167);
            this.timepickreturn.Name = "timepickreturn";
            this.timepickreturn.Size = new System.Drawing.Size(200, 23);
            this.timepickreturn.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Manager borrows books";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // admincurtag
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(1067, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timepickreturn);
            this.Controls.Add(this.timepickborrow);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.txtbid);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.txttagid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcurrenttag);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admincurtag";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.admincurtag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcurrenttag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcurrenttag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttagid;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.TextBox txtbid;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptions;
        private System.Windows.Forms.DateTimePicker timepickborrow;
        private System.Windows.Forms.DateTimePicker timepickreturn;
        private System.Windows.Forms.Label label6;
    }
}