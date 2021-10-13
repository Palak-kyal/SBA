
namespace SBAC
{
    partial class Schedule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblselect = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblistatus = new System.Windows.Forms.Label();
            this.lbliname = new System.Windows.Forms.Label();
            this.lblskills = new System.Windows.Forms.Label();
            this.lblinterviewstatus = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbinterviewer = new System.Windows.Forms.ComboBox();
            this.cmbuser = new System.Windows.Forms.ComboBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.cmbskills = new System.Windows.Forms.ComboBox();
            this.cmbtechnical = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmbtechnical);
            this.groupBox1.Controls.Add(this.cmbskills);
            this.groupBox1.Controls.Add(this.cmbstatus);
            this.groupBox1.Controls.Add(this.cmbuser);
            this.groupBox1.Controls.Add(this.cmbinterviewer);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtremark);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblRemark);
            this.groupBox1.Controls.Add(this.lblinterviewstatus);
            this.groupBox1.Controls.Add(this.lblskills);
            this.groupBox1.Controls.Add(this.lbliname);
            this.groupBox1.Controls.Add(this.lblistatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbluser);
            this.groupBox1.Controls.Add(this.lblselect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interview";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(752, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 391);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Location = new System.Drawing.Point(25, 52);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(92, 13);
            this.lblselect.TabIndex = 0;
            this.lblselect.Text = "Select Interviewer";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(25, 98);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(62, 13);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "Select User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // lblistatus
            // 
            this.lblistatus.AutoSize = true;
            this.lblistatus.Location = new System.Drawing.Point(25, 195);
            this.lblistatus.Name = "lblistatus";
            this.lblistatus.Size = new System.Drawing.Size(83, 13);
            this.lblistatus.TabIndex = 4;
            this.lblistatus.Text = "Interview Status";
            this.lblistatus.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbliname
            // 
            this.lbliname.AutoSize = true;
            this.lbliname.Location = new System.Drawing.Point(389, 56);
            this.lbliname.Name = "lbliname";
            this.lbliname.Size = new System.Drawing.Size(90, 13);
            this.lbliname.TabIndex = 5;
            this.lbliname.Text = "Interviewer Name";
            // 
            // lblskills
            // 
            this.lblskills.AutoSize = true;
            this.lblskills.Location = new System.Drawing.Point(389, 98);
            this.lblskills.Name = "lblskills";
            this.lblskills.Size = new System.Drawing.Size(56, 13);
            this.lblskills.TabIndex = 6;
            this.lblskills.Text = "User Skills";
            // 
            // lblinterviewstatus
            // 
            this.lblinterviewstatus.AutoSize = true;
            this.lblinterviewstatus.Location = new System.Drawing.Point(371, 146);
            this.lblinterviewstatus.Name = "lblinterviewstatus";
            this.lblinterviewstatus.Size = new System.Drawing.Size(132, 13);
            this.lblinterviewstatus.TabIndex = 7;
            this.lblinterviewstatus.Text = "Technical interview Status";
            this.lblinterviewstatus.Click += new System.EventHandler(this.lblinterviewstatus_Click);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(389, 195);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(44, 13);
            this.lblRemark.TabIndex = 8;
            this.lblRemark.Text = "Remark";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(481, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(481, 192);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(231, 20);
            this.txtremark.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // cmbinterviewer
            // 
            this.cmbinterviewer.FormattingEnabled = true;
            this.cmbinterviewer.Location = new System.Drawing.Point(123, 43);
            this.cmbinterviewer.Name = "cmbinterviewer";
            this.cmbinterviewer.Size = new System.Drawing.Size(231, 21);
            this.cmbinterviewer.TabIndex = 17;
            this.cmbinterviewer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbuser
            // 
            this.cmbuser.FormattingEnabled = true;
            this.cmbuser.Location = new System.Drawing.Point(123, 98);
            this.cmbuser.Name = "cmbuser";
            this.cmbuser.Size = new System.Drawing.Size(231, 21);
            this.cmbuser.TabIndex = 18;
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(123, 195);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(231, 21);
            this.cmbstatus.TabIndex = 19;
            // 
            // cmbskills
            // 
            this.cmbskills.FormattingEnabled = true;
            this.cmbskills.Location = new System.Drawing.Point(481, 98);
            this.cmbskills.Name = "cmbskills";
            this.cmbskills.Size = new System.Drawing.Size(231, 21);
            this.cmbskills.TabIndex = 20;
            // 
            // cmbtechnical
            // 
            this.cmbtechnical.FormattingEnabled = true;
            this.cmbtechnical.Location = new System.Drawing.Point(509, 140);
            this.cmbtechnical.Name = "cmbtechnical";
            this.cmbtechnical.Size = new System.Drawing.Size(209, 21);
            this.cmbtechnical.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 161);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(47, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 49);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(47, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblinterviewstatus;
        private System.Windows.Forms.Label lblskills;
        private System.Windows.Forms.Label lbliname;
        private System.Windows.Forms.Label lblistatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbtechnical;
        private System.Windows.Forms.ComboBox cmbskills;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.ComboBox cmbuser;
        private System.Windows.Forms.ComboBox cmbinterviewer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}