using SmorcIRL.TempMail;
using SmorcIRL.TempMail.Models;

namespace TEMP_MAIL_GENERATOR
{
    public partial class App_Base : Form
    {
        public App_Base()
        {
            InitializeComponent();

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "Generating Mail..Please wait.";
            insta_mail insta_Mails = new insta_mail();
            string email = await insta_Mails.Mail_gen();
            textBox1.Text = email;
            textBox2.Text = "Waiting for OTP for : "+email;

            string otp = await insta_Mails.OTP_waiter();
            textBox2.Text = otp;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}