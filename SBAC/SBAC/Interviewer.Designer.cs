
namespace SBAC
{
    partial class Interviewer
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblinterviewdate = new System.Windows.Forms.Label();
            this.lblskill = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.cmbskill = new System.Windows.Forms.ComboBox();
            this.cmbExp = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 105);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(225, 105);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(148, 26);
            this.txtname.TabIndex = 1;
            // 
            // lblinterviewdate
            // 
            this.lblinterviewdate.AutoSize = true;
            this.lblinterviewdate.Location = new System.Drawing.Point(634, 105);
            this.lblinterviewdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinterviewdate.Name = "lblinterviewdate";
            this.lblinterviewdate.Size = new System.Drawing.Size(111, 20);
            this.lblinterviewdate.TabIndex = 2;
            this.lblinterviewdate.Text = "Interview Date";
            // 
            // lblskill
            // 
            this.lblskill.AutoSize = true;
            this.lblskill.Location = new System.Drawing.Point(69, 238);
            this.lblskill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblskill.Name = "lblskill";
            this.lblskill.Size = new System.Drawing.Size(71, 20);
            this.lblskill.TabIndex = 3;
            this.lblskill.Text = "SkillType";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(69, 372);
            this.lblExperience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(88, 20);
            this.lblExperience.TabIndex = 5;
            this.lblExperience.Text = "Experience";
            // 
            // cmbskill
            // 
            this.cmbskill.FormattingEnabled = true;
            this.cmbskill.Location = new System.Drawing.Point(225, 225);
            this.cmbskill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbskill.Name = "cmbskill";
            this.cmbskill.Size = new System.Drawing.Size(180, 28);
            this.cmbskill.TabIndex = 8;
            // 
            // cmbExp
            // 
            this.cmbExp.FormattingEnabled = true;
            this.cmbExp.Location = new System.Drawing.Point(225, 360);
            this.cmbExp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbExp.Name = "cmbExp";
            this.cmbExp.Size = new System.Drawing.Size(180, 28);
            this.cmbExp.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(825, 103);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(476, 460);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(249, 66);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Interviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbExp);
            this.Controls.Add(this.cmbskill);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblskill);
            this.Controls.Add(this.lblinterviewdate);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Interviewer";
            this.Text = "Interviewer";
            this.Load += new System.EventHandler(this.Interviewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblinterviewdate;
        private System.Windows.Forms.Label lblskill;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.ComboBox cmbskill;
        private System.Windows.Forms.ComboBox cmbExp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRegister;
    }
}