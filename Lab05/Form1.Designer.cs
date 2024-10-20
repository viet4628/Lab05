namespace Lab05
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupInfoStudent = new System.Windows.Forms.GroupBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd_Update = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbChuaDK = new System.Windows.Forms.CheckBox();
            this.btnRegisterMajor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDK = new System.Windows.Forms.ToolStripMenuItem();
            this.groupInfoStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // groupInfoStudent
            // 
            this.groupInfoStudent.Controls.Add(this.btnMore);
            this.groupInfoStudent.Controls.Add(this.btnDelete);
            this.groupInfoStudent.Controls.Add(this.btnAdd_Update);
            this.groupInfoStudent.Controls.Add(this.pictureBox);
            this.groupInfoStudent.Controls.Add(this.cmbFaculty);
            this.groupInfoStudent.Controls.Add(this.txtAverageScore);
            this.groupInfoStudent.Controls.Add(this.txtName);
            this.groupInfoStudent.Controls.Add(this.txtStudentID);
            this.groupInfoStudent.Controls.Add(this.label6);
            this.groupInfoStudent.Controls.Add(this.label5);
            this.groupInfoStudent.Controls.Add(this.label4);
            this.groupInfoStudent.Controls.Add(this.label3);
            this.groupInfoStudent.Controls.Add(this.label2);
            this.groupInfoStudent.Location = new System.Drawing.Point(23, 96);
            this.groupInfoStudent.Name = "groupInfoStudent";
            this.groupInfoStudent.Size = new System.Drawing.Size(302, 424);
            this.groupInfoStudent.TabIndex = 1;
            this.groupInfoStudent.TabStop = false;
            this.groupInfoStudent.Text = "Thông tin sinh viên";
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(263, 195);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(33, 23);
            this.btnMore.TabIndex = 4;
            this.btnMore.Text = "•••";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd_Update
            // 
            this.btnAdd_Update.Location = new System.Drawing.Point(81, 383);
            this.btnAdd_Update.Name = "btnAdd_Update";
            this.btnAdd_Update.Size = new System.Drawing.Size(83, 23);
            this.btnAdd_Update.TabIndex = 4;
            this.btnAdd_Update.Text = "Add /Update";
            this.btnAdd_Update.UseVisualStyleBackColor = true;
            this.btnAdd_Update.Click += new System.EventHandler(this.btnAdd_Update_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(83, 195);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(174, 171);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(81, 108);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(176, 21);
            this.cmbFaculty.TabIndex = 2;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(81, 148);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(176, 20);
            this.txtAverageScore.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(81, 45);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(176, 20);
            this.txtStudentID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ảnh Đại Diện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm TB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV";
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStudent.Location = new System.Drawing.Point(353, 105);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(714, 415);
            this.dgvStudent.TabIndex = 2;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Khoa";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm TB";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Chuyên ngành";
            this.Column5.Name = "Column5";
            // 
            // cbChuaDK
            // 
            this.cbChuaDK.AutoSize = true;
            this.cbChuaDK.Location = new System.Drawing.Point(936, 82);
            this.cbChuaDK.Name = "cbChuaDK";
            this.cbChuaDK.Size = new System.Drawing.Size(140, 17);
            this.cbChuaDK.TabIndex = 3;
            this.cbChuaDK.Text = "Chưa DK chuyên ngành";
            this.cbChuaDK.UseVisualStyleBackColor = true;
            this.cbChuaDK.CheckedChanged += new System.EventHandler(this.cbChuaDK_CheckedChanged);
            // 
            // btnRegisterMajor
            // 
            this.btnRegisterMajor.Location = new System.Drawing.Point(936, 541);
            this.btnRegisterMajor.Name = "btnRegisterMajor";
            this.btnRegisterMajor.Size = new System.Drawing.Size(131, 23);
            this.btnRegisterMajor.TabIndex = 4;
            this.btnRegisterMajor.Text = "Đăng ký chuyên ngành";
            this.btnRegisterMajor.UseVisualStyleBackColor = true;
            this.btnRegisterMajor.Click += new System.EventHandler(this.btnRegisterMajor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDK,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // menuDK
            // 
            this.menuDK.Name = "menuDK";
            this.menuDK.Size = new System.Drawing.Size(196, 22);
            this.menuDK.Text = "Đăng ký chuyên ngành";
            this.menuDK.Click += new System.EventHandler(this.menuDK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 576);
            this.Controls.Add(this.cbChuaDK);
            this.Controls.Add(this.btnRegisterMajor);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.groupInfoStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupInfoStudent.ResumeLayout(false);
            this.groupInfoStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupInfoStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd_Update;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.CheckBox cbChuaDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnRegisterMajor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

