namespace Assignment2_Programing_Jeeshant
{
    partial class AppoinmentBooking
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtpostalCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblRequestAppointment = new System.Windows.Forms.Label();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPreFillFields = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorPostal = new System.Windows.Forms.Label();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.lblErrorAge = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.tmrAddEnable = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorCityAndAddress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtpostalCode);
            this.groupBox1.Controls.Add(this.txtProvince);
            this.groupBox1.Controls.Add(this.lblPostal);
            this.groupBox1.Controls.Add(this.lblProvince);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.lblPatient);
            this.groupBox1.Location = new System.Drawing.Point(60, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 607);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 533);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 35);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(26, 466);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(290, 35);
            this.txtPhone.TabIndex = 15;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 514);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(23, 447);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 16);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone Number:";
            // 
            // txtpostalCode
            // 
            this.txtpostalCode.Location = new System.Drawing.Point(26, 393);
            this.txtpostalCode.Multiline = true;
            this.txtpostalCode.Name = "txtpostalCode";
            this.txtpostalCode.Size = new System.Drawing.Size(290, 35);
            this.txtpostalCode.TabIndex = 12;
            this.txtpostalCode.TextChanged += new System.EventHandler(this.txtpostalCode_TextChanged);
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(26, 313);
            this.txtProvince.Multiline = true;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(290, 35);
            this.txtProvince.TabIndex = 11;
            this.txtProvince.TextChanged += new System.EventHandler(this.txtProvince_TextChanged);
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(23, 365);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(84, 16);
            this.lblPostal.TabIndex = 10;
            this.lblPostal.Text = "Postal Code:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(23, 294);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(63, 16);
            this.lblProvince.TabIndex = 9;
            this.lblProvince.Text = "Province:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(27, 244);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(290, 35);
            this.txtCity.TabIndex = 8;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(27, 174);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(290, 35);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 155);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(25, 98);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date of Birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(25, 225);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 16);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(28, 46);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(290, 35);
            this.txtPatientName.TabIndex = 2;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtPatientName_TextChanged);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(25, 27);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(91, 16);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Patient Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPurpose);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.lblDuration);
            this.groupBox2.Controls.Add(this.cmbDuration);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.lblRequestAppointment);
            this.groupBox2.Location = new System.Drawing.Point(521, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointmnet Information";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(20, 148);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(150, 16);
            this.lblPurpose.TabIndex = 21;
            this.lblPurpose.Text = "Purpose of Appointmnet";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(23, 167);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(365, 119);
            this.txtDescription.TabIndex = 20;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(20, 93);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(135, 16);
            this.lblDuration.TabIndex = 19;
            this.lblDuration.Text = "AppointmnetDuration:";
            // 
            // cmbDuration
            // 
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Items.AddRange(new object[] {
            "15 Min",
            "30 Min",
            "45 Min",
            "60 Min"});
            this.cmbDuration.Location = new System.Drawing.Point(23, 112);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(286, 24);
            this.cmbDuration.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(23, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(286, 22);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // lblRequestAppointment
            // 
            this.lblRequestAppointment.AutoSize = true;
            this.lblRequestAppointment.Location = new System.Drawing.Point(20, 29);
            this.lblRequestAppointment.Name = "lblRequestAppointment";
            this.lblRequestAppointment.Size = new System.Drawing.Size(148, 16);
            this.lblRequestAppointment.TabIndex = 5;
            this.lblRequestAppointment.Text = "Requested Office Time:";
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(534, 384);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(145, 48);
            this.btnBookAppointment.TabIndex = 2;
            this.btnBookAppointment.Text = "Book Appointmnet";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(703, 384);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 48);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Fields";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPreFillFields
            // 
            this.btnPreFillFields.Location = new System.Drawing.Point(534, 466);
            this.btnPreFillFields.Name = "btnPreFillFields";
            this.btnPreFillFields.Size = new System.Drawing.Size(145, 48);
            this.btnPreFillFields.TabIndex = 4;
            this.btnPreFillFields.Text = "Pre-Fill Fields";
            this.btnPreFillFields.UseVisualStyleBackColor = true;
            this.btnPreFillFields.Click += new System.EventHandler(this.btnPreFillFields_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(703, 466);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(145, 48);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(531, 537);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(377, 16);
            this.lblErrorEmail.TabIndex = 6;
            this.lblErrorEmail.Text = "Email must be provided in a valid format (e.g. test@gmail.com)";
            // 
            // lblErrorPostal
            // 
            this.lblErrorPostal.AutoSize = true;
            this.lblErrorPostal.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPostal.Location = new System.Drawing.Point(531, 557);
            this.lblErrorPostal.Name = "lblErrorPostal";
            this.lblErrorPostal.Size = new System.Drawing.Size(304, 16);
            this.lblErrorPostal.TabIndex = 7;
            this.lblErrorPostal.Text = "Postal Code Must be in valid format (e.g. N3B 1C5)";
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhone.Location = new System.Drawing.Point(531, 573);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(341, 16);
            this.lblErrorPhone.TabIndex = 8;
            this.lblErrorPhone.Text = "Phone Number must be in valid format (e.g. 1234567890) ";
            // 
            // lblErrorAge
            // 
            this.lblErrorAge.AutoSize = true;
            this.lblErrorAge.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAge.Location = new System.Drawing.Point(531, 589);
            this.lblErrorAge.Name = "lblErrorAge";
            this.lblErrorAge.Size = new System.Drawing.Size(220, 16);
            this.lblErrorAge.TabIndex = 9;
            this.lblErrorAge.Text = "Appointment must be 18 year of age";
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(531, 605);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(124, 16);
            this.lblErrorName.TabIndex = 10;
            this.lblErrorName.Text = "Please Enter Name";
            // 
            // tmrAddEnable
            // 
            this.tmrAddEnable.Tick += new System.EventHandler(this.tmrAddEnable_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(415, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 11;
            // 
            // lblErrorCityAndAddress
            // 
            this.lblErrorCityAndAddress.AutoSize = true;
            this.lblErrorCityAndAddress.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCityAndAddress.Location = new System.Drawing.Point(531, 626);
            this.lblErrorCityAndAddress.Name = "lblErrorCityAndAddress";
            this.lblErrorCityAndAddress.Size = new System.Drawing.Size(248, 16);
            this.lblErrorCityAndAddress.TabIndex = 12;
            this.lblErrorCityAndAddress.Text = "Please Enter City, Province and Address";
            // 
            // AppoinmentBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 712);
            this.Controls.Add(this.lblErrorCityAndAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.lblErrorAge);
            this.Controls.Add(this.lblErrorPhone);
            this.Controls.Add(this.lblErrorPostal);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreFillFields);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppoinmentBooking";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AppoinmentBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtpostalCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblRequestAppointment;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPreFillFields;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPostal;
        private System.Windows.Forms.Label lblErrorPhone;
        private System.Windows.Forms.Label lblErrorAge;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Timer tmrAddEnable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorCityAndAddress;
    }
}

