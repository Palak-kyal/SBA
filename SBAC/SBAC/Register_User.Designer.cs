
namespace SBAC
{
    partial class Register_User
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
            this.lblFname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.lblmobile = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblreport = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtreport = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.cmbusertype = new System.Windows.Forms.ComboBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(58, 56);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(60, 13);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First_Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(58, 128);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email";
            this.lblemail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.Location = new System.Drawing.Point(58, 210);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(56, 13);
            this.lblUsertype.TabIndex = 2;
            this.lblUsertype.Text = "User Type";
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.Location = new System.Drawing.Point(58, 281);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(38, 13);
            this.lblmobile.TabIndex = 3;
            this.lblmobile.Text = "Mobile";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(481, 56);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(61, 13);
            this.lblLname.TabIndex = 4;
            this.lblLname.Text = "Last_Name";
            // 
            // lblreport
            // 
            this.lblreport.AutoSize = true;
            this.lblreport.Location = new System.Drawing.Point(481, 128);
            this.lblreport.Name = "lblreport";
            this.lblreport.Size = new System.Drawing.Size(66, 13);
            this.lblreport.TabIndex = 5;
            this.lblreport.Text = "ReportingTo";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(481, 210);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(62, 13);
            this.lblstatus.TabIndex = 6;
            this.lblstatus.Text = "User Status";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(140, 56);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 7;
            // 
            // txtreport
            // 
            this.txtreport.Location = new System.Drawing.Point(567, 121);
            this.txtreport.Name = "txtreport";
            this.txtreport.Size = new System.Drawing.Size(100, 20);
            this.txtreport.TabIndex = 10;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(140, 281);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(100, 20);
            this.txtmobile.TabIndex = 11;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(140, 128);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 13;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(567, 56);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(100, 20);
            this.txtlname.TabIndex = 14;
            // 
            // cmbusertype
            // 
            this.cmbusertype.FormattingEnabled = true;
            this.cmbusertype.Items.AddRange(new object[] {
            "1. Trainee",
            "2.TraineeIntern",
            "3. Manager",
            "4. Developer",
            "5. FresherAssociate",
            "6. TeamLead",
            "7. TeamSupervisor",
            "8. DeliveryLead",
            "9. ProductionLead",
            "10. NotAssigned"});
            this.cmbusertype.Location = new System.Drawing.Point(140, 207);
            this.cmbusertype.Name = "cmbusertype";
            this.cmbusertype.Size = new System.Drawing.Size(121, 21);
            this.cmbusertype.TabIndex = 15;
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.cmbstatus.Location = new System.Drawing.Point(567, 206);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(121, 21);
            this.cmbstatus.TabIndex = 16;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(293, 324);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 50);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(481, 281);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 18;
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(567, 274);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(121, 20);
            this.txtPass.TabIndex = 19;
            // 
            // Register_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.cmbusertype);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.txtreport);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblreport);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblmobile);
            this.Controls.Add(this.lblUsertype);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblFname);
            this.Name = "Register_User";
            this.Text = "Register_User";
            this.Load += new System.EventHandler(this.Register_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblUsertype;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblreport;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtreport;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.ComboBox cmbusertype;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
    }
}