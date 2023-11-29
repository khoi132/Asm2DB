namespace Asm2DB
{
    partial class tagdated
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
            this.btndel = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvtagdated = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtgid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtagdated)).BeginInit();
            this.SuspendLayout();
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(679, 33);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(106, 42);
            this.btndel.TabIndex = 6;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(121, 33);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(93, 42);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(22, 33);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(93, 42);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dgvtagdated
            // 
            this.dgvtagdated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtagdated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtagdated.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.TagID,
            this.BookID,
            this.ReturnDate});
            this.dgvtagdated.Location = new System.Drawing.Point(22, 95);
            this.dgvtagdated.Name = "dgvtagdated";
            this.dgvtagdated.ReadOnly = true;
            this.dgvtagdated.RowHeadersWidth = 62;
            this.dgvtagdated.RowTemplate.Height = 28;
            this.dgvtagdated.Size = new System.Drawing.Size(776, 289);
            this.dgvtagdated.TabIndex = 3;
            this.dgvtagdated.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtagdated_CellClick);
            this.dgvtagdated.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtagdated_CellContentClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // TagID
            // 
            this.TagID.DataPropertyName = "TagID";
            this.TagID.HeaderText = "TagID";
            this.TagID.MinimumWidth = 8;
            this.TagID.Name = "TagID";
            this.TagID.ReadOnly = true;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.MinimumWidth = 8;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // lbtgid
            // 
            this.lbtgid.AutoSize = true;
            this.lbtgid.Location = new System.Drawing.Point(529, 50);
            this.lbtgid.Name = "lbtgid";
            this.lbtgid.Size = new System.Drawing.Size(0, 17);
            this.lbtgid.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total tag dated: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "ReturnDate";
            // 
            // tagdated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 400);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtgid);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvtagdated);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tagdated";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.tagdated_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtagdated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvtagdated;
        private System.Windows.Forms.Label lbtgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}