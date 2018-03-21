using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Web;

using System.Net.Mail;

using System.Net;


namespace Emailer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
	
		String password = "92Kwiatuszek";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			
			
	
		}
		void BWyslijClick(object sender, EventArgs e)
		{
			SmtpClient client = new SmtpClient("smtp.gmail.com", 465 );
			client.Credentials = new NetworkCredential("bartek.92k@gmail.com",password);
			MailMessage msg = new MailMessage();
			msg.From = new MailAddress("bartek.92k@gmail.com");
			msg.To.Add(new MailAddress(textBox1.Text));
			msg.Subject = textBox2.Text;
			msg.Body = textBox3.Text;
			try{
				client.Send(msg);
				MessageBox.Show("wysłano wiadomosc");
			}catch(Exception exp){
				MessageBox.Show("Błąd, nie wysłano"+exp);
		}
		}
	}
}
			
			