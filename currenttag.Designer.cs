namespace Asm2DB
{
    partial class currenttag
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.dgvbookinf = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.lbuid = new System.Windows.Forms.Label();
            this.lbbid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinf)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "The books are added";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(478, 210);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(95, 48);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "&Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(588, 210);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(95, 48);
            this.btnconfirm.TabIndex = 2;
            this.btnconfirm.Text = "&Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(323, 210);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(93, 45);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // dgvbookinf
            // 
            this.dgvbookinf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbookinf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbookinf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID});
            this.dgvbookinf.Location = new System.Drawing.Point(52, 75);
            this.dgvbookinf.MultiSelect = false;
            this.dgvbookinf.Name = "dgvbookinf";
            this.dgvbookinf.ReadOnly = true;
            this.dgvbookinf.RowHeadersWidth = 62;
            this.dgvbookinf.RowTemplate.Height = 28;
            this.dgvbookinf.Size = new System.Drawing.Size(238, 204);
            this.dgvbookinf.TabIndex = 6;
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
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(323, 85);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(93, 45);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // lbuid
            // 
            this.lbuid.AutoSize = true;
            this.lbuid.Location = new System.Drawing.Point(38, 17);
            this.lbuid.Name = "lbuid";
            this.lbuid.Size = new System.Drawing.Size(31, 17);
            this.lbuid.TabIndex = 7;
            this.lbuid.Text = "UID";
            this.lbuid.Visible = false;
            // 
            // lbbid
            // 
            this.lbbid.AutoSize = true;
            this.lbbid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbbid.Location = new System.Drawing.Point(38, 42);
            this.lbbid.Name = "lbbid";
            this.lbbid.Size = new System.Drawing.Size(0, 17);
            this.lbbid.TabIndex = 8;
            this.lbbid.Visible = false;
            // 
            // currenttag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 317);
            this.Controls.Add(this.lbbid);
            this.Controls.Add(this.lbuid);
            this.Controls.Add(this.dgvbookinf);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "currenttag";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.currenttag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookinf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.DataGridView dgvbookinf;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.Label lbuid;
        private System.Windows.Forms.Label lbbid;
    }
}