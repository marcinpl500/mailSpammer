using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace mail
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void sendBtn_Click(object sender, EventArgs e)
		{
			Timer MyTimer = new Timer();
			MyTimer.Interval = ( 20 * 1000); 
			MyTimer.Tick += new EventHandler(MyTimer_Tick);
			MyTimer.Start();


		}
		private void MyTimer_Tick(object sender, EventArgs e)
		{

			string text, topic, email;
			text = textTxt.Text;
			topic = subjectTxt.Text;
			email = emailTxt.Text;
			int amount = (int)timesNum.Value;

			MailMessage mail = new MailMessage("gardymarcin@gmail.com", email);
			SmtpClient client = new SmtpClient("smtp.gmail.com", 465);
			
			client.Credentials = new NetworkCredential("mojmail@mail.com",
				"haslo"); 
			client.EnableSsl = true;

			mail.Subject = topic;
			mail.Body = text;

			for (int i = 0; i < amount - 1; i++)
			{
				client.Send(mail);
			}
			Close();

		}
	}
}
