namespace Asm2DB
{
    partial class managestaffacc
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.dgvstaffacc = new System.Windows.Forms.DataGridView();
            this.AdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaffacc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(23, 211);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(96, 46);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(23, 143);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(96, 46);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(135, 143);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(96, 46);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(391, 250);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(96, 46);
            this.btndel.TabIndex = 6;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // dgvstaffacc
            // 
            this.dgvstaffacc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvstaffacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstaffacc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminName,
            this.AdminPass});
            this.dgvstaffacc.Location = new System.Drawing.Point(391, 12);
            this.dgvstaffacc.Name = "dgvstaffacc";
            this.dgvstaffacc.ReadOnly = true;
            this.dgvstaffacc.RowHeadersWidth = 62;
            this.dgvstaffacc.RowTemplate.Height = 28;
            this.dgvstaffacc.Size = new System.Drawing.Size(448, 223);
            this.dgvstaffacc.TabIndex = 2;
            this.dgvstaffacc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstaffacc_CellClick);
            // 
            // AdminName
            // 
            this.AdminName.DataPropertyName = "AdminName";
            this.AdminName.HeaderText = "AdminName";
            this.AdminName.MinimumWidth = 8;
            this.AdminName.Name = "AdminName";
            this.AdminName.ReadOnly = true;
            // 
            // AdminPass
            // 
            this.AdminPass.DataPropertyName = "AdminPass";
            this.AdminPass.HeaderText = "AdminPass";
            this.AdminPass.MinimumWidth = 8;
            this.AdminPass.Name = "AdminPass";
            this.AdminPass.ReadOnly = true;
            // 
            // txtacc
            // 
            this.txtacc.Location = new System.Drawing.Point(164, 37);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(182, 23);
            this.txtacc.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(164, 82);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(182, 23);
            this.txtpass.TabIndex = 2;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "AdminName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "AdminPass";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(743, 250);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(96, 46);
            this.btnrefresh.TabIndex = 7;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(250, 143);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(96, 46);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // managestaffacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.dgvstaffacc);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnback);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "managestaffacc";
            this.Text = "BTEC Library Online";
            this.Load += new System.EventHandler(this.managestaffacc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaffacc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.DataGridView dgvstaffacc;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminPass;
    }
}