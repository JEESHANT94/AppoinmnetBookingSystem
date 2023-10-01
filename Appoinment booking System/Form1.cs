using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment2_Programing_Jeeshant.AppoinmentBooking;

namespace Assignment2_Programing_Jeeshant
{
    public partial class AppoinmentBooking : Form
    {
        private Regex _stringRegex = new Regex(@"^[A-Za-z0-9 _]*[A-Za-z0-9][A-Za-z0-9 _]*$");
        private Regex _cityOrAddressRegex = new Regex(@"^[A-Za-z0-9 _]*[A-Za-z0-9][A-Za-z0-9 _]*$");

        
        private Office _appointment = new Office();


        // office class where i am add all patients
        public class Office
        {
            public List<Appointment> Patients { get; set; } = new List<Appointment>();

            public void AddPatient(Appointment Patient)
            {
                Patients.Add(Patient);
            }

        }
        public class Appointment
        {
            public override string ToString()
            {
                string appointmentInfo = $"-----------------------------------------------------\n" +
                         $"Patient Name: {GetName()}\n" +
                         $"Age: {GetDob()}\n" +
                         $"Address: {GetAddress()}\n" +
                         $"City: {GetCity()}\n" +
                         $"Province: {GetProvince()}\n" +
                         $"Postal Code: {GetPostalCode()}\n" +
                         $"Phone Number: {GetMobileNumber()}\n" +
                         $"Email: {GetEmail()}\n" +
                         $"Appointment time: {GetAppointmentTime().ToString("MM/dd/yyyy hh:mmtt")}\n" +
                         $"Appointment duration: {GetMinutes()} minutes\n" +
                         $"Description: {GetDescription()}\n" +
                         $"-----------------------------------------------------";

                return appointmentInfo;
            }
            public Appointment(string name, string address, int dob, string city, string postalCode, string province, string email, string mobileNumber, DateTime appointmentTime, int duration, string description, DateTime requestedEndTime, string minutes)
            {
                _Name = name;
                _Address = address;
                _Dob = dob;
                _City = city;
                _PostalCode = postalCode;
                _Province = province;
                _Email = email;
                _MobileNumber = mobileNumber;
                _AppointmentTime = appointmentTime;
                _Duration = duration;
                _Description = description;
                _End = requestedEndTime;
                _Minutes = minutes;



            }
            public string GetName()
            {
                return _Name;
            }
            public string GetAddress()
            {
                return _Address;
            }
            public int GetDob()
            {
                return _Dob;
            }
            public string GetCity()
            {
                return _City;
            }
            public string GetPostalCode()
            {
                return _PostalCode;
            }
            public string GetEmail()
            {
                return _Email;
            }
            public string GetProvince()
            {
                return _Province;
            }
            public string GetMobileNumber()
            {
                return _MobileNumber;
            }
            public string GetDescription()
            {
                return _Description;
            }
            public DateTime GetAppointmentTime()
            {
                return _AppointmentTime;
            }
            public int GetDuration()
            {
                return _Duration;
            }
            public DateTime GetEndTime()
            {
                return _End;
            }
            public string GetMinutes()
            {
                return _Minutes;
            }
            private string _Name { get; set; }

            private string _Address { get; set; }

            private int _Dob { get; set; }

            private string _City { get; set; }

            private string _PostalCode { get; set; }
            private string _Province { get; set; }
            private string _Email { get; set; }
            private string _MobileNumber { get; set; }
            private int _Duration { get; set; }
            private DateTime _AppointmentTime { get; set; }
            private string _Description { get; set; }
            private DateTime _End { get; set; }
            private string _Minutes { get; set; }
        }
        public class ValidationHelper
        {



            public static bool IsValidPhoneNumber(string phoneNumber)
            {
                if (string.IsNullOrEmpty(phoneNumber))
                {
                    return false;
                }


                Regex phoneRegex = new Regex(@"^\d{10}$");
                return phoneRegex.IsMatch(phoneNumber);
            }

            public static bool IsValidPostalCode(string postalCode)
            {
                if (string.IsNullOrEmpty(postalCode))
                {
                    return false;
                }


                Regex postalRegex = new Regex(@"[A-Z]{1}[0-9]{1}[A-Z]{1}\s?[0-9]{1}[A-Z]{1}[0-9]{1}");
                return postalRegex.IsMatch(postalCode);
            }

            public static bool IsValidEmail(string email)
            {
                if (string.IsNullOrEmpty(email))
                {
                    return false;
                }

                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


                return emailRegex.IsMatch(email);


            }

            public static bool IsValidPatientAge(DateTime dateOfBirth)
            {
                int age = CalculateAge(dateOfBirth);
                return age >= 18;
            }
            public static int CalculateAge(DateTime dateOfBirth)
            {
                int age = DateTime.Today.Year - dateOfBirth.Year;


                if (dateOfBirth.Date > DateTime.Today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }

        public AppoinmentBooking()
        {
            InitializeComponent();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                string patientName = txtPatientName.Text;
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string postalCode = txtpostalCode.Text;
                string province = txtProvince.Text;
                DateTime dob = dateTimePicker1.Value;
                string mobile = txtPhone.Text;
                string eMail = txtEmail.Text;
                DateTime appointmentTime = dateTimePicker2.Value;
              
                string description = txtDescription.Text;

                string minutes = cmbDuration.SelectedItem.ToString();


                if (cmbDuration.SelectedItem == null)
                {
                    MessageBox.Show("Please select Duration of Office");
                    return;
                }
                if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("One or more fields are empty");
                    return;
                }


                string numericString = new string(minutes.Where(char.IsDigit).ToArray()); // Remove non-numeric characters
                int duration = int.Parse(numericString);
                DateTime requestedEndTime = appointmentTime.AddMinutes(duration);



                // Check if the requested appointment time overlaps with any existing appointments
                foreach (Appointment appointment in _appointment.Patients)
                {
                    if (appointmentTime >= appointment.GetAppointmentTime() && appointmentTime <= appointment.GetEndTime())

                    {
                        // An overlapping appointment exists, show an error message and return
                        MessageBox.Show("Cannot book appointment during another patient's scheduled appointment time.");

                        return;
                    }
                }
                Appointment newPatient = new Appointment(patientName, address, GetDifferenceInYears(dateTimePicker1.Value, DateTime.Now), city, postalCode, province, eMail, mobile, appointmentTime, duration, description, requestedEndTime, minutes);

                _appointment.AddPatient(newPatient);
                string formattedDate = appointmentTime.ToString("MM-dd");
                MessageBox.Show("Successfully Booked Appointment on " + formattedDate + " " + appointmentTime.Hour + ":" + appointmentTime.Minute);

            }
            catch (Exception ex)
            {
                lblErrorName.Text = ex.Message;
                lblErrorName.ForeColor = Color.Red;
                lblErrorName.Visible = true;
            }
        }

        private void txtpostalCode_TextChanged(object sender, EventArgs e)
        {


            if (ValidationHelper.IsValidPostalCode(txtpostalCode.Text))
            {
                lblErrorPostal.Visible = false;
                return;
            }
            lblErrorPostal.Visible = true;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (ValidationHelper.IsValidPhoneNumber(txtPhone.Text))
            {
                lblErrorPhone.Visible = false;
                return;
            }
            lblErrorPhone.Visible = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (ValidationHelper.IsValidEmail(txtEmail.Text))
            {
                lblErrorEmail.Visible = false;
                return;
            }
            lblErrorEmail.Visible = true;
        }

        int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            return (endDate.Year - startDate.Year - 1) +
                (((endDate.Month > startDate.Month) ||
                ((endDate.Month == startDate.Month) && (endDate.Day >= startDate.Day))) ? 1 : 0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {



            if (ValidationHelper.IsValidPatientAge(dateTimePicker1.Value))
            {

                lblErrorAge.Visible = false;

                return;
            }

            lblErrorAge.Visible = true;
        }

        private void tmrAddEnable_Tick(object sender, EventArgs e)
        {
            if (lblErrorAge.Visible == true ||
                lblErrorEmail.Visible == true ||
              lblErrorPhone.Visible == true ||
              lblErrorPostal.Visible == true ||
              lblErrorName.Visible == true ||
              lblErrorName.Visible == true ||
              lblErrorCityAndAddress.Visible == true)
            {
                btnBookAppointment.Enabled = false;
            }
            else
            {
                btnBookAppointment.Enabled = true;
            }
        }

        private void AppoinmentBooking_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            tmrAddEnable.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPatientName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtpostalCode.Text = "";
            txtProvince.Text = "";
            dateTimePicker1.ResetText();
            txtPhone.Text = "";
            txtEmail.Text = "";
            dateTimePicker2.ResetText();
            txtDescription.Text = "";
            cmbDuration.SelectedIndex = -1;
        }

        private void btnPreFillFields_Click(object sender, EventArgs e)
        {
            txtPatientName.Text = "Jeeshant Patel";
            txtAddress.Text = "45 Newyourktown";
            txtCity.Text = "Kitchener";
            txtpostalCode.Text = "N2M 4P1";
            txtProvince.Text = "Ontario";
            dateTimePicker1.Value = DateTime.Now.AddYears(-18);
            txtPhone.Text = "4589875682";
            txtEmail.Text = "JeeshantTest45@gmail.com";
            dateTimePicker2.Value = DateTime.Now;
            cmbDuration.SelectedIndex = 2;
            txtDescription.Text = "This is Test.";
        }



        public void PrintAppoinments()
        {
            if (_appointment.Patients.Count == 0)
            {
                MessageBox.Show("There are no appointments to print.", "No Appointments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (StreamWriter writer = new StreamWriter("Appointments.txt"))
            {

                foreach (Appointment patient in _appointment.Patients)
                {
                    writer.WriteLine(patient.ToString());
                }
                MessageBox.Show("All appointments have been printed successfully to Appointment.", "Print Appointments", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintAppoinments();
        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            if (_stringRegex.IsMatch(txtPatientName.Text))
            {
                lblErrorName.Visible = false;
                return;
            }
            lblErrorName.Visible = true;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (_stringRegex.IsMatch(txtPatientName.Text))
            {
                lblErrorName.Visible = false;
                return;
            }
            lblErrorName.Visible = true;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (_cityOrAddressRegex.IsMatch(txtCity.Text))
            {
                lblErrorCityAndAddress.Visible = false;
                return;
            }
            lblErrorCityAndAddress.Visible = true;
        }

        private void txtProvince_TextChanged(object sender, EventArgs e)
        {
            if (_cityOrAddressRegex.IsMatch(txtProvince.Text))
            {
                lblErrorCityAndAddress.Visible = false;
                return;
            }
            lblErrorCityAndAddress.Visible = true;
        }
    



    }
}

