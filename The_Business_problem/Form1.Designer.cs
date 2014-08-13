namespace The_Business_problem
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
            this.components = new System.ComponentModel.Container();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbCourtesy = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbPostal = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbExtension = new System.Windows.Forms.TextBox();
            this.tbHomePhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSupervisor = new System.Windows.Forms.ListBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpHire = new System.Windows.Forms.DateTimePicker();
            this.nORTHWNDDataSet = new The_Business_problem.NORTHWNDDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new The_Business_problem.NORTHWNDDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWNDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(53, 51);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(122, 20);
            this.tbTitle.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(517, 51);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(122, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(362, 51);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(122, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbCourtesy
            // 
            this.tbCourtesy.Location = new System.Drawing.Point(208, 51);
            this.tbCourtesy.Name = "tbCourtesy";
            this.tbCourtesy.Size = new System.Drawing.Size(122, 20);
            this.tbCourtesy.TabIndex = 3;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(53, 188);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(296, 20);
            this.tbAddress.TabIndex = 6;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(53, 246);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(122, 20);
            this.tbCity.TabIndex = 7;
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(267, 246);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(122, 20);
            this.tbRegion.TabIndex = 8;
            // 
            // tbPostal
            // 
            this.tbPostal.Location = new System.Drawing.Point(53, 294);
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.Size = new System.Drawing.Size(122, 20);
            this.tbPostal.TabIndex = 9;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(267, 294);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(122, 20);
            this.tbCountry.TabIndex = 10;
            // 
            // tbExtension
            // 
            this.tbExtension.Location = new System.Drawing.Point(53, 342);
            this.tbExtension.Name = "tbExtension";
            this.tbExtension.Size = new System.Drawing.Size(122, 20);
            this.tbExtension.TabIndex = 11;
            // 
            // tbHomePhone
            // 
            this.tbHomePhone.Location = new System.Drawing.Point(267, 342);
            this.tbHomePhone.Name = "tbHomePhone";
            this.tbHomePhone.Size = new System.Drawing.Size(122, 20);
            this.tbHomePhone.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add new Employe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSupervisor
            // 
            this.lbSupervisor.DataSource = this.employeesBindingSource;
            this.lbSupervisor.DisplayMember = "LastName";
            this.lbSupervisor.FormattingEnabled = true;
            this.lbSupervisor.Location = new System.Drawing.Point(53, 431);
            this.lbSupervisor.Name = "lbSupervisor";
            this.lbSupervisor.Size = new System.Drawing.Size(120, 95);
            this.lbSupervisor.TabIndex = 14;
            this.lbSupervisor.ValueMember = "EmployeeID";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(53, 387);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(336, 20);
            this.tbNotes.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Salutations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Birth Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Hire Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Region";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Postal Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Extension";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Home Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Notes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 415);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Supervisor";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(12, 122);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 33;
            // 
            // dtpHire
            // 
            this.dtpHire.Location = new System.Drawing.Point(227, 122);
            this.dtpHire.Name = "dtpHire";
            this.dtpHire.Size = new System.Drawing.Size(200, 20);
            this.dtpHire.TabIndex = 34;
            // 
            // nORTHWNDDataSet
            // 
            this.nORTHWNDDataSet.DataSetName = "NORTHWNDDataSet";
            this.nORTHWNDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.nORTHWNDDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 563);
            this.Controls.Add(this.dtpHire);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.lbSupervisor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbHomePhone);
            this.Controls.Add(this.tbExtension);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbPostal);
            this.Controls.Add(this.tbRegion);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbCourtesy);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbTitle);
            this.Name = "Form1";
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWNDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbCourtesy;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbPostal;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbExtension;
        private System.Windows.Forms.TextBox tbHomePhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbSupervisor;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
      
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.DateTimePicker dtpHire;
        private NORTHWNDDataSet nORTHWNDDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private NORTHWNDDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;

    }
}

