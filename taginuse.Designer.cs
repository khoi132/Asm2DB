namespace Asm2DB
{
    partial class taginuse
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
            this.dgvtaginuse = new System.Windows.Forms.DataGridView();
            this.TagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnback = new System.Windows.Forms.Button();
            this.btnmovetag = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.lbtid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaginuse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtaginuse
            // 
            this.dgvtaginuse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtaginuse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaginuse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TagID,
            this.UserID,
            this.BookID,
            this.BorrowedDate,
            this.ReturnDate});
            this.dgvtaginuse.Location = new System.Drawing.Point(12, 89);
            this.dgvtaginuse.Name = "dgvtaginuse";
            this.dgvtaginuse.ReadOnly = true;
            this.dgvtaginuse.RowHeadersWidth = 62;
            this.dgvtaginuse.RowTemplate.Height = 28;
            this.dgvtaginuse.Size = new System.Drawing.Size(776, 289);
            this.dgvtaginuse.TabIndex = 0;
            this.dgvtaginuse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaginuse_CellClick);
            this.dgvtaginuse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaginuse_CellContentClick);
            // 
            // TagID
            // 
            this.TagID.DataPropertyName = "TagID";
            this.TagID.HeaderText = "TagID";
            this.TagID.MinimumWidth = 8;
            this.TagID.Name = "TagID";
            this.TagID.ReadOnly = true;
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
            // BorrowedDate
            // 
            this.BorrowedDate.DataPropertyName = "BorrowedDate";
            this.BorrowedDate.HeaderText = "BorrowedDate";
            this.BorrowedDate.MinimumWidth = 8;
            this.BorrowedDate.Name = "BorrowedDate";
            this.BorrowedDate.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.MinimumWidth = 8;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(12, 27);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(93, 42);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnmovetag
            // 
            this.btnmovetag.Location = new System.Drawing.Point(548, 27);
            this.btnmovetag.Name = "btnmovetag";
            this.btnmovetag.Size = new System.Drawing.Size(227, 42);
            this.btnmovetag.TabIndex = 3;
            this.btnmovetag.Text = "Move tag to Tagdated";
            this.btnmovetag.UseVisualStyleBackColor = true;
            this.btnmovetag.Click += new System.EventHandler(this.btnmovetag_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(111, 27);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(93, 42);
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // lbtid
            // 
            this.lbtid.AutoSize = true;
            this.lbtid.Location = new System.Drawing.Point(425, 36);
            this.lbtid.Name = "lbtid";
            this.lbtid.Size = new System.Drawing.Size(0, 17);
            this.lbtid.TabIndex = 5;
            // 
            // taginuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.lbtid);
            this.Controls.Add(this.btnmovetag);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvtaginuse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "taginuse";
            this.Text = "=";
            this.Load += new System.EventHandler(this.taginuse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaginuse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtaginuse;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnmovetag;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.Label lbtid;
    }
}